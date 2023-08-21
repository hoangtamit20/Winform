using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoiTuongCoBan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.monthCalendar1.MaxDate = DateTime.Today.AddYears(-18);
            this.monthCalendar1.MinDate = DateTime.Now.AddYears(-100);


            
        }

        private void timerChangeRadioButton_Tick(object sender, EventArgs e)
        {
            int soGiay = int.Parse(lbGiay.Text);
            lbGiay.Text = (soGiay - 1).ToString();
            if (soGiay == 1)
            {
                timerChangeRadioButton.Stop();
                MessageBox.Show("Het gio!", "Thong Bao!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                progressBar1.Value += 1;
                System.Threading.Thread.Sleep(1000);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "(*.txt)|*.txt|(*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog.FileName, richTextBox1.Text);
            }
        }
    }
}
