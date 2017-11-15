namespace GameAiLaTrieuPhu
{
    partial class FormNhapBoCauHoi
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnChonCauHoi = new System.Windows.Forms.Button();
            this.btnChonDapAn = new System.Windows.Forms.Button();
            this.btnHoanTat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(116, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lựa Chọn Chủ Đề Chơi";
            // 
            // btnChonCauHoi
            // 
            this.btnChonCauHoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnChonCauHoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnChonCauHoi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonCauHoi.Location = new System.Drawing.Point(25, 127);
            this.btnChonCauHoi.Name = "btnChonCauHoi";
            this.btnChonCauHoi.Size = new System.Drawing.Size(181, 54);
            this.btnChonCauHoi.TabIndex = 1;
            this.btnChonCauHoi.Text = "Chủ đề câu hỏi";
            this.btnChonCauHoi.UseVisualStyleBackColor = false;
            this.btnChonCauHoi.Click += new System.EventHandler(this.btnChonCauHoi_Click);
            // 
            // btnChonDapAn
            // 
            this.btnChonDapAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnChonDapAn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnChonDapAn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonDapAn.Location = new System.Drawing.Point(228, 127);
            this.btnChonDapAn.Name = "btnChonDapAn";
            this.btnChonDapAn.Size = new System.Drawing.Size(181, 54);
            this.btnChonDapAn.TabIndex = 2;
            this.btnChonDapAn.Text = "Chủ đề đáp án tương ứng";
            this.btnChonDapAn.UseVisualStyleBackColor = false;
            this.btnChonDapAn.Click += new System.EventHandler(this.btnChonDapAn_Click);
            // 
            // btnHoanTat
            // 
            this.btnHoanTat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnHoanTat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHoanTat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoanTat.Location = new System.Drawing.Point(150, 214);
            this.btnHoanTat.Name = "btnHoanTat";
            this.btnHoanTat.Size = new System.Drawing.Size(132, 53);
            this.btnHoanTat.TabIndex = 3;
            this.btnHoanTat.Text = "Hoàn Tất";
            this.btnHoanTat.UseVisualStyleBackColor = false;
            this.btnHoanTat.Click += new System.EventHandler(this.btnHoanTat_Click);
            // 
            // FormNhapBoCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(446, 333);
            this.Controls.Add(this.btnHoanTat);
            this.Controls.Add(this.btnChonDapAn);
            this.Controls.Add(this.btnChonCauHoi);
            this.Controls.Add(this.label1);
            this.Name = "FormNhapBoCauHoi";
            this.Text = "Chon dữ liệu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChonCauHoi;
        private System.Windows.Forms.Button btnChonDapAn;
        private System.Windows.Forms.Button btnHoanTat;
    }
}