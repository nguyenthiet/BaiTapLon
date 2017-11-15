namespace GameAiLaTrieuPhu
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lsbBonus = new System.Windows.Forms.ListBox();
            this.lblCauHoi = new System.Windows.Forms.Label();
            this.txtCauHoi = new System.Windows.Forms.TextBox();
            this.btnD = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn5050 = new System.Windows.Forms.Button();
            this.btnGoiDien = new System.Windows.Forms.Button();
            this.btnTuVanTC = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbBonus
            // 
            this.lsbBonus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbBonus.ForeColor = System.Drawing.Color.Red;
            this.lsbBonus.FormattingEnabled = true;
            this.lsbBonus.ItemHeight = 19;
            this.lsbBonus.Location = new System.Drawing.Point(558, 103);
            this.lsbBonus.Name = "lsbBonus";
            this.lsbBonus.Size = new System.Drawing.Size(162, 308);
            this.lsbBonus.TabIndex = 0;
            this.lsbBonus.SelectedIndexChanged += new System.EventHandler(this.lsbBonus_SelectedIndexChanged);
            // 
            // lblCauHoi
            // 
            this.lblCauHoi.AutoSize = true;
            this.lblCauHoi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCauHoi.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCauHoi.Location = new System.Drawing.Point(30, 245);
            this.lblCauHoi.Name = "lblCauHoi";
            this.lblCauHoi.Size = new System.Drawing.Size(40, 15);
            this.lblCauHoi.TabIndex = 1;
            this.lblCauHoi.Text = "label1";
            // 
            // txtCauHoi
            // 
            this.txtCauHoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtCauHoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCauHoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCauHoi.ForeColor = System.Drawing.Color.Black;
            this.txtCauHoi.Location = new System.Drawing.Point(33, 271);
            this.txtCauHoi.Multiline = true;
            this.txtCauHoi.Name = "txtCauHoi";
            this.txtCauHoi.Size = new System.Drawing.Size(495, 46);
            this.txtCauHoi.TabIndex = 2;
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(309, 375);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(164, 36);
            this.btnD.TabIndex = 3;
            this.btnD.Text = "button3";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnC
            // 
            this.btnC.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnC.BackColor = System.Drawing.Color.Gainsboro;
            this.btnC.Location = new System.Drawing.Point(309, 336);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(164, 33);
            this.btnC.TabIndex = 2;
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(70, 375);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(164, 36);
            this.btnB.TabIndex = 1;
            this.btnB.Text = "button2";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(70, 336);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(164, 33);
            this.btnA.TabIndex = 0;
            this.btnA.Text = "button1";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.ForestGreen;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblTime.Location = new System.Drawing.Point(118, 25);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(26, 18);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn5050
            // 
            this.btn5050.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn5050.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn5050.BackgroundImage")));
            this.btn5050.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn5050.Location = new System.Drawing.Point(537, 25);
            this.btn5050.Name = "btn5050";
            this.btn5050.Size = new System.Drawing.Size(60, 51);
            this.btn5050.TabIndex = 5;
            this.btn5050.UseVisualStyleBackColor = false;
            this.btn5050.Click += new System.EventHandler(this.btn5050_Click);
            // 
            // btnGoiDien
            // 
            this.btnGoiDien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnGoiDien.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGoiDien.BackgroundImage")));
            this.btnGoiDien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGoiDien.Location = new System.Drawing.Point(603, 25);
            this.btnGoiDien.Name = "btnGoiDien";
            this.btnGoiDien.Size = new System.Drawing.Size(60, 51);
            this.btnGoiDien.TabIndex = 6;
            this.btnGoiDien.UseVisualStyleBackColor = false;
            this.btnGoiDien.Click += new System.EventHandler(this.btnGoiDien_Click);
            // 
            // btnTuVanTC
            // 
            this.btnTuVanTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnTuVanTC.BackgroundImage = global::GameAiLaTrieuPhu.Properties.Resources.Y_Kien_K_Gia;
            this.btnTuVanTC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTuVanTC.Location = new System.Drawing.Point(669, 25);
            this.btnTuVanTC.Name = "btnTuVanTC";
            this.btnTuVanTC.Size = new System.Drawing.Size(60, 51);
            this.btnTuVanTC.TabIndex = 7;
            this.btnTuVanTC.UseVisualStyleBackColor = false;
            this.btnTuVanTC.Click += new System.EventHandler(this.btnTuVanTC_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(414, 231);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(114, 34);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "Dừng cuộc chơi";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(741, 462);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnTuVanTC);
            this.Controls.Add(this.btnGoiDien);
            this.Controls.Add(this.btn5050);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.txtCauHoi);
            this.Controls.Add(this.lblCauHoi);
            this.Controls.Add(this.lsbBonus);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbBonus;
        private System.Windows.Forms.Label lblCauHoi;
        private System.Windows.Forms.TextBox txtCauHoi;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btn5050;
        private System.Windows.Forms.Button btnGoiDien;
        private System.Windows.Forms.Button btnTuVanTC;
        private System.Windows.Forms.Button btnStop;
    }
}

