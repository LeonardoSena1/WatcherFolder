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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            SqLiteHelper.CreateDatabase();

            var app = new ApplicationContext();

            using var notifyIcon = new NotifyIcon
            {
                Icon = new System.Drawing.Icon(Environment.CurrentDirectory + "\\Sources\\Img\\binoculars.ico"),
                Visible = true
            };

            var contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add("Editar Nome da Pasta", null, EditFolderName);
            contextMenu.Items.Add("Sobre", null, OnSobre);
            contextMenu.Items.Add("Sair", null, OnExit);
            notifyIcon.ContextMenuStrip = contextMenu;

            Application.Run(app);
        }

        private static void EditFolderName(object sender, EventArgs e)
        {
            var customForm = new Form1();

            // Calcula a posição no canto direito inferior da tela
            int x = Screen.PrimaryScreen.WorkingArea.Width - customForm.Width;
            int y = Screen.PrimaryScreen.WorkingArea.Height - customForm.Height;
            customForm.StartPosition = FormStartPosition.Manual;
            customForm.Location = new Point(x, y);

            customForm.ShowDialog();

            if (customForm.DialogResult == DialogResult.OK)
            {
                string novoNome = customForm.NovoNome;
                // Implemente a lógica para usar o novo nome da pasta
            }

            customForm.Dispose();
        }

        private static void OnSobre(object sender, EventArgs e)
        {
            MessageBox.Show("Desenvolvido por Leonardo");
        }

        static void OnExit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}