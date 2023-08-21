using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UngDungTracNghiem
{
    public partial class FormTracNghiem : Form
    {
        public FormTracNghiem()
        {
            InitializeComponent();
        }

        ArrayList myList;
        int viTri = 0;

        private void FormTracNghiem_Load(object sender, EventArgs e)
        {
            DocCauHoi d = new DocCauHoi();
            myList = d.docFile();
            loadCau(viTri);
            NumberOfQuestion numberOfQuestion = new NumberOfQuestion { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelShowNumberOfQuestion.Controls.Add(numberOfQuestion);
            numberOfQuestion.Show();


        }


        public void loadCau(int i)
        {
            TracNghiem t = (TracNghiem)myList[i];
            lbNoiDung.Text = t.noiDung;
            lbA.Text = t.phuongAnA;
            lbB.Text = t.phuongAnB;
            lbC.Text = t.phuongAnC;
            lbD.Text = t.phuongAnD;
            lbA.Checked = lbD.Checked = lbC.Checked = lbB.Checked = false;
            if (t.traLoi == 0) lbA.Checked = true;
            if (t.traLoi == 1) lbB.Checked = true;
            if (t.traLoi == 2) lbC.Checked = true;
            if (t.traLoi == 3) lbD.Checked = true;
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            nhoDaChon();
            loadCau(++viTri);
            btnPreviousQuestion.Enabled = false;
            if (viTri == myList.Count - 1)
            {
                btnNextQuestion.Enabled = false;
                btnPreviousQuestion.Enabled = true;
            }
                
        }

        private void btnPreviousQuestion_Click(object sender, EventArgs e)
        {
            nhoDaChon();
            loadCau(--viTri);  
            btnNextQuestion.Enabled=true;
            if (viTri == 0)
                btnPreviousQuestion.Enabled = false;
        }

        private void nhoDaChon()
        {
            //((TracNghiem)myList[viTri]).traLoi = (lbA.Checked)?0:
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.ShowDialog();
        }
    }
}
