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
    public partial class Frm_Calendar : Form
    {
        public Frm_Calendar()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_Calendar_Load(object sender, EventArgs e)
        {

        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            txtStart.Text = monthCalendar1.SelectionStart.ToShortDateString();
            txtEnd.Text = monthCalendar1.SelectionEnd.ToShortDateString();
            txtMin.Text = monthCalendar1.MinDate.ToShortDateString();
            txtMax.Text = monthCalendar1.MaxDate.ToShortDateString();
            txtDayDate.Text = monthCalendar1.TodayDate.ToShortDateString();
        }

        private void btnCountDay_Click(object sender, EventArgs e)
        {
            int numdays;
            numdays = Convert.ToInt32((monthCalendar1.SelectionEnd - monthCalendar1.SelectionStart).TotalDays);
            txtDay.Text = numdays.ToString();
        }

        private void btnCountHour_Click(object sender, EventArgs e)
        {
            int numhour;
            numhour = Convert.ToInt32((monthCalendar1.SelectionEnd - monthCalendar1.SelectionStart).TotalHours);
            txtHour.Text = numhour.ToString();
        }
    }
}
