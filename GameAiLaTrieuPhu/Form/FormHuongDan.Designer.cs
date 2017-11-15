namespace GameAiLaTrieuPhu
{
    partial class FormHuongDan
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
            this.btnHuongDan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHuongDan
            // 
            this.btnHuongDan.BackColor = System.Drawing.Color.Lime;
            this.btnHuongDan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHuongDan.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuongDan.ForeColor = System.Drawing.Color.Purple;
            this.btnHuongDan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHuongDan.Location = new System.Drawing.Point(31, 488);
            this.btnHuongDan.Name = "btnHuongDan";
            this.btnHuongDan.Size = new System.Drawing.Size(188, 42);
            this.btnHuongDan.TabIndex = 5;
            this.btnHuongDan.Text = "OK";
            this.btnHuongDan.UseVisualStyleBackColor = false;
            this.btnHuongDan.Click += new System.EventHandler(this.btnHuongDan_Click);
            // 
            // FormHuongDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BackgroundImage = global::GameAiLaTrieuPhu.Properties.Resources.luatchoi1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(246, 542);
            this.Controls.Add(this.btnHuongDan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormHuongDan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHuongDan";
            this.Load += new System.EventHandler(this.FormHuongDan_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnHuongDan;
    }
}