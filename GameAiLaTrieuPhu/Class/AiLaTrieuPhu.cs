using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameAiLaTrieuPhu
{

    class AiLaTrieuPhu
    {
        
       

        public static void XacNhanChoiLai(string dapanchon,Form  frm,int cauhoi)
        {
            if(dapanchon=="")
            {
                if (MessageBox.Show("Bạn Không Có Câu Trả Lời. Bạn Đã Ra Về Với Số Tiền Thưởng Là " + TienThuong.TinTienThuong(false, cauhoi - 1) + ". Bạn Có Muốn Chơi Lại?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                     frm = new Form1();
                    frm.ShowDialog();

                }
                else
                {
                    frm.Close();
                }
            }
        }
    }
}
