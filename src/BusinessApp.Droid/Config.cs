using System;
using BusinessApp.Dao;
using Xamarin.Forms;

[assembly: Dependency(typeof (BusinessApp.Droid.Config))]

namespace BusinessApp.Droid
{
    public class Config : IConfig
    {
        #region IConfig implementation

        private string _diretorioDb;

        public string DiretorioDb
        {
            get
            {
                if (string.IsNullOrEmpty(_diretorioDb))
                {
                    _diretorioDb = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                }
                return _diretorioDb;
            }
        }

        private SQLite.Net.Interop.ISQLitePlatform _plataforma;

        public SQLite.Net.Interop.ISQLitePlatform Plataforma
        {
            get
            {
                if (_plataforma == null)
                {
                    _plataforma = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
                }
                return _plataforma;
            }
        }

        #endregion
    }
}