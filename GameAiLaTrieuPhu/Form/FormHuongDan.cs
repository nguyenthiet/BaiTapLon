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
using System.Media;

namespace GameAiLaTrieuPhu
{
    public partial class FormHuongDan : Form
    {
        private SoundPlayer _soundPlay = new SoundPlayer();
        public FormHuongDan()
        {
            InitializeComponent();
            _soundPlay.Stream = Properties.Resources.Luat_Choi;
            
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void btnHuongDan_Click(object sender, EventArgs e)
        {
            FormOK frm = new FormOK();
            this.Hide();
            _soundPlay.Stop();
            frm.Closed += (s, args) => this.Close();
            frm.ShowDialog();
        }

        private void FormHuongDan_Load(object sender, EventArgs e)
        {
            _soundPlay.Play();
        }
    }
}
