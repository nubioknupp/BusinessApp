using SQLite.Net.Attributes;

namespace BusinessApp.Model
{
    public class Profile
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Profession { get; set; }

        public string Where { get; set; }

        public string Summary { get; set; }

    }
}