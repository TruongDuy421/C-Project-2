using Project_2.DataLayer;
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
    public partial class frm_login : Form
    {
        List<User> users = Danhsachuser.Instance.Users;
        string taiKhoan = "admin";
        string matKhau = "123";
        bool thoat = true;
        public frm_login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbmatkhau_Click(object sender, EventArgs e)
        {

        }

        private void frm_login_Load(object sender, EventArgs e)
        {
           
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Chương trình sẽ được thoát.\n Hãy xác định việc này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                thoat = true;
                Application.Exit();
            }

            
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTaiKhoan.Text))
            {
                if (!string.IsNullOrEmpty(txtMatkhau.Text))
                {
                    if (Kiemtradangnhap(txtTaiKhoan.Text, txtMatkhau.Text))
                    {
                        thoat = true;
                        this.Close();
                        //Frm_Main f_main = new Frm_Main();
                        //f_main.Show();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không đúng\n Xin vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtTaiKhoan.ResetText();
                        txtMatkhau.Text = string.Empty;
                        //Quay lại chỗ tải khoản
                        txtTaiKhoan.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("Chưa nhập mật khẩu\n Xin vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMatkhau.Focus();
                    //Quay lại chỗ mật khẩu 
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập tài khoản\n Xin vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaiKhoan.Focus();
                //Quay lại chỗ tải khoản
            }
           
        }


        bool Kiemtradangnhap(string taiKhoan, string matKhau)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (taiKhoan == users[i].TaiKhoan && matKhau == users[i].MatKhau)
                {
                    return true;
                }
            


            }
            return false;
            
        }
        
        //Hàm hiển thị con mắt 
        private void pbclose_Click(object sender, EventArgs e)
        {
            if (txtMatkhau.PasswordChar=='*')
            {
                pbshow.BringToFront();
                txtMatkhau.PasswordChar = '\0';

            }    
        }

        private void pbshow_Click(object sender, EventArgs e)
        {
            if (txtMatkhau.PasswordChar == '\0')
            {
                pbclose.BringToFront();
                txtMatkhau.PasswordChar = '*';

            }
        }

        private void frm_login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thoat== true)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
