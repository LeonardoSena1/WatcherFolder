using WatcherFolder.Config;

namespace WatcherFolder
{
    public partial class Form1 : Form
    {
        public string NovoNome { get; private set; }

        private TextBox txtNovoNome;
        private Button btnOK;
        private NotifyIcon trayIcon;

        public Form1()
        {
            InitializeComponent();
            InitializeMain();
            frmSelecionarPasta_Load();
        }

        private void frmSelecionarPasta_Load()
        {
            TextBoxPathFolder.Text = CustomEnvironment.FolderName;
            TextBoxPathFolder.Enabled = false;
        }

        private void InitializeMain()
        {



        }

        private void ButtonCreateOrUpdateFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
                if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    File.WriteAllText(CustomEnvironment.FolderName, string.Empty);
                    File.WriteAllText(CustomEnvironment.FolderName, fbd.SelectedPath);
                    DialogResult = DialogResult.OK;
                }

            Close();
        }
    }
}