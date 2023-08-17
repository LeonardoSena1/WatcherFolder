using WatcherFolder.Config;
using WatcherFolder.Models;
using WatcherFolder.SqlHelper;

namespace WatcherFolder.Forms
{
    public partial class FormConfig : Form
    {
        public ConfigFolder Configs { get; set; }

        public FormConfig(bool Ini = false)
        {
            InitializeComponent();
            TexBoxFolder.Enabled = false;

            Configs = CustomEnvironment.AllSettings;
            TexBoxFolder.Text = Configs is not null ? Configs.FolderName : string.Empty;

            if (Ini)
                InitializeMain();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }


        private void InitializeMain()
        {
            Configs = CustomEnvironment.AllSettings;

            if (Configs is null)
            {
                EditFolderName(null, null);                
            }
            else
            {
                TexBoxFolder.Text = Configs.FolderName;
                Close();
            }
        }

        private void ButtonCreateOrUpdateFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
                if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    SqLiteHelper.InsertSetting(
                        new ConfigFolder()
                        {
                            FolderName = fbd.SelectedPath
                        });
                    DialogResult = DialogResult.OK;
                }

            Close();
        }

        public void EditFolderName(object sender, EventArgs e)
        {
            var customForm = new FormConfig();

            int x = Screen.PrimaryScreen.WorkingArea.Width - customForm.Width;
            int y = Screen.PrimaryScreen.WorkingArea.Height - customForm.Height;
            customForm.StartPosition = FormStartPosition.Manual;
            customForm.Location = new Point(x, y);

            customForm.ShowDialog();

            if (customForm.DialogResult == DialogResult.OK)
            {
                new FormMan().Show();
            }

            customForm.Dispose();
        }

        public void OnSobre(object sender, EventArgs e)
        {
            MessageBox.Show("Desenvolvido por Leonardo");
        }

        public void OnExit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
