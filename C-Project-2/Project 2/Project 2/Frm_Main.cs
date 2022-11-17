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

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            frm_login form_login = new frm_login();
            form_login.ShowDialog();
             this.Close();
             this.Hide();
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
    }
}
