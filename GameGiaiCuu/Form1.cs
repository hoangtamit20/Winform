using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms.BunifuButton;

namespace GameGiaiCuu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] cayCau = new int[10];


        private void btnStart_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for(int i = 0; i < cayCau.Length; i++)
                cayCau[i] = random.Next(0,2);
            btnTren0.Enabled = true;
            btnDuoi0.Enabled = true;
            lbSoQuan.Text = "5";
        }

        private void btnClick(object sender, EventArgs e)
        {
            BunifuButton button = (BunifuButton)sender;
            int soTT = int.Parse(button.Name.Substring(button.Name.Length - 1));
            if (button.Name.StartsWith("btnTren") && cayCau[soTT] != 0
                || button.Name.StartsWith("btnDuoi") && cayCau[soTT] != 1)
            {
                int soLinh = int.Parse(lbSoQuan.Text) - 1;
                lbSoQuan.Text = soLinh.ToString();
                if (soLinh == 0)
                {
                    MessageBox.Show("You lose!");
                    return;
                }
                xoaLichSu();
                return;
            }
            if (soTT == 9)
            {
                MessageBox.Show("You Win!");
                picktureBox.Image = Image.FromFile("../images/golden.png");
                return;
            }
            BunifuButton btnTren = (BunifuButton)this.Controls["btnTren" + (soTT + 1)];
            btnTren.Enabled = true;
            BunifuButton btnDuoi = (BunifuButton)this.Controls["btnDuoi" + (soTT + 1)];
            btnDuoi.Enabled = true;
            button.BackColor = System.Drawing.Color.CadetBlue;
        }

        

        private void xoaLichSu()
        {
            for (int i = 0; i < 10; i++)
            {
                BunifuButton btTrai = (BunifuButton)this.Controls["btnTren" + i];
                btTrai.BackColor = default(Color);
                if (i != 0)
                    btTrai.Enabled = false;

                BunifuButton btPhai = (BunifuButton)this.Controls["btnDuoi" + i];
                btPhai.BackColor = default(Color);
                if (i != 0)
                    btPhai.Enabled = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lbSoQuan.Text = "5";
            for (int i = 0; i < 10; i++)
            {
                BunifuButton button = (BunifuButton)this.Controls["btnTren" + i];
                button.Enabled = false;
                BunifuButton buttonDuoi = (BunifuButton)this.Controls["btnDuoi" + i];
                buttonDuoi.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
