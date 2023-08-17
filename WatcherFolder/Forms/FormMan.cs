using WatcherFolder.Config;

namespace WatcherFolder
{
    public partial class FormMan : Form
    {
        public FormMan()
        {
            InitializeComponent();
        }


        protected override void OnLoad(EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;
            base.OnLoad(e);

            var Configs = CustomEnvironment.AllSettings;
            if (Configs is null)
            {
                MessageBox.Show("Selecione uma pasta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                FileSystemWatcher watcher = new FileSystemWatcher();

                watcher.Path = Configs.FolderName;

                watcher.NotifyFilter = NotifyFilters.Attributes | NotifyFilters.CreationTime | NotifyFilters.FileName | NotifyFilters.Size;

                watcher.Filter = "*";

                watcher.IncludeSubdirectories = true;

                watcher.Changed += new FileSystemEventHandler(onChange);
                watcher.Created += new FileSystemEventHandler(onChange);
                watcher.Deleted += new FileSystemEventHandler(onChange);

                watcher.EnableRaisingEvents = true;
            }
        }

        private void onChange(object source, FileSystemEventArgs e)
        {
            base.Invoke((Action)delegate
            {
                MessageBox.Show($"Nome do arquivo: {e.Name}, Tipo: {e.ChangeType}, Pasta: {e.FullPath}", "Deu certo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            });
        }
    }
}