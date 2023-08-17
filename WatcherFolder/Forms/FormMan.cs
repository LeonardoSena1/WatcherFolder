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
        }
    }
}