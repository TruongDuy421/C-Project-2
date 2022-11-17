namespace Project_2
{
    partial class Frm_Calendar
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtDayDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnCountDay = new System.Windows.Forms.Button();
            this.btnCountHour = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(3, 78);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(455, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "MONTH CALENDAR";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHienThi);
            this.groupBox1.Controls.Add(this.txtDayDate);
            this.groupBox1.Controls.Add(this.txtMax);
            this.groupBox1.Controls.Add(this.txtEnd);
            this.groupBox1.Controls.Add(this.txtMin);
            this.groupBox1.Controls.Add(this.txtStart);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(489, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(728, 345);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Day_Month_Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày bắt đầu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày kết thúc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày tối thiểu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày tối đa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày hiện tại";
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(257, 37);
            this.txtStart.Multiline = true;
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(436, 34);
            this.txtStart.TabIndex = 5;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(257, 138);
            this.txtMin.Multiline = true;
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(436, 34);
            this.txtMin.TabIndex = 6;
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(257, 86);
            this.txtEnd.Multiline = true;
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(436, 34);
            this.txtEnd.TabIndex = 7;
            this.txtEnd.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(257, 188);
            this.txtMax.Multiline = true;
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(436, 34);
            this.txtMax.TabIndex = 8;
            // 
            // txtDayDate
            // 
            this.txtDayDate.Location = new System.Drawing.Point(257, 236);
            this.txtDayDate.Multiline = true;
            this.txtDayDate.Name = "txtDayDate";
            this.txtDayDate.Size = new System.Drawing.Size(436, 34);
            this.txtDayDate.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(45, 474);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(324, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Đếm ngày trong khoảng đã chọn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(45, 519);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(306, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Đếm giờ trong khoảng đã chọn";
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(368, 465);
            this.txtDay.Multiline = true;
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(328, 34);
            this.txtDay.TabIndex = 10;
            // 
            // txtHour
            // 
            this.txtHour.Location = new System.Drawing.Point(368, 515);
            this.txtHour.Multiline = true;
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(328, 34);
            this.txtHour.TabIndex = 11;
            // 
            // btnHienThi
            // 
            this.btnHienThi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHienThi.Location = new System.Drawing.Point(257, 285);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(436, 54);
            this.btnHienThi.TabIndex = 10;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnCountDay
            // 
            this.btnCountDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCountDay.Location = new System.Drawing.Point(746, 457);
            this.btnCountDay.Name = "btnCountDay";
            this.btnCountDay.Size = new System.Drawing.Size(436, 42);
            this.btnCountDay.TabIndex = 11;
            this.btnCountDay.Text = "Count Day";
            this.btnCountDay.UseVisualStyleBackColor = true;
            this.btnCountDay.Click += new System.EventHandler(this.btnCountDay_Click);
            // 
            // btnCountHour
            // 
            this.btnCountHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCountHour.Location = new System.Drawing.Point(746, 507);
            this.btnCountHour.Name = "btnCountHour";
            this.btnCountHour.Size = new System.Drawing.Size(436, 42);
            this.btnCountHour.TabIndex = 12;
            this.btnCountHour.Text = "Count Hour";
            this.btnCountHour.UseVisualStyleBackColor = true;
            this.btnCountHour.Click += new System.EventHandler(this.btnCountHour_Click);
            // 
            // Frm_Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1229, 564);
            this.Controls.Add(this.btnCountDay);
            this.Controls.Add(this.btnCountHour);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.txtHour);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Frm_Calendar";
            this.Text = "Frm_Calendar";
            this.Load += new System.EventHandler(this.Frm_Calendar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.TextBox txtDayDate;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.Button btnCountDay;
        private System.Windows.Forms.Button btnCountHour;
    }
}