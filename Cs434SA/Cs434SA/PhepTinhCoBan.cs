using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cs434SA
{
    public partial class PhepTinhCoBan : Form
    {
        public PhepTinhCoBan()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            int so1 = int.Parse(txtSo1.Text);
            int so2 = int.Parse(txtSo2.Text);
            lblKetQua.Text = so1 + " + " + so2 + " = " + (so1 + so2);
        }
    }
}
