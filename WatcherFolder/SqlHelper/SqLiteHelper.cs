using System.Data.SQLite;
using WatcherFolder.Models;

namespace WatcherFolder.SqlHelper
{
    internal class SqLiteHelper
    {
        public static string ConnectionString
        {
            get
            {
                return string.Format(Querys.ConnectionString, Environment.CurrentDirectory, Querys.Db);
            }
        }

        public static void CreateDatabase()
        {
            if (!System.IO.File.Exists(Environment.CurrentDirectory + Querys.Db))
            {
                SQLiteConnection.CreateFile(Environment.CurrentDirectory + Querys.Db);
                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();

                    using (SQLiteCommand command = new SQLiteCommand(Querys.CreateTable, connection))
                        command.ExecuteNonQuery();
                }
            }
        }

        public static List<ConfigFolder> GetAllSettings()
        {
            List<ConfigFolder> Imagens = new List<ConfigFolder>();

            using (var sqlCnn = new SQLiteConnection(ConnectionString))
            {
                sqlCnn.Open();

                using (var sqlCmd = new SQLiteCommand(string.Format(Querys.GetSettings, "1"), sqlCnn))
                using (var sqlReader = sqlCmd.ExecuteReader())
                    while (sqlReader.Read())
                        Imagens.Add(
                            new ConfigFolder()
                            {
                                Id = sqlReader["Id"] != DBNull.Value ? (int)sqlReader["Id"] : -1,
                                FolderName = sqlReader["Value"] != DBNull.Value ? (int)sqlReader["Value"] : -1
                            });
            }

            return Imagens;
        }

        public static void InsertSetting(ConfigFolder Model)
        {
            using (var sqlCnn = new SQLiteConnection(ConnectionString))
            {
                sqlCnn.Open();

                using (var sqlCmd = new SQLiteCommand(Querys.CreateSettings, sqlCnn))
                {
                    _ = sqlCmd.Parameters.AddWithValue("@Name", "FolderName");
                    _ = sqlCmd.Parameters.AddWithValue("@Value", Model.FolderName);
                    _ = sqlCmd.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateSetting(ConfigFolder Model)
        {
            using (var sqlCnn = new SQLiteConnection(ConnectionString))
            {
                sqlCnn.Open();

                using (var sqlCmd = new SQLiteCommand(string.Format(Querys.UpdateSettings, Model.FolderName, Model.Id), sqlCnn))
                    _ = sqlCmd.ExecuteNonQuery();
            }
        }
    }
}
