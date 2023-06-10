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
using pbl3_Cinema.View.AdminView.ManageScreening;
using Guna.UI2.WinForms;

namespace pbl3_Cinema.View.AdminView.ManageScreen
{
    public partial class Form_ManageScreening : Form
    {
        public Form_ManageScreening()
        {
            InitializeComponent();
            SetCBB();
            SetShowDayPicker();

            Screening_BLL bll = new Screening_BLL();
            dataGridView_Screening.DataSource = bll.GetAllScreeningInfor().OrderByDescending(x => x.ShowDay).ThenByDescending(x => x.ShowTime).ToList();
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

        private void SetShowDayPicker()
        {
            dateTimePicker.MinDate = DateTime.Now;
            dateTimePicker.MaxDate = DateTime.Now.AddDays(7);
        }

        private void ShowAllScreeningFollowFilter()
        {
            DateTime dayFilter = dateTimePicker.Value;
            CBBAuditorium cbb = cbb_Auditorium.SelectedItem as CBBAuditorium;

            Screening_BLL bll = new Screening_BLL();
            List<ScreeningInfor> list = new List<ScreeningInfor>();
            if (cbb.id == 0)
            {
                list = bll.GetScreeningInforsFilter(dayFilter);
            }
            else
            {
                list = bll.GetScreeningInforsFilter(dayFilter, cbb.id);
            }

            list = list.OrderByDescending(x => x.ShowDay).ThenByDescending(x => x.ShowTime).ToList();

            dataGridView_Screening.DataSource = list;
            dataGridView_Screening.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_Screening.Columns["id"].Visible = true;
            dataGridView_Screening.Columns["id"].Width = 40;
            dataGridView_Screening.Columns["id"].HeaderText = "Mã SC";
            dataGridView_Screening.Columns["nameMovie"].Width = 250;
            dataGridView_Screening.Columns["nameMovie"].HeaderText = "Tên phim";
            dataGridView_Screening.Columns["nameAuditorium"].HeaderText = "Tên phòng";
            dataGridView_Screening.Columns["ShowDay"].HeaderText = "Ngày chiếu";
            dataGridView_Screening.Columns["ShowTime"].HeaderText = "Giờ chiếu";
            dataGridView_Screening.Columns["SumSeatReserved"].HeaderText = "Số ghế đã đặt";
            dataGridView_Screening.Columns["SumSeatReserved"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_Screening.Columns["SumSeat"].HeaderText = "Tổng số ghế";
            dataGridView_Screening.Columns["SumSeat"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_Screening.Columns["price"].HeaderText = "Đơn giá";
            dataGridView_Screening.Columns["price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Form_AddScreening form = new Form_AddScreening();
            form.SetTitle(((Guna2Button)sender).Text);
            form._CRUDScreening += new Form_AddScreening.CRUDScreening(AddScreening);
            form.ShowDialog();
            Screening_BLL bll = new Screening_BLL();
            dataGridView_Screening.DataSource = bll.GetAllScreeningInfor().OrderByDescending(x => x.ShowDay).ThenByDescending(x => x.ShowTime).ToList();
        }

        private void AddScreening(screening s)
        {
            Screening_BLL bll = new Screening_BLL();
            if (bll.AddScreening(s) == 1)
            {
                MessageBox.Show("Thêm suất chiếu thành công");
            }
            else
            {
                MessageBox.Show("Thêm suất chiếu thất bại");
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (dataGridView_Screening.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn suất chiếu");
                return;
            }

            int id_screening = Convert.ToInt32(dataGridView_Screening.SelectedRows[0].Cells["id"].Value);
            Screening_BLL bll = new Screening_BLL();
            if (bll.CanUpdateScreening(id_screening) == false)
            {
                return;
            }
            Form_AddScreening form = new Form_AddScreening()
            {
                id_screening = id_screening,
            };
            form.SetTitle(((Guna2Button)sender).Text);
            form._CRUDScreening += new Form_AddScreening.CRUDScreening(UpdateScreening);
            form.ShowDialog();
            ShowAllScreeningFollowFilter();
        }

        private void UpdateScreening(screening s)
        {
            Screening_BLL bll = new Screening_BLL();
            if (bll.UpdateScreening(s) == 1)
            {
                MessageBox.Show("Cập nhật suất chiếu thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật suất chiếu thất bại");
            }
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            ShowAllScreeningFollowFilter();
        }

        private void btn_AllScreening_Click(object sender, EventArgs e)
        {
            Screening_BLL bll = new Screening_BLL();
            dataGridView_Screening.DataSource = bll.GetAllScreeningInfor().OrderByDescending(x => x.ShowDay).ThenByDescending(x => x.ShowTime).ToList();
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (dataGridView_Screening.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn suất chiếu muốn xóa");
                return;
            }

            int screen_id = Convert.ToInt32(dataGridView_Screening.SelectedRows[0].Cells["id"].Value);

            Screening_BLL bll = new Screening_BLL();
            if (bll.CanDeleteScreening(screen_id) == true)
            {
                if (bll.DeleteScreeningById(screen_id) == 1) 
                {
                    MessageBox.Show("Xóa thành công");
                    dataGridView_Screening.DataSource = bll.GetAllScreeningInfor().OrderByDescending(x => x.ShowDay).ThenByDescending(x => x.ShowTime).ToList();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }
    }
}
