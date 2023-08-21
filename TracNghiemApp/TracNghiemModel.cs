using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TracNghiemApp
{
    public class TracNghiemModel
    {
        public string noiDung { get; set; }
        public string phuongAnA { get; set; }
        public string phuongAnB { get; set; }
        public string phuongAnC { get; set; }
        public string phuongAnD { get; set; }
        public int dapAn = -1;
        public int traLoi = -1;
        public TracNghiemModel(string noiDung, string phuongAnA,
            string phuongAnB, string phuongAnC, string phuongAnD)
        {
            this.noiDung = noiDung;
            this.phuongAnA = phuongAnA;
            this.phuongAnB = phuongAnB;
            this.phuongAnC = phuongAnC;
            this.phuongAnD = phuongAnD;
        }
    }
}
