using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameGiaiCuu
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnQuaCauKhi_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1() {Dock = DockStyle.Fill, TopLevel = false, TopMost = true};
            this.panelShowQuaCauKhi.Controls.Add(f);
            f.Show();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.panelShowQuaCauKhi.Controls.Remove(f);
            f.Close();
        }
    }
}
