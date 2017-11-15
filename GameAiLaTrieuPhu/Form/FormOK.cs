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
    public partial class FormOK : Form
    {
        SoundPlayer _soundPlay = new SoundPlayer();
        public FormOK()
        {
            InitializeComponent();
            _soundPlay.Stream = Properties.Resources.Mo_Dau;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void FormOK_Load(object sender, EventArgs e)
        {
            _soundPlay.Play();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            _soundPlay.Stop();
            frm.Closed += (s, args) => this.Close();
            frm.ShowDialog();

        } 

        private void btnHuongDan_Click(object sender, EventArgs e)
        {
            FormHuongDan frm = new FormHuongDan();
            this.Hide();
            _soundPlay.Stop();
            frm.Closed += (s, args) => this.Close();
            frm.ShowDialog();
        }
    }
}
