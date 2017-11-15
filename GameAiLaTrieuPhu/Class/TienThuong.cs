using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameAiLaTrieuPhu
{
    //cho class này vào nhé e oki,k sao đâu mình k sửa code nhưng khi vẽ thì mình vẫn có class AiLatp kia.
    class TienThuong
    {
       static List<string> listBonus = new List<string>() {"200","400","600","1000","2000","3000","9000","12000","28000","22000",
        "64000","125000","250000","500000","1000000"};

        public static List<string> _listBonus { get => listBonus; set => listBonus = value; }

        public static ListBox LoadBonusToForm()
        {
            ListBox lsbBonus = new ListBox();
            List<string> Bonus = new List<string>();

            for (int i = 0; i < 15; i++)
            {
                if (15 - i >= 10)
                {
                    Bonus.Add((15 - i) + ". $" + listBonus[14  - i] );
                }
                else
                {
                    Bonus.Add((15 - i) + ".  $" + listBonus[14 - i] );
                }
            }
            lsbBonus.DataSource = Bonus;
            return lsbBonus;

        }

        public static string TinTienThuong(bool kiemtra, int cauhoi)
        {
            if (kiemtra == false)
            {
                if (cauhoi < 5)
                {
                    return "0";
                }
                else if (cauhoi < 10)
                {
                    return listBonus[4];
                }
                else if (cauhoi < 10)
                {
                    return listBonus[9];
                }
                else
                {
                    return listBonus[cauhoi];
                }
            }
            return listBonus[cauhoi];

        }

        
    }
}
