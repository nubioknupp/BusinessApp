using SQLite.Net.Interop;

namespace BusinessApp.Dao
{
    public interface IConfig
    {
        string DiretorioDb { get; }

        ISQLitePlatform Plataforma { get; }
    }
}