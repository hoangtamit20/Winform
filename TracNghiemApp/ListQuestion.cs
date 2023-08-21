using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Bunifu.UI.WinForms;

namespace TracNghiemApp
{
    public class ListQuestion
    {
        private List<TracNghiemModel> list;

        public ListQuestion()
        {
        }

        public ListQuestion(List<TracNghiemModel> list)
        {
            this.list = list;
        }

        public List<TracNghiemModel> getListQuestion(string ulrFile, Label lable)
        {
            list = new List<TracNghiemModel>();
            try
            {
                string text = File.ReadAllText(ulrFile);
                string[] lines = text.Split('\n');
                int i = 0;
                while (true)
                {
                    list.Add(new TracNghiemModel(lines[5 * i], 
                        lines[5 * i + 1], lines[5 * i + 2], lines[5 * i + 3], lines[5 * i + 4]));
                    i++;
                    if (5 * i >= lines.Length)
                        break;
                }
            }
            catch
            {
                //lable.Visible = true;
                //lable.Text = "Load File Thất Bại!";
            }
            return list;
        }
    }
}
