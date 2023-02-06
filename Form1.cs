using System.DirectoryServices.ActiveDirectory;
using System.Runtime.Intrinsics.X86;

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
            F_Main fMain = new F_Main
            {
                Height = 400,
                Width = 400,
                EnmTim = 1000,
                Enms = 20,
                GmTim = 15000,
            };
            fMain.FrmIni();
            fMain.Show(this);
            Hide();
        }
        private void B_Chukyu_Click_1(object sender, EventArgs e)
        {
            F_Main fMain = new F_Main
            {
                Height = 500,
                Width = 700,
                EnmTim = 800,
                Enms = 30,
                GmTim = 20000,
            };
            fMain.FrmIni();
            fMain.Show(this);
            Hide();
        }
        private void B_Jyokyu_Click_1(object sender, EventArgs e)
        {
            F_Main fMain = new F_Main
            {
                Height = 600,
                Width = 800,
                EnmTim = 300,
                Enms = 40,
                GmTim = 30000,
            };
            fMain.FrmIni();
            fMain.Show(this);
            Hide();
        }

        private void Owner_Load(object sender, EventArgs e)
        {

        }
        private void Owner_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}