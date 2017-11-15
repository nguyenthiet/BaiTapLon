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

namespace GameAiLaTrieuPhu
{
    public partial class FormGoiDien : Form
    {
        
        public FormGoiDien()
        {
            InitializeComponent();
       
        }
        public string traloi, cauhoi,a,b,c,d;
        int thoigian;
        private void btnDapMay_Click(object sender, EventArgs e)
        {
            this.Close();           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {           
            thoigian--;
            lblTime.Text = thoigian.ToString();
            if(thoigian==0)
            {
                this.Close();
            }
        }

        private void Init() {
            
            lblB1.Text += "Anh ơi giúp em trả lời câu hỏi này với." + Environment.NewLine + cauhoi+Environment.NewLine +" A." +a+" B."+b+" C."+c+" D."+d;
            lblO1.Text += "Não cá vàng này.Đáp án là "+traloi+" nhé";
            lblB2.Text += "Anh chắc chắn chứ???";
            lblO2.Text += "Hỏi lắm.Thua về đây tao cho m thêm tiền....";
            lblB1.Visible = false;
            lblO1.Visible = false;
            lblB2.Visible = false;
            lblO2.Visible = false;
        }

        private void FormGoiDien_Load(object sender, EventArgs e)
        {
            thoigian = 15;
            Init();
            timer1.Start();
            Task.Factory.StartNew
            (
             () =>
             {
                 Thread.Sleep(1000);
                 Invoke(new Action(Hoi1));
                 Thread.Sleep(3000);
                 Invoke(new Action(Dap1));
                 Thread.Sleep(2000);
                 Invoke(new Action(Hoi2));
                 Thread.Sleep(4000);
                 Invoke(new Action(Dap2));

             }
            );
        }

        private void Hoi1()
        {
            lblB1.Visible = true;
        }
        private void Dap1()
        {
            lblO1.Visible = true;
        }

        private void Hoi2()
        {
            lblB2.Visible = true; 
        }

        private void Dap2()
        {
           lblO2.Visible = true;
        }
        

    }
}
