namespace Project_2
{
    partial class frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cbNhomk = new System.Windows.Forms.CheckBox();
            this.lbtaikhoan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbmatkhau = new System.Windows.Forms.Label();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.pbshow = new System.Windows.Forms.PictureBox();
            this.pbclose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbshow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbclose)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDangnhap.CausesValidation = false;
            this.btnDangnhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangnhap.ForeColor = System.Drawing.Color.Red;
            this.btnDangnhap.Location = new System.Drawing.Point(300, 335);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(198, 62);
            this.btnDangnhap.TabIndex = 0;
            this.btnDangnhap.Text = "Đăng nhập";
            this.btnDangnhap.UseVisualStyleBackColor = false;
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Red;
            this.btnThoat.Location = new System.Drawing.Point(593, 335);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(186, 62);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cbNhomk
            // 
            this.cbNhomk.AutoSize = true;
            this.cbNhomk.Location = new System.Drawing.Point(360, 282);
            this.cbNhomk.Name = "cbNhomk";
            this.cbNhomk.Size = new System.Drawing.Size(138, 24);
            this.cbNhomk.TabIndex = 2;
            this.cbNhomk.Text = "Nhớ mật khẩu ";
            this.cbNhomk.UseVisualStyleBackColor = true;
            // 
            // lbtaikhoan
            // 
            this.lbtaikhoan.AutoSize = true;
            this.lbtaikhoan.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtaikhoan.Location = new System.Drawing.Point(167, 153);
            this.lbtaikhoan.Name = "lbtaikhoan";
            this.lbtaikhoan.Size = new System.Drawing.Size(192, 32);
            this.lbtaikhoan.TabIndex = 3;
            this.lbtaikhoan.Text = "TÀI KHOẢN :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Cyan;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(393, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "ĐĂNG NHẬP";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbmatkhau
            // 
            this.lbmatkhau.AutoSize = true;
            this.lbmatkhau.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmatkhau.Location = new System.Drawing.Point(174, 214);
            this.lbmatkhau.Name = "lbmatkhau";
            this.lbmatkhau.Size = new System.Drawing.Size(185, 32);
            this.lbmatkhau.TabIndex = 5;
            this.lbmatkhau.Text = "MẬT KHẨU :";
            this.lbmatkhau.Click += new System.EventHandler(this.lbmatkhau_Click);
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Location = new System.Drawing.Point(360, 206);
            this.txtMatkhau.Multiline = true;
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.PasswordChar = '*';
            this.txtMatkhau.Size = new System.Drawing.Size(414, 40);
            this.txtMatkhau.TabIndex = 7;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(360, 153);
            this.txtTaiKhoan.Multiline = true;
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(414, 40);
            this.txtTaiKhoan.TabIndex = 8;
            // 
            // pbshow
            // 
            this.pbshow.Image = ((System.Drawing.Image)(resources.GetObject("pbshow.Image")));
            this.pbshow.Location = new System.Drawing.Point(773, 204);
            this.pbshow.Name = "pbshow";
            this.pbshow.Size = new System.Drawing.Size(53, 42);
            this.pbshow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbshow.TabIndex = 10;
            this.pbshow.TabStop = false;
            this.pbshow.Click += new System.EventHandler(this.pbshow_Click);
            // 
            // pbclose
            // 
            this.pbclose.Image = ((System.Drawing.Image)(resources.GetObject("pbclose.Image")));
            this.pbclose.Location = new System.Drawing.Point(773, 203);
            this.pbclose.Name = "pbclose";
            this.pbclose.Size = new System.Drawing.Size(50, 43);
            this.pbclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbclose.TabIndex = 11;
            this.pbclose.TabStop = false;
            this.pbclose.Click += new System.EventHandler(this.pbclose_Click);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 624);
            this.Controls.Add(this.pbclose);
            this.Controls.Add(this.pbshow);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.lbmatkhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbtaikhoan);
            this.Controls.Add(this.cbNhomk);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangnhap);
            this.Name = "frm_login";
            this.Text = "frm_login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_login_FormClosing);
            this.Load += new System.EventHandler(this.frm_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbshow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbclose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDangnhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.CheckBox cbNhomk;
        private System.Windows.Forms.Label lbtaikhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbmatkhau;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.PictureBox pbshow;
        private System.Windows.Forms.PictureBox pbclose;
    }
}