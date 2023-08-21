using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameBauCua
{
    public partial class Form1 : Form
    {
        int[] result = new int[3];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbAccountName.Text = "Hoàng Trọng Tâm";
        }

        private void numberBau_ValueChanged(object sender, EventArgs e)
        {
            int nai = (int)numberNai.Value;
            int bau = (int)numberBau.Value;
            int ga = (int)numberGa.Value;
            int ca = (int)numberCa.Value;
            int cua = (int)numberCua.Value;
            int tom = (int)numberTom.Value;
            int total = nai + bau + ga + cua + tom + ca + cua;
            if (total > int.Parse(lbMoney.Text))
            {
                MessageBox.Show("Bạn không đủ tiền để đặt cược!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numberNai.Value = 0;
                numberBau.Value = 0;
                numberGa.Value = 0;
                numberCa.Value = 0;
                numberCua.Value = 0;
                numberTom.Value = 0;
            }
        }

        private void btnQuay_Click(object sender, EventArgs e)
        {
            result = getRandom();
            if (totalPoint() == 0)
            {
                MessageBox.Show("Bạn chưa đặt cược!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {                
                changedPT(result[0], ptMot);
                changedPT(result[1], ptHai);
                changedPT(result[2], ptBa);
                if (tinhTienThua() + tinhTienThuong() > 0)
                {
                    lbMoneyCount.ForeColor = Color.Blue;
                }else if (tinhTienThua() + tinhTienThuong() == 0)
                {
                    lbMoneyCount.ForeColor = Color.Yellow;
                }
                else
                {
                    lbMoneyCount.ForeColor = Color.Red;
                }
                lbMoneyCount.Text = (tinhTienThua() + tinhTienThuong()).ToString();
                lbMoney.Text = (int.Parse(lbMoney.Text) + tinhTienThua() + tinhTienThuong()).ToString();
            } 
        }

        private void changedPT(int ptNumberChange, PictureBox pt)
        {
            switch (ptNumberChange)
            {
                case 1:
                    {
                        pt.Image = Image.FromFile("../images/nai.png");
                        break;
                    }
                case 2:
                    {
                        pt.Image = Image.FromFile("../images/bau.png");
                        break;
                    }
                case 3:
                    {
                        pt.Image = Image.FromFile("../images/ga.png");
                        break;
                    }
                case 4:
                    {
                        pt.Image = Image.FromFile("../images/ca.png");
                        break;
                    }
                case 5:
                    {
                        pt.Image = Image.FromFile("../images/cua.png");
                        break;
                    }
                case 6:
                    {
                        pt.Image = Image.FromFile("../images/tom.png");
                        break;
                    }
                default: break;
            }
        }

        private int[] getRandom()
        {
            int dem = 0;
            for (int i = 0; i < 3; i++)
            {
                Random random = new Random();
                result[i] = random.Next(1, 7);
                //if ((int)numberNai.Value > 0)
                //{
                //    if (result[i] == 1)
                //    {
                //        i--;
                //    }
                //}
                if (i != 0)
                {
                    MessageBox.Show("" + "Anh day\n");
                    if (result[i] == result[i - 1])
                    {
                        ++dem;
                        if (dem == 2)
                        {
                            --i;
                            dem = 0;
                        }
                    }
                    
                        
                }
            }
            //MessageBox.Show("" + result[0] + result[1] + result[2] + dem);
            return result;
        }

        private int totalPoint()
        {
            int nai = (int)numberNai.Value;
            int bau = (int)numberBau.Value;
            int ga = (int)numberGa.Value;
            int ca = (int)numberCa.Value;
            int cua = (int)numberCua.Value;
            int tom = (int)numberTom.Value;
            int total = nai + bau + ga + cua + tom + ca + cua;
            return total;
        }

        private int tinhTienThuong()
        {
            int tienThuong = 0;
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] == 1)
                {
                    tienThuong += (int)numberNai.Value;
                }else if (result[i] == 2)
                {
                    tienThuong += (int)numberBau.Value;
                }
                else if (result[i] == 3)
                {
                    tienThuong += (int)numberGa.Value;
                }
                else if (result[i] == 4)
                {
                    tienThuong += (int)numberCa.Value;
                }
                else if (result[i] == 5)
                {
                    tienThuong += (int)numberCua.Value;
                }
                else if (result[i] == 6)
                {
                    tienThuong += (int)numberTom.Value;
                }
            }
            return tienThuong;
        }

        private int tinhTienThua()
        {
            int tienThua = 0;
            if (!checkTonTai(1, result))
                tienThua -= (int)numberNai.Value;
            if (!checkTonTai(2, result))
                tienThua -= (int)numberBau.Value;
            if (!checkTonTai(3, result))
                tienThua -= (int)numberGa.Value;
            if (!checkTonTai(4, result))
                tienThua -= (int)numberCa.Value;
            if (!checkTonTai(5, result))
                tienThua -= (int)numberCua.Value;
            if (!checkTonTai(6, result))
                tienThua -= (int)numberTom.Value;
            return tienThua;
        }

        private bool checkTonTai(int value, int[] result)
        {
            for (int i = 0; i < result.Length; i++)
            {
                if (value == result[i])
                    return true;
            }
            return false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (int.Parse(lbMoney.Text) > 30)
            {
                if (MessageBox.Show("Bạn có muốn reset lại tiền không ?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    lbMoney.Text = "30";
                }
            }
            else
            {
                lbMoney.Text = "30";
            }
            lbMoneyCount.Text = "0";
            lbMoneyCount.ForeColor = Color.Black;
            ptMot.Image = Image.FromFile("../images/images.jpeg");
            ptHai.Image = Image.FromFile("../images/images.jpeg");
            ptBa.Image = Image.FromFile("../images/images.jpeg");
            numberNai.Value = 0;
            numberBau.Value = 0;
            numberGa.Value = 0;
            numberCa.Value = 0;
            numberCua.Value = 0;
            numberTom.Value = 0;
            //btnQuay.Enabled = true;

        }
    }
}
