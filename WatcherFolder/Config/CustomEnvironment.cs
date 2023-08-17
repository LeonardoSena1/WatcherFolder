namespace WatcherFolder.Config
{
    public class CustomEnvironment
    {
        public static string FolderName
        {
            get
            {
                return File.ReadAllText(File.Exists(Environment.CurrentDirectory + "\\config\\FolderName.txt") 
                    ? Environment.CurrentDirectory + "\\config\\FolderName.txt" : "CRIAR");
            }
        }
    }
}
