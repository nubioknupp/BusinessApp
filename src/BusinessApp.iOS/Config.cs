using System;
using System.IO;
using BusinessApp.Dao;
using BusinessApp.iOS;
using SQLite.Net.Interop;
using SQLite.Net.Platform.XamarinIOS;
using Xamarin.Forms;

[assembly: Dependency(typeof (Config))]

namespace BusinessApp.iOS
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
                    var diretorio = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                    _diretorioDb = Path.Combine(diretorio, "..", "Library");
                }

                return _diretorioDb;
            }
        }

        private ISQLitePlatform _plataforma;

        public ISQLitePlatform Plataforma
        {
            get
            {
                if (_plataforma == null)
                {
                    _plataforma = new SQLitePlatformIOS();
                }
                return _plataforma;
            }
        }

        #endregion
    }
}