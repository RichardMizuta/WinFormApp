using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WinFormApp1
{
    public partial class F_Main : Form
    {
        private Random _rnd = new Random();
        private ArrayList _enemies = new ArrayList();
        public F_Main()
        {
            InitializeComponent();
        }

        private void F_Main_Load(object sender, EventArgs e)
        {

        }
        private void F_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }

        private void B_Start_Click(object sender, EventArgs e)
        {
            B_Start.Enabled = false;

            for (int i = 0; i <= 9; i++)
            {
                _enemies.Add(new CEnemy(P_Enemy, _rnd));
                Application.DoEvents();
            }
        }

        private void P_Enemy_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
