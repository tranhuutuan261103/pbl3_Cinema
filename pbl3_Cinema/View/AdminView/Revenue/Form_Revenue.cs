using pbl3_Cinema.BLL;
using pbl3_Cinema.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3_Cinema.View.AdminView.Statistic
{
    public partial class Form_Revenue : Form
    {
        public Form_Revenue()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            InitCBBMovies();
            InitDateTime();
            InitButton();
            GetRevenue();

        }

        private void InitCBBMovies()
        {
            Cinema_BLL bll = new Cinema_BLL();
            List<CBBMovie> list = bll.GetCBBMovies();
            list.Insert(0, new CBBMovie() { id_movie = 0, title = "All" });
            cbb_Movie.DataSource = list;
            cbb_Movie.SelectedIndex = 0;
        }

        private void InitDateTime()
        {
            dateTimePicker_EndDay.Value = DateTime.Now;
            dateTimePicker_StartDay.Value = DateTime.Now.AddDays(-60);
        }

        private void InitButton()
        {
            DataGridViewButtonColumn print = new DataGridViewButtonColumn()
            {
                Name = "Print",
                Text = "Print",
                HeaderText = "Print",
            };
            print.UseColumnTextForButtonValue = true;
            dataGridView_Revenue.Columns.Add(print);
            dataGridView_Revenue.CellClick += new DataGridViewCellEventHandler(dgv_buttonCol);
        }

        private void dgv_buttonCol(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_Revenue.Columns[e.ColumnIndex].Name != "Print")
            {
                return;
            }
            if (e.RowIndex > -1)
            {
                string name = Convert.ToString(dataGridView_Revenue.Rows[e.RowIndex].Cells["Id"].Value);
                MessageBox.Show(name);
            }
        }

        private void GetRevenue()
        {
            if (cbb_Movie.SelectedIndex == -1)
            {
                return;
            }
            CBBMovie cbb = (CBBMovie)cbb_Movie.SelectedItem;
            Revenue_BLL bll = new Revenue_BLL();
            List<Revenue> list = new List<Revenue>();
            if (cbb.id_movie == 0)
            {
                list = bll.GetRevenueByMovie(dateTimePicker_StartDay.Value, dateTimePicker_EndDay.Value);
            }
            else
            {
                list = bll.GetRevenueByMovie(cbb.id_movie, dateTimePicker_StartDay.Value, dateTimePicker_EndDay.Value);
            }
            
            dataGridView_Revenue.DataSource = list;
            dataGridView_Revenue.Columns["Id"].Visible = false;
            dataGridView_Revenue.Columns["Title"].HeaderText = "Title";
            dataGridView_Revenue.Columns["Title"].Width = 250;
            dataGridView_Revenue.Columns["Name_Auditorium"].HeaderText = "Auditorium";
            dataGridView_Revenue.Columns["Date"].HeaderText = "Date";
            dataGridView_Revenue.Columns["Date"].Width = 60;
            dataGridView_Revenue.Columns["Time"].HeaderText = "Time";
            dataGridView_Revenue.Columns["Time"].Width = 60;
            dataGridView_Revenue.Columns["Sum"].HeaderText = "Sum";
            dataGridView_Revenue.Columns["Sum"].Width = 100;
            dataGridView_Revenue.Columns["Sum"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView_Revenue.Columns["Seat_Sum"].HeaderText = "Seat Sum";
            dataGridView_Revenue.Columns["Seat_Sum"].Width = 100;
            dataGridView_Revenue.Columns["Seat_Sum"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            SetChart(list);
            SetInfor(list);
        }

        private void SetChart(List<Revenue> list)
        {
            var listChart = list.GroupBy(x => x.Date).Select(x => new { Date = x.Key, Sum = x.Sum(y => y.Sum), SumSeat = x.Sum(y => y.Seat_Sum) }).ToList();
            chart.Series.Clear();
            chart.Series.Add("Doanh thu");
            //chart.Series.Add("Tổng ghế");
            //chart.Series["Tổng ghế"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            foreach (var item in listChart)
            {
                chart.Series["Doanh thu"].Points.AddXY(item.Date.ToString("dd/MM"), item.Sum);
                //chart.Series["Tổng ghế"].Points.AddXY(item.Date.ToString("dd/MM"), item.SumSeat);
            }
        }

        private void SetInfor(List<Revenue> list)
        {
            int sum = list.Sum(x => x.Sum);
            int sumSeat = list.Sum(x => x.Seat_Sum);
            label_Revenue.Text = sum.ToString("#,##0") + " đ";
            label_SeatReserved.Text = sumSeat.ToString("#,##0");
        }

        private void cbb_Movie_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetRevenue();
        }
    }
}
