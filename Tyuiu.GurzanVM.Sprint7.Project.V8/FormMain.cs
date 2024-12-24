namespace Tyuiu.GurzanVM.Sprint7.Project.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label_GVM_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMY_GVM_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
