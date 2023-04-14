using pbl3_Cinema.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pbl3_Cinema.DTO;

namespace pbl3_Cinema.View.AdminView.ManageScreen
{
    public partial class Form_ManageScreening : Form
    {
        public Form_ManageScreening()
        {
            InitializeComponent();
            SetCBB();
            SetShowDayPicker();
            ShowAllScreeningFollowFilter();
        }

        private void SetCBB()
        {
            Cinema_BLL bll = new Cinema_BLL();
            cbb_Auditorium.Items.Add(new CBBAuditorium
            {
                id = 0,
                nameAuditorium = "Tất cả"
            });
            cbb_Auditorium.Items.AddRange(bll.GetAllCBBAuditorimActive().ToArray());
            cbb_Auditorium.SelectedIndex = 0;
        }

        private void SetShowDayPicker()
        {
            dateTimePicker.MinDate = DateTime.Now;
            dateTimePicker.MaxDate = DateTime.Now.AddDays(7);
        }

        private void ShowAllScreeningFollowFilter()
        {
            DateTime dayFilter = dateTimePicker.Value;
            int id_auditorium = ((CBBAuditorium)cbb_Auditorium.SelectedItem).id;

            Cinema_BLL bll = new Cinema_BLL();
            dataGridView_Screening.DataSource = bll.GetScreeningInforsFilter(dayFilter);
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            ShowAllScreeningFollowFilter();
        }
    }
}
