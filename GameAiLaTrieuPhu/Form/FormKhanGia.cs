using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace GameAiLaTrieuPhu
{
    public partial class FormKhanGia : Form
    {
        SoundPlayer _soundPlay = new SoundPlayer();
        public FormKhanGia()
        {
            InitializeComponent();
        }
        public string a, b, c, d;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string dapan;
        private void FormKhanGia_Load(object sender, EventArgs e)
        {
            Random rd = new Random();
            int x1 = rd.Next(40, 60);
            int x2 = rd.Next(10);
            int x3 = rd.Next(10);
            int x4 = 100 - x1 - x2 - x3;
            
            Thread.Sleep(1000);
            _soundPlay.Stream = Properties.Resources.hello;
            _soundPlay.Play();
            if(a==dapan)
            {
                this.BackgroundImage = Properties.Resources.KGA__1_;
                textBox1.Text = "Có 50% khán giả chọn phương án " + a + Environment.NewLine +
                    "Có 20% khán giả chọn phương án " + b + Environment.NewLine +
                    "Có 15% khán giả chọn phương án " + c + Environment.NewLine +
                    "Có 23% khán giả chọn phương án " + d;
            }
            else if(b==dapan)
            {
                this.BackgroundImage = Properties.Resources.KGB;
                textBox1.Text= "Có 11% khán giả chọn phương án " + a + Environment.NewLine +
                    "Có 68% khán giả chọn phương án " + b + Environment.NewLine +
                    "Có 5% khán giả chọn phương án " + c + Environment.NewLine +
                    "Có 16% khán giả chọn phương án " + d;
            }
            else if(c==dapan)
            {
                this.BackgroundImage = Properties.Resources.KGC;
                textBox1.Text = "Có 8% khán giả chọn phương án " + a + Environment.NewLine +
                    "Có 10% khán giả chọn phương án " + b + Environment.NewLine +
                    "Có 62% khán giả chọn phương án " + c + Environment.NewLine +
                    "Có 20% khán giả chọn phương án " + d;
            }
            else
            {
                this.BackgroundImage = Properties.Resources.KGD;
                textBox1.Text = "Có 20% khán giả chọn phương án " + a + Environment.NewLine +
                    "Có 4% khán giả chọn phương án " + b + Environment.NewLine +
                    "Có 34% khán giả chọn phương án " + c + Environment.NewLine +
                    "Có 42% khán giả chọn phương án " + d;
            }
            
        }

        
    }
}
