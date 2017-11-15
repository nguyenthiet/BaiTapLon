using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAiLaTrieuPhu
{
    class CauHoi
    {
        private string MaCauHoi, NoiDungCauHoi, DapAnA, DapAnB, DapAnC, DapAnD;

        public string _MaCauHoi { get => MaCauHoi; set => MaCauHoi = value; }
        public string _NoiDungCauHoi { get => NoiDungCauHoi; set => NoiDungCauHoi = value; }
        public string _DapAnB { get => DapAnB; set => DapAnB = value; }
        public string _DapAnC { get => DapAnC; set => DapAnC = value; }
        public string _DapAnD { get => DapAnD; set => DapAnD = value; }

        public string _DapAnA { get => DapAnA; set => DapAnA = value; }

        public CauHoi()
        {
            MaCauHoi = NoiDungCauHoi = DapAnA = DapAnB = DapAnC = DapAnD = "";
        }

        public CauHoi(string maCauHoi, string noiDung, string dapAna, string dapAnb, string dapAnc, string dapAnd)
        {
            MaCauHoi = maCauHoi;
            NoiDungCauHoi = noiDung;
            DapAnA = dapAna;
            DapAnB = dapAnb;
            DapAnC = dapAnc;
            DapAnD = dapAnd;
        }

        public static List<CauHoi> LoadCauHoi(string duongDan)
        {
            StreamReader sr = new StreamReader(duongDan);
            List<CauHoi> lstCauHoi = new List<CauHoi>();
            string line = sr.ReadLine();//Đoc từng dòng của file text
            while (line != null)
            {
                string[] temp = line.Split('/');
                lstCauHoi.Add(new CauHoi(temp[0], temp[1], temp[2], temp[3], temp[4], temp[5]));
                line = sr.ReadLine();
            }
            sr.Close();
            return lstCauHoi;
        }
    }
}
