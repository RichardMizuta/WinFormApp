using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp1
{
    public partial class F_Main : Form
    {
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
    }
}
