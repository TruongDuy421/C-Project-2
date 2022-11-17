namespace Project_2
{
    partial class Frm_Main
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlTacVu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTacVu = new System.Windows.Forms.Button();
            this.btnXuLyNgonNgu = new System.Windows.Forms.Button();
            this.btnTaoSo = new System.Windows.Forms.Button();
            this.pnlHeThong = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHeThong = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnX = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlTacVu.SuspendLayout();
            this.pnlHeThong.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Blue;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 656);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1337, 26);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(66, 20);
            this.toolStripStatusLabel1.Text = "Team 5C";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlTacVu);
            this.panel1.Controls.Add(this.pnlHeThong);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 656);
            this.panel1.TabIndex = 1;
            // 
            // pnlTacVu
            // 
            this.pnlTacVu.Controls.Add(this.btnTacVu);
            this.pnlTacVu.Controls.Add(this.btnXuLyNgonNgu);
            this.pnlTacVu.Controls.Add(this.btnTaoSo);
            this.pnlTacVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTacVu.Location = new System.Drawing.Point(0, 303);
            this.pnlTacVu.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTacVu.Name = "pnlTacVu";
            this.pnlTacVu.Size = new System.Drawing.Size(241, 156);
            this.pnlTacVu.TabIndex = 4;
            // 
            // btnTacVu
            // 
            this.btnTacVu.BackColor = System.Drawing.Color.Blue;
            this.btnTacVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTacVu.ForeColor = System.Drawing.Color.White;
            this.btnTacVu.Location = new System.Drawing.Point(4, 4);
            this.btnTacVu.Margin = new System.Windows.Forms.Padding(4);
            this.btnTacVu.Name = "btnTacVu";
            this.btnTacVu.Size = new System.Drawing.Size(237, 46);
            this.btnTacVu.TabIndex = 5;
            this.btnTacVu.Text = "Tác Vụ";
            this.btnTacVu.UseVisualStyleBackColor = false;
            this.btnTacVu.Click += new System.EventHandler(this.btnTacVu_Click);
            // 
            // btnXuLyNgonNgu
            // 
            this.btnXuLyNgonNgu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnXuLyNgonNgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuLyNgonNgu.ForeColor = System.Drawing.Color.White;
            this.btnXuLyNgonNgu.Location = new System.Drawing.Point(4, 58);
            this.btnXuLyNgonNgu.Margin = new System.Windows.Forms.Padding(4);
            this.btnXuLyNgonNgu.Name = "btnXuLyNgonNgu";
            this.btnXuLyNgonNgu.Size = new System.Drawing.Size(237, 46);
            this.btnXuLyNgonNgu.TabIndex = 7;
            this.btnXuLyNgonNgu.Text = "Xử lý ngôn ngữ";
            this.btnXuLyNgonNgu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuLyNgonNgu.UseVisualStyleBackColor = false;
            this.btnXuLyNgonNgu.Click += new System.EventHandler(this.btnXuLyNgonNgu_Click);
            // 
            // btnTaoSo
            // 
            this.btnTaoSo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTaoSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoSo.ForeColor = System.Drawing.Color.White;
            this.btnTaoSo.Location = new System.Drawing.Point(4, 112);
            this.btnTaoSo.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaoSo.Name = "btnTaoSo";
            this.btnTaoSo.Size = new System.Drawing.Size(237, 46);
            this.btnTaoSo.TabIndex = 6;
            this.btnTaoSo.Text = "Tạo số ngẫu nhiên\r\n";
            this.btnTaoSo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoSo.UseVisualStyleBackColor = false;
            this.btnTaoSo.Click += new System.EventHandler(this.btnTaoSo_Click);
            // 
            // pnlHeThong
            // 
            this.pnlHeThong.Controls.Add(this.btnHeThong);
            this.pnlHeThong.Controls.Add(this.btnDangXuat);
            this.pnlHeThong.Controls.Add(this.btnDoiMatKhau);
            this.pnlHeThong.Controls.Add(this.btnCalendar);
            this.pnlHeThong.Controls.Add(this.btnThoat);
            this.pnlHeThong.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeThong.Location = new System.Drawing.Point(0, 46);
            this.pnlHeThong.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHeThong.Name = "pnlHeThong";
            this.pnlHeThong.Size = new System.Drawing.Size(241, 257);
            this.pnlHeThong.TabIndex = 0;
            // 
            // btnHeThong
            // 
            this.btnHeThong.BackColor = System.Drawing.Color.Blue;
            this.btnHeThong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeThong.ForeColor = System.Drawing.Color.White;
            this.btnHeThong.Location = new System.Drawing.Point(4, 4);
            this.btnHeThong.Margin = new System.Windows.Forms.Padding(4);
            this.btnHeThong.Name = "btnHeThong";
            this.btnHeThong.Size = new System.Drawing.Size(237, 46);
            this.btnHeThong.TabIndex = 0;
            this.btnHeThong.Text = "Hệ thống\r\n";
            this.btnHeThong.UseVisualStyleBackColor = false;
            this.btnHeThong.Click += new System.EventHandler(this.btnHeThong_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Location = new System.Drawing.Point(4, 58);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(4);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(237, 46);
            this.btnDangXuat.TabIndex = 1;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMatKhau.ForeColor = System.Drawing.Color.White;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(4, 112);
            this.btnDoiMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(237, 46);
            this.btnDoiMatKhau.TabIndex = 2;
            this.btnDoiMatKhau.Text = "Đổi Mật Khẩu";
            this.btnDoiMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoiMatKhau.UseVisualStyleBackColor = false;
            // 
            // btnCalendar
            // 
            this.btnCalendar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendar.ForeColor = System.Drawing.Color.White;
            this.btnCalendar.Location = new System.Drawing.Point(4, 166);
            this.btnCalendar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(237, 46);
            this.btnCalendar.TabIndex = 3;
            this.btnCalendar.Text = "Lịch biểu";
            this.btnCalendar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendar.UseVisualStyleBackColor = false;
            this.btnCalendar.Click += new System.EventHandler(this.btnQuanLyNguoiDung_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(4, 220);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(237, 46);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 46);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Blue;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnX);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(241, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1096, 46);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(457, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "PROJECT 2";
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.Blue;
            this.btnX.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.ForeColor = System.Drawing.Color.White;
            this.btnX.Location = new System.Drawing.Point(1044, 0);
            this.btnX.Margin = new System.Windows.Forms.Padding(4);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(52, 46);
            this.btnX.TabIndex = 0;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(241, 46);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1096, 610);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1088, 581);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 682);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Main";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlTacVu.ResumeLayout(false);
            this.pnlHeThong.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel pnlTacVu;
        private System.Windows.Forms.Button btnTacVu;
        private System.Windows.Forms.Button btnXuLyNgonNgu;
        private System.Windows.Forms.Button btnTaoSo;
        private System.Windows.Forms.FlowLayoutPanel pnlHeThong;
        private System.Windows.Forms.Button btnHeThong;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.Button btnCalendar;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}