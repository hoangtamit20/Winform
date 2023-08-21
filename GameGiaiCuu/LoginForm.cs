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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text=="admin" && txtPassword.Text == "123456")
            {
                //Form1 f = new Form1();
                //f.Show();
                //if (f.Visible == true)
                //{

                //}
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                lbThongBao.Text = "user: admin; password 123456";

            }
        }


        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Yes de dong", "Close Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                e.Cancel = true;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Equals("User Name"))
            {
                txtUserName.Text = "";
                txtUserName.ForeColor = Color.Black;
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim().Equals(""))
            {
                txtUserName.Text = "User Name";
                txtUserName.ForeColor = System.Drawing.SystemColors.ControlDark;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
