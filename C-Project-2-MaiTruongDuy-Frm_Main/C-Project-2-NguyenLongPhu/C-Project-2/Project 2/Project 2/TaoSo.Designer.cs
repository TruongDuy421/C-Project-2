namespace Project_2
{
    partial class TaoSo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTaoMaTran = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(273, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tạo số ngẫu nhiên";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnTaoMaTran);
            this.panel1.Controls.Add(this.pnlContainer);
            this.panel1.Location = new System.Drawing.Point(44, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 384);
            this.panel1.TabIndex = 1;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Location = new System.Drawing.Point(3, 29);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(715, 352);
            this.pnlContainer.TabIndex = 0;
            // 
            // btnTaoMaTran
            // 
            this.btnTaoMaTran.Location = new System.Drawing.Point(0, 0);
            this.btnTaoMaTran.Name = "btnTaoMaTran";
            this.btnTaoMaTran.Size = new System.Drawing.Size(75, 23);
            this.btnTaoMaTran.TabIndex = 1;
            this.btnTaoMaTran.Text = "Tạo ma trận ";
            this.btnTaoMaTran.UseVisualStyleBackColor = true;
            this.btnTaoMaTran.Click += new System.EventHandler(this.btnTaoMaTran_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(81, 0);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // TaoSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "TaoSo";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTaoMaTran;
        private System.Windows.Forms.FlowLayoutPanel pnlContainer;
    }
}