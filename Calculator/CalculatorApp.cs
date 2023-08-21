using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorApp : Form
    {
        public CalculatorApp()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            if (kiemTraDieuKien())
            {
                double soA = Double.Parse(txtSoA.Text.ToString());
                double soB = Double.Parse(txtSoB.Text.ToString());
                txtKetQua.Text = (soA + soB).ToString();
            }
            else
            {
                MessageBox.Show("Dữ liệu không hợp lệ!", "Lỗi");
            }
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (kiemTraDieuKien())
            {
                double soA = Double.Parse(txtSoA.Text.ToString());
                double soB = Double.Parse(txtSoB.Text.ToString());
                txtKetQua.Text = (soA - soB).ToString();
            }
            else
            {
                MessageBox.Show("Dữ liệu không hợp lệ!", "Lỗi");
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (kiemTraDieuKien())
            {
                double soA = Double.Parse(txtSoA.Text.ToString());
                double soB = Double.Parse(txtSoB.Text.ToString());
                txtKetQua.Text = (soA * soB).ToString();
            }
            else
            {
                MessageBox.Show("Dữ liệu không hợp lệ!", "Lỗi");
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (kiemTraDieuKien())
            {
                double soA = Double.Parse(txtSoA.Text.ToString());
                double soB = Double.Parse(txtSoB.Text.ToString());
                if (soB == 0)
                {
                    MessageBox.Show("Số B phải khác 0!", "Lỗi");
                }
                else
                {
                    txtKetQua.Text = (soA/soB).ToString();
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu không hợp lệ!", "Lỗi");
            }
        }

        private bool kiemTraDieuKien()
        {
            if (txtSoA.Text.ToString().Equals("") || txtSoB.Text.ToString().Equals(""))
                return false;
            else if (!checkNumber(txtSoA.Text.ToString()) || !checkNumber(txtSoB.Text.ToString()))
                return false;
            return true;
        }

        private bool checkNumber(string s)
        {
            foreach (char c in s)
            {
                if (!char.IsDigit(c) && c != '.')
                {
                    return false;
                }
            }
            return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSoA.Text = "";
            txtSoB.Text = "";
            txtKetQua.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
