using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAiLaTrieuPhu
{
    class DapAn
    {
        private string MaCauHoi, DapAnDung;

        public string _MaCauHoi { get => MaCauHoi; set => MaCauHoi = value; }
        public string _DapAnDung { get => DapAnDung; set => DapAnDung = value; }

        public DapAn()
        {
            MaCauHoi = DapAnDung = "";
        }

        public DapAn(string maCauHoi, string dapAnDung)
        {
            MaCauHoi = maCauHoi;
            DapAnDung = dapAnDung;
        }

        public static List<DapAn> LoadDapAn(string duongDan)
        {
            StreamReader sr = new StreamReader(duongDan);
            List<DapAn> lstDapAn = new List<DapAn>();
            string line = sr.ReadLine();//Đoc từng dòng của file text
            while (line != null)
            {
                string[] temp = line.Split('/');
                lstDapAn.Add(new DapAn(temp[0], temp[1]));
                line = sr.ReadLine();
            }
            sr.Close();
            return lstDapAn;
        }
    }
}
