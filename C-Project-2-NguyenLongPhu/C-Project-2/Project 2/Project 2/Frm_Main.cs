using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        

        private void Frm_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            frm_login form_login = new frm_login();
            form_login.ShowDialog();
            
        }

        private void btnXuLyNgonNgu_Click(object sender, EventArgs e)
        {
            Frm_DemSoTu frmdemsotu = new Frm_DemSoTu();
            frmdemsotu.ShowDialog();
        }

        private void btnDangXuat_Click_1(object sender, EventArgs e)
        {
            frm_login form_login = new frm_login();
            form_login.ShowDialog();
            this.Close();
            this.Hide();
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            if (pnlHeThong.Height == 233)
            {
                pnlHeThong.Height = 46;

            }
            else
            {
                pnlHeThong.Height = 233;
                pnlTacVu.Height = 46;

            }
        }

        private void btnTacVu_Click(object sender, EventArgs e)
        {
            if (pnlTacVu.Height == 163)
            {
                pnlTacVu.Height = 46;

            }
            else
            {
                pnlTacVu.Height = 163;
                pnlHeThong.Height = 46;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
