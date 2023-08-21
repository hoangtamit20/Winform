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
    public partial class GameQuaCau : Form
    {
        public GameQuaCau()
        {
            InitializeComponent();
        }
        int[] cayCau = new int[10];
        private void btnStart_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            for (int i=0; i<cayCau.Length; i++)
            {
                cayCau[i] = rd.Next(0, 2);
            }
            btnTrai0.Enabled = true;
            btnPhai0.Enabled = true;
            lblSoLinh.Text = "5";
        }

        private void buocTrai_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            int soTT = int.Parse(bt.Name.Substring(bt.Name.Length - 1));
            if(bt.Name.StartsWith("btnTrai") && cayCau[soTT]!=0
                || bt.Name.StartsWith("btnPhai") && cayCau[soTT] != 1)
            {
                int soQuan = int.Parse(lblSoLinh.Text)-1;
                lblSoLinh.Text = soQuan.ToString();
                if (soQuan == 0)
                {
                    MessageBox.Show("You lose");
                    //Reset
                    
                }
                XoaLichSu();
                return;
            }
            if (soTT == 9)
            {
                MessageBox.Show("YOU WIN");
                return;
            }
            Button btL = (Button)this.Controls["btnTrai" + (soTT + 1)];
            btL.Enabled = true;
            Button btR = (Button)this.Controls["btnPhai" + (soTT + 1)];
            btR.Enabled = true;
            bt.BackColor = System.Drawing.Color.CadetBlue;
        }
        public void XoaLichSu()
        {
            for(int i=0;i <10; i++)
            {
                Button btTrai = (Button)this.Controls["btnTrai" + i];
                btTrai.BackColor = default(Color);
                if(i!=0)
                    btTrai.Enabled = false;

                Button btPhai = (Button)this.Controls["btnPhai" + i];
                btPhai.BackColor = default(Color);
                if (i != 0) 
                    btPhai.Enabled = false;
            }
        }
    }
   
}
