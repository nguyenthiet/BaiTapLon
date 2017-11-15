using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameAiLaTrieuPhu
{
    public partial class FormNhapBoCauHoi : Form
    {
        public FormNhapBoCauHoi()
        {
            InitializeComponent();
        }
        string DuongDanCauHoi = "";
        string DuongDanDapAn = "";
        private void btnChonCauHoi_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Multiselect = true;
            opf.Title = "Chọn File";
            opf.Filter = "select file|*.txt";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                // chế độ chọn nhiều
                foreach (String file in opf.FileNames)
                {
                    StreamReader Re = new StreamReader(file);
                    Form1.duogDanCauHoi = opf.SafeFileName;
                    DuongDanCauHoi = Form1.duogDanCauHoi;
                    Re.Close();
                }
            }

        }

        private void btnChonDapAn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Multiselect = true;
            opf.Title = "Chọn File";
            opf.Filter = "select file|*.txt";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                // chế độ chọn nhiều
                foreach (String file in opf.FileNames)
                {
                    StreamReader Re = new StreamReader(file);
                    Form1.duongDanDapAn = opf.SafeFileName;
                    DuongDanDapAn = Form1.duongDanDapAn;
                    Re.Close();
                }
            }
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            if(DuongDanDapAn==""||DuongDanCauHoi=="")
            {
                MessageBox.Show("Kiểm tra lại lựa chọn đường dẫn.");
            }
            else
            {
                FormOK frm = new FormOK();
                this.Hide();
                frm.Closed += (s, args) => this.Close();
                frm.ShowDialog();
            }
        }
    }
}
