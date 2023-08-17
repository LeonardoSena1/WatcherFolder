using System.Collections.Generic;
using WatcherFolder.Models;
using WatcherFolder.SqlHelper;

namespace WatcherFolder.Config
{
    public class CustomEnvironment
    {
        public static ConfigFolder AllSettings
        {
            get
            {
                ConfigFolder Settings = SqLiteHelper.GetAllSettings();

                return String.IsNullOrEmpty(Settings.FolderName) ? null : Settings;
            }
        }
    }
}
