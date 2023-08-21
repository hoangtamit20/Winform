using System;
using System.IO;
using System.Windows.Forms;

namespace DoiTuongCoBan
{
    public partial class WordPad : Form
    {
        public static string fileName = "";
        public WordPad()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(*.txt)|*.txt|(*.*)|*.*";
            if (fileName == "")
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fileName = Path.GetFullPath(ofd.FileName);
                    MessageBox.Show(fileName);
                    string allData = System.IO.File.ReadAllText(ofd.FileName).Trim();
                    richTextBox.Text = allData;
                }
            }
            else
            {
                if (richTextBox.Text.Equals(File.ReadAllText(fileName).Trim()))
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        fileName = Path.GetFullPath(ofd.FileName);
                        //MessageBox.Show(fileName);
                        string allData = File.ReadAllText(ofd.FileName).Trim();
                        richTextBox.Text = allData;
                    }
                }
                else
                {
                    if (MessageBox.Show("Nhan yes de luu file!", "Thong Bao!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        File.WriteAllText(Path.GetFullPath(fileName), richTextBox.Text);
                        if (ofd.ShowDialog() == DialogResult.OK)
                        {
                            fileName = Path.GetFileName(ofd.FileName);
                            //MessageBox.Show(fileName);
                            string allData = File.ReadAllText(ofd.FileName).Trim();
                            richTextBox.Text = allData;
                        }
                    }
                    else
                    {
                        if (ofd.ShowDialog() == DialogResult.OK)
                        {
                            fileName = Path.GetFileName(ofd.FileName);
                            //MessageBox.Show(fileName);
                            string allData = File.ReadAllText(ofd.FileName).Trim();
                            richTextBox.Text = allData;
                        }
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "(*.txt)|*.txt|(*.*)|*.*";
            if (fileName == "")
            {               
                if (save.ShowDialog() == DialogResult.OK)
                {
                    fileName = Path.GetFileName(save.FileName);
                    File.WriteAllText(save.FileName, richTextBox.Text);
                    MessageBox.Show(fileName);
                }
            }
            else
            {
                File.WriteAllText(fileName, richTextBox.Text);
            }
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "(*.txt)|*.txt|(*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                File.WriteAllText(saveFileDialog.FileName, richTextBox.Text);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (fileName == "")
            {
                if (MessageBox.Show("Nhan yes de luu file!", "Thong Bao!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "(*.txt)|*.txt|(*.*)|*.*";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, richTextBox.Text);
                    }
                }
                else
                {
                    this.Close();
                }              
            }
            else
            {
                if (richTextBox.Text.Equals(File.ReadAllText(fileName).Trim()))
                {
                    if (MessageBox.Show("Nhan yes de luu file!", "Thong Bao!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        File.WriteAllText(fileName, richTextBox.Text);
                        this.Close();
                    }
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
