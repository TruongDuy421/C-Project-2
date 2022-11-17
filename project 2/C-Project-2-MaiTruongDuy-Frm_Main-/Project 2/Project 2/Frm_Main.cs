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

       

        private void btnTaoSo_Click_1(object sender, EventArgs e)
        {
            Frm_TaoSoNgauNhien tao = new Frm_TaoSoNgauNhien();
            tao.ShowDialog();

        }
    }
}
