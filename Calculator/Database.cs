using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public class Database
    {
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Button button = new Button();
                    button.Name = "" + i + j;
                    button.Size = new Size(20, 20);
                    button.Location = new Point(20 + i * 25, 20 + j * 25);
                    button.Click += new EventHandler(Button_Click);
                    this.Controls.Add(button);
                }
            }
        }

        bool laNguoiChoi1 = true;

        private void Button_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if (laNguoiChoi1)
                bt.Text = "X";
            else
                bt.Text = "O";
            laNguoiChoi1 = !laNguoiChoi1;
        }

        public void hienthiNhanVien()
        {
            DGVNhanVien.DataSource = Controlers.NhanVienCtrt.LoadNhanViens().Tables[0];
            bingding();
        }

        void bingding()
        {
            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", DGVNhanVien.DataSource, "IdNhanVien");
            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("Text", DGVNhanVien.DataSource, "HoTenNhanVien");
            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Text", DGVNhanVien.DataSource, "NgaySinh");
            cbGioiTinh.DataBindings.Clear();
            cbGioiTinh.DataBindings.Add("Text", DGVNhanVien.DataSource, "GioiTinh");
            txtdiachi.DataBindings.Clear();
            txtdiachi.DataBindings.Add("Text", DGVNhanVien.DataSource, "DiaChi");
            txtphone.DataBindings.Clear();
            txtphone.DataBindings.Add("Text", DGVNhanVien.DataSource, "SoDienThoai");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", DGVNhanVien.DataSource, "Email");
        }

        private void chứcNăngAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uc_Phong phog = new uc_Phong();
            TabPage tp = new TabPage();
            tp.Text = "Phòng";
            tp.Controls.Add(phog);
            tabControl1.TabPages.Add(tp);
            tabControl1.SelectedTab = tp;
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {
            TabPage t = tabControl1.SelectedTab;
            if (t.Text != "Giới thiệu")
                tabControl1.Controls.Remove(t);
        }

        private void linkChooseImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "*.jpg; *.png; *.jpeg; *.gif|*.jpg; *.png; *.jpeg; *.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ptHinhAnhKH.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void gridViewNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                KhachHangModels myKH = new KhachHangModels();
                string maKhachHang = gridViewNhanVien.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                foreach (KhachHangModels khachHang in listHang)
                {
                    if (khachHang.MaKH == maKhachHang)
                    {
                        myKH = khachHang;
                        break;
                    }
                }
            }
        }


        private void btnMenuQLKHMain_Click(object sender, EventArgs e)
        {
            fr_QLKhachHang nf = new fr_QLKhachHang();
            nf.TopLevel = false;
            nf.AutoScroll = true;
            this.panelThayDoiChucNang.Controls.Add(nf);
            nf.Show();
        }

        panelPhongDon.Controls.Clear();
        panelPhongDon.Controls.Add(new uc_Phong());
        panelPhongDoi.Controls.Clear();
        panelPhongDoi.Controls.Add(new uc_Phong());









    }
}
