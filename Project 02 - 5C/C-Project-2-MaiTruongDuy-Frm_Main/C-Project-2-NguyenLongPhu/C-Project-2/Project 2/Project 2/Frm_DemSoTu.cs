using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2
{
    public partial class Frm_DemSoTu : Form
    {
        public Frm_DemSoTu()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public class XuLyText
        {
            //xóa khoảng trắng dư
            public static string BoKhoangTrangDu(string textInput)
            {
                string KetQua = string.Empty;
                string pattern = @"\s+";
                Regex rg = new Regex(pattern);

                KetQua = rg.Replace(textInput, " ");
                return KetQua.Trim();
                //xóa khoảng trắng đầu và đuôi
            }
            //bỏ dấu câu
            public static string BoDauCau(string textInput)
            {
                string KetQua = string.Empty;
                string[] mangDauCau = { ",", ";", ".", ":" };
                foreach (string item in mangDauCau)
                {
                    KetQua = textInput.Replace(item, "");
                }
                /*string dauCau = ",";
                KetQua = textInput.Replace(dauCau, "");*/

                return KetQua;
            }
        }
        Hashtable _hashTable;

        private void btnDemSoTu_Click(object sender, EventArgs e)
        {
            txtNoiDung.Text = XuLyText.BoDauCau(XuLyText.BoKhoangTrangDu(txtNoiDung.Text));

            string[] mangNoiDung = txtNoiDung.Text.Split(' ');
            _hashTable = new Hashtable();
            foreach (string item in mangNoiDung)
            {
                if (_hashTable.Contains(item))
                {
                    _hashTable[item] = (int)_hashTable[item] + 1;
                }
                else
                {
                    _hashTable.Add(item, 1);
                }
            }
            //hiển thị
            foreach (string item in _hashTable.Keys)
            {
                lbKetQua.Items.Add(string.Format("{0}-{1} lan", item, _hashTable[item]));
            }
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtNoiDung.Clear();
            lbKetQua.Items.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
