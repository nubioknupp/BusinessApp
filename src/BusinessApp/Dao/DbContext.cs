using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using BusinessApp.Model;
using SQLite.Net;
using Xamarin.Forms;

namespace BusinessApp.Dao
{
    public class DbContext : IDisposable
    {
        private SQLiteConnection _dbContext;

        public DbContext()
        {
            var config = DependencyService.Get<IConfig>();
            _dbContext = new SQLiteConnection(config.Plataforma, Path.Combine(config.DiretorioDb, "BusinessApp.db3"));

            _dbContext.CreateTable<Profile>();
        }

        public void InsertOrUpdate(Profile profile)
        {
            var profileFill = FillById(profile.Id);
            if (profileFill == null)
            {
                Insert(profile);
            } else
            {
                Update(profile);
            }
        }

        public void Insert(Profile profile)
        {
            _dbContext.Insert(profile);
        }

        public void Update(Profile profile)
        {
            _dbContext.Update(profile);
        }

        public Profile FillById(int id)
        {
            return _dbContext.Table<Profile>().FirstOrDefault(c => c.Id == id);
        }

        public List<Profile> ListAll()
        {
            return _dbContext.Table<Profile>().OrderBy(c => c.Name).ToList();
        }

        public void Delete(Profile profile)
        {
            _dbContext.Delete(profile);
        }

        public void Dispose()
        {
            _dbContext.Close();
            _dbContext.Dispose();
            _dbContext = null;
            GC.SuppressFinalize(this);
        }
    }
}