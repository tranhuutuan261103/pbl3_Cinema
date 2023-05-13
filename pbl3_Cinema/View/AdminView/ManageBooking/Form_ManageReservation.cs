using pbl3_Cinema.BLL;
using pbl3_Cinema.DTO;
using pbl3_Cinema.View.AdminView.ManageBooking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3_Cinema.View.AdminView.ManageFilm
{
    public partial class Form_ManageReservation : Form
    {
        public Form_ManageReservation()
        {
            InitializeComponent();
            SetCBB();
            SetDateTime();
        }
        private void SetCBB()
        {
            Auditorium_BLL bll = new Auditorium_BLL();
            cbb_Auditorium.Items.Add(new CBBAuditorium
            {
                id = 0,
                nameAuditorium = "Tất cả"
            });
            cbb_Auditorium.Items.AddRange(bll.GetAllCBBAuditorimActive().ToArray());
            cbb_Auditorium.SelectedIndex = 0;
        }

        private void SetDateTime()
        {
            dateTimePicker_dayShow.Value = DateTime.Now;
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            ShowAllScreeningFollowFilter();
        }

        private void ShowAllScreeningFollowFilter()
        {
            DateTime dayFilter = dateTimePicker_dayShow.Value;
            CBBAuditorium cbb = cbb_Auditorium.SelectedItem as CBBAuditorium;

            Screening_BLL bll = new Screening_BLL();
            if (cbb.id == 0)
            {
                dataGridView.DataSource = bll.GetAllScreeningInforsFilter(dayFilter);
            }
            else
            {
                dataGridView.DataSource = bll.GetAllScreeningInforsFilter(dayFilter, cbb.id);
            }
            //dataGridView.Columns["id"].Visible = false;

        }

        private void btn_Detail_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn suất chiếu");
                return;
            }
            foreach (Control control in this.Controls)
            {
                control.Visible = false;
            }
            int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["id"].Value);
            Form_ManageReservationDetail form = new Form_ManageReservationDetail()
            {
                id_screening = id,
            };
            form.hiden += new Form_ManageReservationDetail.Hiden(visible);
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.Controls.Add(form);
            form.Show();
        }

        private void visible()
        {
            foreach(Control control in this.Controls)
            {
                control.Visible = true;
            }
        }
    }
}
