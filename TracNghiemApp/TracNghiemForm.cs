using Bunifu.UI.WinForms.BunifuButton;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TracNghiemApp
{
    public partial class TracNghiemForm : Form
    {
        public static string urlFile = "";
        public static int index = 0;
        ListQuestion listQuestion = new ListQuestion();
        List<TracNghiemModel> list;
        public TracNghiemForm()
        {
            InitializeComponent();
        }

        private void TracNghiemForm_Load(object sender, EventArgs e)
        {
            if (urlFile != "")
            {
                ListQuestion listQuestion = new ListQuestion();
                list = listQuestion.getListQuestion(urlFile, lbThongBao);
                loadTraLoi();
                setDapAn();               
            }
            else
            {
                lbThongBao.Visible = true;
                lbThongBao.Text = "Chương trình chưa được nạp câu hỏi!";
                btnSubmit.Visible = false;
                lbTimer.Visible = false;
                timerSubmit.Stop();
            }
            if (index == 0)
            {
                btnPreviousQuestion.Enabled = false;
            }
        }

        private void btnExitForm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co muon thoat khong?", "Thong Bao!", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (urlFile == "")
            {
                lbThongBao.Visible = true;
                lbThongBao.Text = "Chương trình chưa được nạp câu hỏi!";
                btnAddQuestion.Visible = true;
            }
            else
            {
                list = listQuestion.getListQuestion(urlFile, lbThongBao);
                lbThongBao.Visible = false;
            }
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(*.txt)|*.txt|(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    urlFile = ofd.FileName;
                    list = listQuestion.getListQuestion(urlFile, lbThongBao);
                    setDapAn();
                    loadTraLoi();
                    activeControls();
                    if (list.Count == 1)
                    {
                        btnNextQuestion.Enabled = false;
                        btnPreviousQuestion.Enabled = false;
                    }
                    loadQuestion(0);
                    loadButton();
                    btnSubmit.Visible = true;
                    lbThongBao.Visible = false;
                    lbTimer.Visible = true;
                    timerSubmit.Start();
                }
                catch
                {
                    MessageBox.Show("Cau truc file khong hop le!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            setTraLoi();
            BunifuButton btn = (BunifuButton)sender;
            int i = int.Parse(btn.Text);
            loadQuestion(i - 1);
            index = i - 1;
            if (lbTotalScore.Visible)
            {
                showAnswer(index);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (checkSubmit())
            {
                if (MessageBox.Show("Bạn có chắc chắn nộp bài không ?", "Thông Báo!",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    lbTotalScore.Visible = true;
                    lbTotalScore.Text = "Total : " + totalScore() + " / " + list.Count;
                    index = 0;
                    loadQuestion(index);
                    timerSubmit.Stop();
                    lbTimer.Visible = false;
                    if (lbTotalScore.Visible)
                        btnSubmit.Enabled = false;
                }
            }
            else
            {
                if (MessageBox.Show("Chưa hoàn thành bài làm. Bạn có chắc nộp bài không?", "Cảnh Báo!",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    timerSubmit.Stop();
                    lbTimer.Visible = false;
                    lbTotalScore.Visible = true;
                    lbTotalScore.Text = "Total : " + totalScore() + " / " + list.Count;
                }
            }
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            if (urlFile != "")
            {
                setTraLoi();
                loadQuestion(++index);
                if (index == list.Count - 1)
                {
                    btnNextQuestion.Enabled = false;
                    btnPreviousQuestion.Enabled = true;
                }
                else
                {
                    btnNextQuestion.Enabled = true;
                    btnPreviousQuestion.Enabled = true;
                }
                if (lbTotalScore.Visible)
                {
                    showAnswer(index);
                }
            }
        }

        private void btnPreviousQuestion_Click(object sender, EventArgs e)
        {
            if (urlFile != "")
            {
                setTraLoi();
                loadQuestion(--index);
                if (index == 0)
                {
                    btnNextQuestion.Enabled = true;
                    btnPreviousQuestion.Enabled = false;
                }
                else
                {
                    btnNextQuestion.Enabled = true;
                    btnPreviousQuestion.Enabled = true;
                }
                if (lbTotalScore.Visible)
                {
                    showAnswer(index);
                }
            }
        }

        private void btnPrevListNumber_Click(object sender, EventArgs e)
        {

        }

        private void btnNextListNumber_Click(object sender, EventArgs e)
        {

        }

        private void activeControls()
        {
            lbA.Visible = true;
            lbB.Visible = true;
            lbC.Visible = true;
            lbD.Visible = true;
            lbQuestion.Visible = true;
            txtPhuongAnA.Visible = true;
            txtPhuongAnB.Visible = true;
            txtPhuongAnC.Visible = true;
            txtPhuongAnD.Visible = true;
            rdBtnA.Visible = true;
            rdBtnB.Visible = true;
            rdBtnC.Visible = true;
            rdBtnD.Visible = true;
            btnNextQuestion.Visible = true;
            btnPreviousQuestion.Visible = true;
        }       
        
        private void loadButton()
        {
            int cot = 0, dong = 0;
            for (int i = 0; i < list.Count; i++)
            {
                BunifuButton button = new BunifuButton();
                button.Name = "" + (i + 1);
                button.Text = "" + (i + 1);
                button.Size = new Size(50, 50);
                button.IdleFillColor = Color.Transparent;
                button.ForeColor = Color.Black;
                button.Location = new Point(13 + cot * 50, 13 + dong * 50);
                cot++;
                if (cot == 5)
                {
                    cot = 0;
                    dong++;
                }
                button.Click += new EventHandler(Button_Click);
                panelNumberQuestion.Controls.Add(button);
            }
        }

        private void loadQuestion(int index)
        {
            TracNghiemModel model = list[index];
            lbQuestion.Text = model.noiDung;
            lbQuestion.AutoSize = true;
            lbQuestion.MaximumSize = new Size(400, 60);
            txtPhuongAnA.Text = model.phuongAnA.StartsWith("*") ? model.phuongAnA.Substring(1, model.phuongAnA.Length - 2) : model.phuongAnA;
            txtPhuongAnB.Text = model.phuongAnB.StartsWith("*") ? model.phuongAnB.Substring(1, model.phuongAnB.Length - 2) : model.phuongAnB;
            txtPhuongAnC.Text = model.phuongAnC.StartsWith("*") ? model.phuongAnC.Substring(1, model.phuongAnC.Length - 2) : model.phuongAnC;
            txtPhuongAnD.Text = model.phuongAnD.StartsWith("*") ? model.phuongAnD.Substring(1, model.phuongAnD.Length - 2) : model.phuongAnD;
            rdBtnA.Checked = rdBtnB.Checked = rdBtnC.Checked = rdBtnD.Checked = false;
            if (model.traLoi == 1) rdBtnA.Checked = true;
            if (model.traLoi == 2) rdBtnB.Checked = true;
            if (model.traLoi == 3) rdBtnC.Checked = true;
            if (model.traLoi == 4) rdBtnD.Checked = true;
            if (lbTotalScore.Visible)
            {
                showAnswer(index);
            }
        }

        private void setTraLoi()
        {
            if (rdBtnA.Checked)
                list[index].traLoi = 1;
            if (rdBtnB.Checked)
                list[index].traLoi = 2;
            if (rdBtnC.Checked)
                list[index].traLoi = 3;
            if (rdBtnD.Checked)
                list[index].traLoi = 4;
        }

        private void loadTraLoi()
        {
            for(int i = 0; i < list.Count; i++)
            {
                list[i].traLoi = -1;
            }
        }

        private void setDapAn()
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].phuongAnA.StartsWith("*"))
                {
                    list[i].dapAn = 1;
                }
                else if (list[i].phuongAnB.StartsWith("*"))
                {
                    list[i].dapAn = 2;
                }
                else if (list[i].phuongAnC.StartsWith("*"))
                {
                    list[i].dapAn = 3;
                }
                else
                {
                    list[i].dapAn = 4;
                }
            }
        }

        private int totalScore()
        {
            int total = 0;
            for(int i = 0; i < list.Count; i++)
            {
                if (list[i].traLoi == list[i].dapAn)
                {
                    total++;
                }
            }
            return total;
        }

        private bool checkSubmit()
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].traLoi == -1)
                    return false;
            }
            return true;
        }

        private void showAnswer(int index)
        {
            if (list[index].dapAn == 1)
            {
                lbA.BackColor = Color.Green;
                lbB.BackColor = Color.Transparent;
                lbC.BackColor = Color.Transparent;
                lbD.BackColor = Color.Transparent;
            }
            else if (list[index].dapAn == 2)
            {
                lbB.BackColor = Color.Green;
                lbA.BackColor = Color.Transparent;
                lbC.BackColor = Color.Transparent;
                lbD.BackColor = Color.Transparent;
            }
            else if (list[index].dapAn == 3)
            {
                lbC.BackColor = Color.Green;
                lbB.BackColor = Color.Transparent;
                lbA.BackColor = Color.Transparent;
                lbD.BackColor = Color.Transparent;
            }
            else if (list[index].dapAn == 4)
            {
                lbD.BackColor = Color.Green;
                lbB.BackColor = Color.Transparent;
                lbC.BackColor = Color.Transparent;
                lbA.BackColor = Color.Transparent;
            }
        }

        private void timerSubmit_Tick(object sender, EventArgs e)
        {
            string [] time = lbTimer.Text.Split(':');
            int minute = int.Parse(time[0].Trim());
            int second = int.Parse(time[1].Trim());
            if (second == 0)
            {
                second = 60 - 1;
                minute = minute - 1;
            }
            else
            {
                second = second - 1;
            }
            lbTimer.Text = "" + minute.ToString() + " : " + second.ToString();
            if (minute == 0 && second == 0)
            {
                timerSubmit.Stop();              
                MessageBox.Show("Hết giờ", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lbTotalScore.Visible = true;
                lbTotalScore.Text = "Total : " + totalScore() + " / " + list.Count;
                index = 0;
                loadQuestion(index);
                if (lbTotalScore.Visible)
                {
                    lbTimer.Visible = false;
                    btnSubmit.Enabled = false;
                }                   
            }
        }
    }
}