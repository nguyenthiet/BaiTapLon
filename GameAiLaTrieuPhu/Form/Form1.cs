using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace GameAiLaTrieuPhu
{
    public partial class Form1 : Form
    {
        private SoundPlayer _soundPlay = new SoundPlayer();
        public Form1()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
        }

        List<CauHoi> lstCauHoi = new List<CauHoi>();
        List<DapAn> lstDapAn = new List<DapAn>();
        List<CauHoi> lstCauHoiChinh = new List<CauHoi>();
        List<DapAn> lstDapAnChinh = new List<DapAn>();

        public static string duogDanCauHoi;
        public static string duongDanDapAn;

        string selectDapAn;
        Random rd = new Random();
        int ThoiGian;
        int idx = 1;


        private void Form1_Load(object sender, EventArgs e)
        {

            lstCauHoi = CauHoi.LoadCauHoi(duogDanCauHoi);
            lstDapAn = DapAn.LoadDapAn(duongDanDapAn);
            lsbBonus.DataSource = TienThuong.LoadBonusToForm().DataSource;


            for (int i = 0; i < 15; i++)
            {
                int rdCauHoi = rd.Next(0, lstCauHoi.Count);
                lstCauHoiChinh.Add(lstCauHoi[rdCauHoi]);
                lstDapAnChinh.Add(lstDapAn[rdCauHoi]);

                lstCauHoi.Remove(lstCauHoi[rdCauHoi]);
                lstDapAn.Remove(lstDapAn[rdCauHoi]);
            }
            LoadLenForm();
        }

        private void LoadLenForm()
        {
            _soundPlay.Stream = Properties.Resources.nen;
            _soundPlay.Play();
            btnA.BackColor = Color.Gainsboro;
            btnB.BackColor = Color.Gainsboro;
            btnC.BackColor = Color.Gainsboro;
            btnD.BackColor = Color.Gainsboro; 

            btnA.Visible = btnB.Visible = btnC.Visible = btnD.Visible = true;
            btn5050.Visible = true;
            btnGoiDien.Visible = true;
            btnTuVanTC.Visible = true;

            selectDapAn = "";
            ThoiGian = 25;
            lblTime.Text = ThoiGian.ToString();
            timer1.Start();

            lsbBonus.SelectedIndex = lsbBonus.Items.Count - idx;

            txtCauHoi.Text = lstCauHoiChinh[idx - 1]._NoiDungCauHoi;
            btnA.Text = lstCauHoiChinh[idx - 1]._DapAnA;
            btnB.Text = lstCauHoiChinh[idx - 1]._DapAnB;
            btnC.Text = lstCauHoiChinh[idx - 1]._DapAnC;
            btnD.Text = lstCauHoiChinh[idx - 1]._DapAnD;
            lblCauHoi.Text = "Câu số " + idx + "";
        }

        //Em viết hết các hàm ra ngoài form rồi :(
        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.BackColor = Color.Red;
            DialogResult result = MessageBox.Show("Ban có chắc đây là câu hỏi cuối cùng không?", "Đáp án",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                selectDapAn = btnA.Text;
                KiemTraDapAnChon();
            }
            else
            {
                btnA.BackColor = Color.Gainsboro;
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnB.BackColor = Color.Red;
            DialogResult result = MessageBox.Show("Ban có chắc đây là câu hỏi cuối cùng không?", "Đáp án",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                selectDapAn = btnB.Text;
                KiemTraDapAnChon();
            }
            else
            {
                btnB.BackColor = Color.Gainsboro;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnC.BackColor = Color.Red;
            DialogResult result = MessageBox.Show("Ban có chắc đây là câu hỏi cuối cùng không?", "Đáp án",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                selectDapAn = btnC.Text;
                KiemTraDapAnChon();
            }
            else
            {
                btnC.BackColor = Color.Gainsboro;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnD.BackColor = Color.Red;
            DialogResult result = MessageBox.Show("Ban có chắc đây là câu hỏi cuối cùng không?", "Đáp án",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                selectDapAn = btnD.Text;
                KiemTraDapAnChon();
            }
            else
            {
                btnD.BackColor = Color.Gainsboro;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ThoiGian--;
            lblTime.Text = ThoiGian.ToString();
            if (ThoiGian == 0)
            {
                timer1.Stop();
                if(selectDapAn=="")
                {
                    tienThuong = TienThuong.TinTienThuong(false, idx - 1);
                    MessageBox.Show("Đã hết thời gian mà bạn không có câu trả lời.");
                    FormKetThuc frm = new FormKetThuc();
                    frm.tienthuong = tienThuong;
                    this.Hide();
                    frm.Closed += (s, args) => this.Close();
                    frm.ShowDialog();
                }
            }
        }



        public string tienThuong;
        private void KiemTraDapAnChon()
        {
            timer1.Stop();
            if (lstDapAnChinh[idx - 1]._DapAnDung == selectDapAn)
            {
                tienThuong ="$"+ TienThuong.TinTienThuong(true, idx - 1);
                _soundPlay.Stream = Properties.Resources.Tra_Loi_Dung_Loai_Cau_De;
                _soundPlay.Play();
                if (idx == 5)
                {

                    _soundPlay.Stream = Properties.Resources.Qua_Cau_5;
                    _soundPlay.Play();
                    Thread.Sleep(30000);
                }
                if (idx == 10)
                {
                    _soundPlay.Stream = Properties.Resources.Qua_Cau_10_P1;
                    _soundPlay.Play();
                    Thread.Sleep(15000);
                    _soundPlay.Stream = Properties.Resources.Qua_Cau_10_P2;
                    _soundPlay.Play();
                    Thread.Sleep(22000);

                }
                if (idx == 15)
                {

                    if (MessageBox.Show("Xin chúc mừng bạn. Bạn Đã là tỉ phú.Ra Về Với Số Tiền Thưởng Là " + tienThuong + ". Bạn Có Muốn Chơi Lại?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FormKetThuc frm = new FormKetThuc();
                        frm.tienthuong = tienThuong;
                        this.Hide();
                        frm.Closed += (s, args) => this.Close();
                        frm.ShowDialog();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    DialogResult hoixacnhan = MessageBox.Show("Xin Chúc Mừng Bạn Đã Chọn Đúng. Số Tiền Nhận Được Của Bạn Là " + tienThuong + ". Bạn Muốn Chơi Tiếp Hay Dừng Lại?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (hoixacnhan == DialogResult.Yes)
                    {
                        idx++;

                        LoadLenForm();

                    }
                    else
                    {
                        FormKetThuc frm = new FormKetThuc();
                        frm.tienthuong = tienThuong;
                        this.Hide();
                        frm.Closed += (s, args) => this.Close();
                        frm.ShowDialog();
                    }
                }
            }
            else
            {
                tienThuong = "$"+TienThuong.TinTienThuong(false, idx - 1);
                MessageBox.Show("Bạn đã trả lời sai.Dáp án đúng phải là" + lstDapAnChinh[idx - 1]._DapAnDung);
                    FormKetThuc frm = new FormKetThuc();
                    frm.tienthuong = tienThuong;
                    this.Hide();
                    frm.Closed += (s, args) => this.Close();
                    frm.ShowDialog();
               
            }
        }

        private void AnDapAn(Button a, Button b, Button c, Button d, string dapan)
        {
            List<Button> lstBtn = new List<Button>();
            lstBtn.Add(a);
            lstBtn.Add(b);
            lstBtn.Add(c);
            lstBtn.Add(d);


            for (int i = 0; i < 4; i++)
            {
                if (lstBtn[i].Text == dapan)
                {
                    lstBtn.Remove(lstBtn[i]);
                    break;
                }
            }

            List<Button> lstBtn1 = new List<Button>();
            Random rd = new Random();
            while (lstBtn.Count != 1)
            {
                Button t = lstBtn[rd.Next(lstBtn.Count)];
                lstBtn1.Add(t);
                lstBtn.Remove(t);
            }

            lstBtn1[0].Visible = false;
            lstBtn1[1].Visible = false;
        }

        private void btn5050_Click(object sender, EventArgs e)
        {
            _soundPlay.Stream = Properties.Resources.Tro_Giup_50_50;
            _soundPlay.Play();
            MessageBox.Show("Tôi xin nhờ máy tính bỏ đi 2 phương án sai.");
            _soundPlay.Stop();
            AnDapAn(btnA, btnB, btnC, btnD, lstDapAnChinh[idx - 1]._DapAnDung);
            btn5050.Enabled = false;
            btn5050.BackgroundImage = Properties.Resources.DaSuDung_50_50;
            timer1.Start();
        }

        private string TimDapAnDung(Button a, Button b, Button c, Button d, string dapan)
        {
            if (a.Text == dapan)
            {
                return a.Text;
            }
            else if (b.Text == dapan)
            {
                return b.Text;
            }
            else if (c.Text == dapan)
            {
                return c.Text;
            }
            return d.Text;
        }
        private void btnGoiDien_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            //string s = "Cái này dễ í mà.Chọn đáp án " + TimDapAnDung(btnA, btnB, btnC, btnD, lstDapAnChinh[idx - 1]._DapAnDung).ToLower() + " nhé.";
            _soundPlay.Stream = Properties.Resources.Goi_Dien_Cho_Nguoi_Than;
            _soundPlay.Play();
            Thread.Sleep(5500);
            FormGoiDien frm = new FormGoiDien();
            frm.cauhoi = lstCauHoiChinh[idx - 1]._NoiDungCauHoi;
            frm.traloi = lstDapAnChinh[idx - 1]._DapAnDung;
            frm.a = lstCauHoiChinh[idx - 1]._DapAnA;
            frm.b = lstCauHoiChinh[idx - 1]._DapAnB;
            frm.c = lstCauHoiChinh[idx - 1]._DapAnC;
            frm.d = lstCauHoiChinh[idx - 1]._DapAnD;
            frm.ShowDialog();
            timer1.Start();
            btnGoiDien.BackgroundImage = Properties.Resources.DaSuDung_Goi_Nguoi_Than;
            btnGoiDien.Enabled = false;
            timer1.Start();
        }


        private void btnTuVanTC_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            _soundPlay.Stream = Properties.Resources.Hoi_Y_Kien_Khan_Gia_1;
            _soundPlay.Play();
            MessageBox.Show("Tôi xin mời tổ tư vấn trong trường quay trợ giúp cho bạn trả lời câu hỏi " + lstCauHoiChinh[idx - 1]._NoiDungCauHoi);
            FormKhanGia frm = new FormKhanGia();
            frm.a = lstCauHoiChinh[idx - 1]._DapAnA;
            frm.b = lstCauHoiChinh[idx - 1]._DapAnB;
            frm.c = lstCauHoiChinh[idx - 1]._DapAnC;
            frm.d = lstCauHoiChinh[idx - 1]._DapAnD;
            frm.dapan = lstDapAnChinh[idx - 1]._DapAnDung;
            frm.ShowDialog();

            btnTuVanTC.Enabled = false;
            btnTuVanTC.BackgroundImage = Properties.Resources.DaSuDung_Y_Kien_K_Gia;
            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _soundPlay.Stream = Properties.Resources.vui_vui;
            _soundPlay.Play();
            timer1.Stop();
            if (MessageBox.Show("Bạn có chắc là muốn dừng cuộc chơi tại đây chứ.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FormKetThuc frm = new FormKetThuc();
                frm.tienthuong = tienThuong;              
                this.Hide();
                frm.Closed += (s, args) => this.Close();
                frm.ShowDialog();
            }
            else
            {
                _soundPlay.Stop();
            }
            timer1.Start();
        }

        private void lsbBonus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
