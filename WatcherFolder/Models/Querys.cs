namespace WatcherFolder.Models
{
    public class Querys
    {
        public const string ConnectionString = "Data Source={0}{1}; Version=3;";
        public const string Db = "\\WatcherFolder.sqlite";
        public const string CreateTable = "CREATE TABLE IF NOT EXISTS Settings (Id INTEGER PRIMARY KEY, Name TEXT, Value TEXT)";
        public const string GetSettings = "SELECT * FROM Settings WHERE Name = {0}";
        public const string CreateSettings = "INSERT INTO Settings(Id, Name, Value)VALUES(@Id, @Name, @Value)";
        public const string UpdateSettings = "UPDATE Settings SET Value = {0} WHERE Id = {1}";
    }
}
