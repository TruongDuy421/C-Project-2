
namespace Project_2
{
    partial class Frm_TaoSoNgauNhien
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
            System.Windows.Forms.Label label1;
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTaoMaTran = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.Blue;
            label1.CausesValidation = false;
            label1.Dock = System.Windows.Forms.DockStyle.Top;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.White;
            label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(1670, 674);
            label1.TabIndex = 0;
            label1.Text = "Tạo số ngẫu nhiên ";
            label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlContainer);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnTaoMaTran);
            this.panel1.Location = new System.Drawing.Point(12, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1658, 616);
            this.panel1.TabIndex = 1;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Location = new System.Drawing.Point(3, 42);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1652, 571);
            this.pnlContainer.TabIndex = 3;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(240, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(92, 33);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTaoMaTran
            // 
            this.btnTaoMaTran.Location = new System.Drawing.Point(19, 3);
            this.btnTaoMaTran.Name = "btnTaoMaTran";
            this.btnTaoMaTran.Size = new System.Drawing.Size(186, 33);
            this.btnTaoMaTran.TabIndex = 1;
            this.btnTaoMaTran.Text = "Tạo Ma Trận";
            this.btnTaoMaTran.UseVisualStyleBackColor = true;
            this.btnTaoMaTran.Click += new System.EventHandler(this.btnTaoMaTran_Click);
            // 
            // Frm_TaoSoNgauNhien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1670, 673);
            this.Controls.Add(this.panel1);
            this.Controls.Add(label1);
            this.Name = "Frm_TaoSoNgauNhien";
            this.Text = "Frm_TaoSoNgauNhien";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTaoMaTran;
        private System.Windows.Forms.FlowLayoutPanel pnlContainer;
    }
}