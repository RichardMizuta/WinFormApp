using System.DirectoryServices.ActiveDirectory;

namespace WinFormApp1
{
    public partial class Owner : Form
    {
        public Owner()
        {
            InitializeComponent();
        }

        private void B_Syokyu_Click(object sender, EventArgs e)
        {
        }
        private void B_Chukyu_Click(object sender, EventArgs e)
        {

        }
        private void B_Jyokyu_Click(object sender, EventArgs e)
        {

        }

        private void B_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void B_Syokyu_Click_1(object sender, EventArgs e)
        {
            F_Main fMain = new F_Main();
            fMain.Show();
            Hide();
        }
    }
}