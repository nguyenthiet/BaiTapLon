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
namespace GameAiLaTrieuPhu
{
    public partial class FormKetThuc : Form
    {
        public string tienthuong;
        SoundPlayer _soundPlay = new SoundPlayer();
        public FormKetThuc()
        {
            InitializeComponent();
        }

        private void FormKetThuc_Load(object sender, EventArgs e)
        {
            txtChucMung.Text = "Số tiền bạn nhận được là: " + tienthuong + Environment.NewLine + "Cảm ơn bạn đã tham gia chương trình.Chúc bạn thành công trong cuộc sống.";
            _soundPlay.Stream = Properties.Resources.vui_vui;
            _soundPlay.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormOK frm = new FormOK();
            this.Hide();
            _soundPlay.Stop();
            frm.Closed += (s, args) => this.Close();
            frm.ShowDialog();
        }

        private void txtChucMung_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
