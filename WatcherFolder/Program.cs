using WatcherFolder.Forms;
using WatcherFolder.SqlHelper;

namespace WatcherFolder
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationConfiguration.Initialize();

            SqLiteHelper.CreateDatabase();

            var app = new ApplicationContext();
            var formConfig = new FormConfig(true);

            using var notifyIcon = new NotifyIcon
            {
                Icon = new System.Drawing.Icon(Environment.CurrentDirectory + "\\Sources\\Img\\binoculars.ico"),
                Visible = true
            };

            var contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add("Editar Pasta", null, new System.EventHandler(formConfig.EditFolderName));
            contextMenu.Items.Add("Sobre", null, new System.EventHandler(formConfig.OnSobre));
            contextMenu.Items.Add("Sair", null, new System.EventHandler(formConfig.OnExit));
            notifyIcon.ContextMenuStrip = contextMenu;


            //Application.Run(formConfig);
            Application.Run(new FormMan());
        }
    }
}