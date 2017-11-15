namespace GameAiLaTrieuPhu
{
    partial class FormGoiDien
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
            this.lblB1 = new System.Windows.Forms.Label();
            this.lblO1 = new System.Windows.Forms.Label();
            this.lblB2 = new System.Windows.Forms.Label();
            this.lblO2 = new System.Windows.Forms.Label();
            this.btnDapMay = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblB1
            // 
            this.lblB1.AutoSize = true;
            this.lblB1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB1.ForeColor = System.Drawing.Color.Black;
            this.lblB1.Location = new System.Drawing.Point(13, 13);
            this.lblB1.Name = "lblB1";
            this.lblB1.Size = new System.Drawing.Size(35, 16);
            this.lblB1.TabIndex = 0;
            this.lblB1.Text = "Bạn:";
            // 
            // lblO1
            // 
            this.lblO1.AutoSize = true;
            this.lblO1.BackColor = System.Drawing.Color.MediumOrchid;
            this.lblO1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblO1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblO1.Location = new System.Drawing.Point(48, 89);
            this.lblO1.Name = "lblO1";
            this.lblO1.Size = new System.Drawing.Size(56, 16);
            this.lblO1.TabIndex = 1;
            this.lblO1.Text = "Obama:";
            // 
            // lblB2
            // 
            this.lblB2.AutoSize = true;
            this.lblB2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB2.ForeColor = System.Drawing.Color.Black;
            this.lblB2.Location = new System.Drawing.Point(12, 137);
            this.lblB2.Name = "lblB2";
            this.lblB2.Size = new System.Drawing.Size(35, 16);
            this.lblB2.TabIndex = 2;
            this.lblB2.Text = "Bạn:";
            // 
            // lblO2
            // 
            this.lblO2.AutoSize = true;
            this.lblO2.BackColor = System.Drawing.Color.MediumOrchid;
            this.lblO2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblO2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblO2.Location = new System.Drawing.Point(48, 183);
            this.lblO2.Name = "lblO2";
            this.lblO2.Size = new System.Drawing.Size(56, 16);
            this.lblO2.TabIndex = 3;
            this.lblO2.Text = "Obama:";
            // 
            // btnDapMay
            // 
            this.btnDapMay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDapMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDapMay.ForeColor = System.Drawing.Color.Black;
            this.btnDapMay.Location = new System.Drawing.Point(15, 318);
            this.btnDapMay.Name = "btnDapMay";
            this.btnDapMay.Size = new System.Drawing.Size(89, 43);
            this.btnDapMay.TabIndex = 4;
            this.btnDapMay.Text = "Dập máy";
            this.btnDapMay.UseVisualStyleBackColor = false;
            this.btnDapMay.Click += new System.EventHandler(this.btnDapMay_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Navy;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTime.Location = new System.Drawing.Point(472, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(36, 25);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "00";
            // 
            // FormGoiDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::GameAiLaTrieuPhu.Properties.Resources.call;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(560, 373);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnDapMay);
            this.Controls.Add(this.lblO2);
            this.Controls.Add(this.lblB2);
            this.Controls.Add(this.lblO1);
            this.Controls.Add(this.lblB1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormGoiDien";
            this.Text = "FormGoiDien";
            this.Load += new System.EventHandler(this.FormGoiDien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblB1;
        private System.Windows.Forms.Label lblO1;
        private System.Windows.Forms.Label lblB2;
        private System.Windows.Forms.Label lblO2;
        private System.Windows.Forms.Button btnDapMay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
    }
}