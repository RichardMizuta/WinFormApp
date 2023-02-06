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
        public int Enms;
        public int EnmTim;
        public int GmTim;
        private Random _rnd = new Random();
        private ArrayList _enemies = new ArrayList();
        public void FrmIni()
        {
            P_Enemy.Height = Height - P_Enemy.Top - 45;
            P_Enemy.Width = Width - 40;

            L_Sum.Text = "0";
            T_Enemy.Interval = EnmTim;
            PG_Jikan.Maximum = GmTim / 1000;
            PG_Jikan.Value = PG_Jikan.Maximum;
        }
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

            for (int i = 0; i <= Enms -1; i++)
            {
                _enemies.Add(new CEnemy(P_Enemy, _rnd));
                ((CEnemy)_enemies[i]).OnClick += new EventHandler(EnmOnClick);
                Application.DoEvents();
            }
            T_Enemy.Enabled = true;
            T_Jikan.Enabled = true;
        }

        private void P_Enemy_Paint(object sender, PaintEventArgs e)
        {

        }

        private void T_Enemy_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i <= _enemies.Count - 1; i++)
            {
                ((CEnemy)_enemies[i]).MvEnm();
                Application.DoEvents();
            }
        }

        private void T_Jikan_Tick(object sender, EventArgs e)
        {
            if ((PG_Jikan.Minimum) <= (PG_Jikan.Value - 1))
            {
                PG_Jikan.Value--;
            }
            else
            {
                PG_Jikan.Value = PG_Jikan.Minimum;
                T_Enemy.Enabled = false;
                T_Jikan.Enabled = false;
                MessageBox.Show("終了です\nあなたの得点は" + L_Sum.Text + "です");
                Close();
            }
        }
        private void EnmOnClick(object sender, EventArgs e)
        {
            L_Sum.Text = (Int32.Parse(L_Sum.Text) + ((CEnemy)sender).GetTokuten()).ToString();
            ((CEnemy)sender).EnemyDown();
        }

        private void PG_Jikan_Click(object sender, EventArgs e)
        {

        }
    }
}
