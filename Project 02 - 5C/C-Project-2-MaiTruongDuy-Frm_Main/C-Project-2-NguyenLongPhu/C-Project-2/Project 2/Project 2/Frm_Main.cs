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

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            {
                if (pnlHeThong.Height == 209)
                {
                    pnlHeThong.Height = 37;

                }
                else
                {
                    pnlHeThong.Height = 209;
                   

                }
            }
        }

        private void btnTacVu_Click(object sender, EventArgs e)
        {
            if (pnlTacVu.Height == 127)
            {
                pnlTacVu.Height = 37;

            }
            else
            {
                pnlTacVu.Height = 127;
                pnlHeThong.Height = 37;

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            HienThiFormLogin();
        }

        private void HienThiFormLogin()
        {
            frm_login frmLogin = new frm_login();
            frmLogin.ShowDialog();
        }

        private void btnXuLyNgonNgu_Click(object sender, EventArgs e)
        {
            Frm_DemSoTu frmXuLyNgonNgu = new Frm_DemSoTu();
            frmXuLyNgonNgu.ShowDialog();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            
            frm_login frmLogin = new frm_login();
            frmLogin.ShowDialog();

        }

        private void btnTaoSo_Click(object sender, EventArgs e)
        {
            TaoSo frmtaoso = new TaoSo();
            frmtaoso.ShowDialog();
        }

        private void btnQuanLyNguoiDung_Click(object sender, EventArgs e)
        {
            Frm_Calendar frm_Calendar = new Frm_Calendar();
            frm_Calendar.ShowDialog();
        }
    }
}
