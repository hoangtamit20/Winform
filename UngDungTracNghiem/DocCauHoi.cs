using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngDungTracNghiem
{
    class DocCauHoi
    {
        public ArrayList docFile()
        {
            ArrayList myArray = new ArrayList();
            string allData = System.IO.File.ReadAllText(@"D:\Sophomore\CS464\Buoi1\UngDungTracNghiem\TextFile1.txt").Trim();
            
            string [] arrSplit = allData.Split('\n');
            int i = 0;
            while (true)
            {
                TracNghiem tracNghiem = new TracNghiem(
                    arrSplit[5*i],
                    arrSplit[5*i + 1],
                    arrSplit[5*i+2],
                    arrSplit[5*i+3],
                    arrSplit[5*i+4]);
                i++;
                
                myArray.Add(tracNghiem);
                if (i * 5 >= arrSplit.Length)
                    break;
            }

            return myArray;
        }
    }
}
