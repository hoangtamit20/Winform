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
    public partial class NumberOfQuestion : Form
    {
        ArrayList myList;
        public NumberOfQuestion()
        {
            InitializeComponent();
        }

        private void NumberOfQuestion_Load(object sender, EventArgs e)
        {           
            int cot = 0;
            int dong = 0;
            DocCauHoi d = new DocCauHoi();
            myList = d.docFile();
            for (int i = 0; i < myList.Count; i++)
            {               
                Button button = new Button();
                button.Name = "" + (i + 1);
                button.Text = "" + (i + 1);
                button.Size = new Size(50, 50);
                button.Location = new Point(13+cot*50, 13+dong*50);
                cot++;
                if (cot == 3)
                {
                    cot = 0;
                    dong++;
                }
                button.Click += new EventHandler(Button_Click);
                this.Controls.Add(button);
                
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            FormTracNghiem form = new FormTracNghiem();
            //form.loadCau();
            Button bt = (Button)sender;
            int viTri = int.Parse(bt.Text);

        }
    }
}
