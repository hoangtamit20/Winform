using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngDungTracNghiem
{
    class TracNghiem
    {
        public string noiDung;
        public string phuongAnA;
        public string phuongAnB;
        public string phuongAnC;
        public string phuongAnD;
        public int dapAn = -1;
        public int traLoi = -1;

        public TracNghiem(string noiDung, string phuongAnA, string phuongAnB, string phuongAnC, string phuongAnD)
        {
            this.noiDung = noiDung;
            this.phuongAnA = phuongAnA;
            if (phuongAnA.StartsWith("*"))
            {
                this.dapAn = 1;
                this.phuongAnA = phuongAnA.Substring(1);
            }
            this.phuongAnB = phuongAnB;
            if (phuongAnB.StartsWith("*"))
            {
                this.dapAn = 1;
                this.phuongAnB = phuongAnB.Substring(1);
            }
            this.phuongAnC = phuongAnC;
            if (phuongAnC.StartsWith("*"))
            {
                this.dapAn = 1;
                this.phuongAnC = phuongAnC.Substring(1);
            }
            this.phuongAnD = phuongAnD;
            if (phuongAnD.StartsWith("*"))
            {
                this.dapAn = 1;
                this.phuongAnD = phuongAnD.Substring(1);
            }
        }
    }
}
