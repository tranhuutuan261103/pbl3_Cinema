using pbl3_Cinema.DAL;
using pbl3_Cinema.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace pbl3_Cinema.BLL
{
    internal class Revenue_BLL
    {
        public List<Revenue> GetRevenueByMovie(int id_movie, DateTime start, DateTime end)
        {
            Revenue_DAL dal = new Revenue_DAL();
            return dal.GetRevenueByMovie(id_movie, start, end);
        }

        public List<Revenue> GetRevenueByMovie(DateTime start, DateTime end)
        {
            Revenue_DAL dal = new Revenue_DAL();
            return dal.GetRevenueByMovie(start, end);
        }

        public bool CreateExcel(int id_screening)
        {
            Revenue_DAL dal = new Revenue_DAL();
            List<reservation> list = dal.GetAllReservationById(id_screening);
            Excel.Application exApp = new Excel.Application();
            Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
            Excel.Range exRange = (Excel.Range)exSheet.Cells[3][3];

            exRange.Font.Size = 15;
            exRange.Font.Bold = true;
            exRange.Font.Color = Color.Red;
            exRange.Value = "Danh sách vé đã đặt";

            exRange = (Excel.Range)exSheet.Cells[1][1];

            exRange.Range["A5:A8"].Font.Size = 12;
            exRange.Range["A5:A8"].Font.Bold = true;

            ScreeningInfor screeningInfor = dal.GetInfor(id_screening);
            exRange.Range["A5"].Value = "Mã suất chiếu: " + id_screening;
            exRange.Range["A6"].Value = "Phim: " + screeningInfor.nameMovie;
            exRange.Range["A7"].Value = "Ngày chiếu: " + screeningInfor.ShowDay.ToString("MM/dd/yyyy") + " " + screeningInfor.ShowTime;
            exRange.Range["A8"].Value = "Phòng chiếu: " + screeningInfor.nameAuditorium;

            exRange.Range["D7"].Font.Size = 12;
            exRange.Range["D7"].Font.Bold = true;
            exRange.Range["D7"].Value = "Ngày lập: " + DateTime.Now.ToString("MM/dd/yyyy");

            exRange.Range["A10:F10"].Font.Size = 12;
            exRange.Range["A10:F10"].Font.Bold = true;
            exRange.Range["A10"].Value = "STT";
            exRange.Range["A10"].ColumnWidth = 5;
            exRange.Range["B10"].Value = "Người dùng";
            exRange.Range["B10"].ColumnWidth = 30;
            exRange.Range["C10"].Value = "Ngày đặt";
            exRange.Range["C10"].ColumnWidth = 15;
            exRange.Range["D10"].Value = "Tạm tính";
            exRange.Range["D10"].ColumnWidth = 10;
            exRange.Range["E10"].Value = "Giảm giá";
            exRange.Range["E10"].ColumnWidth = 10;
            exRange.Range["F10"].Value = "Tổng tiền";
            exRange.Range["F10"].ColumnWidth = 10;
            int row = 11;
            int n = list.Count;
            int sum = 0;
            for(int i = 0; i < n; i++)
            {
                exRange.Range["A" + (row + i).ToString()].Value = i + 1;
                exRange.Range["B" + (row + i).ToString()].Value = list[i].customer_id;
                exRange.Range["C" + (row + i).ToString()].Value = list[i].booking_date.ToString();
                exRange.Range["D" + (row + i).ToString()].Value = list[i].pay;
                exRange.Range["E" + (row + i).ToString()].Value = list[i].discount_pay;
                exRange.Range["F" + (row + i).ToString()].Value = list[i].sum_pay;
                sum += list[i].sum_pay;
            }

            exRange.Range["E" + (row + n + 1).ToString()].Font.Size = 12;
            exRange.Range["E" + (row + n + 1).ToString()].Font.Bold = true;
            exRange.Range["E" + (row + n + 1).ToString()].Value = "Tổng thu";
            exRange.Range["F" + (row + n + 1).ToString()].Value = sum;
            

            exBook.Activate();
            
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel file (*.xlsx)|*.xlsx";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    exBook.SaveAs(saveFileDialog.FileName);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            exBook.Saved = false;
            exApp.Quit();
            return true;
        }

        public bool CreateExcel(int id_movie, DateTime start, DateTime end)
        {
            List<Revenue> list = new List<Revenue>();
            if (id_movie != 0)
            {
                list = GetRevenueByMovie(id_movie, start, end);
            }
            else
            {
                list = GetRevenueByMovie(start, end);
            }
            Excel.Application exApp = new Excel.Application();
            Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
            Excel.Range exRange = (Excel.Range)exSheet.Cells[3][3];

            exRange.Font.Size = 15;
            exRange.Font.Bold = true;
            exRange.Font.Color = Color.Red;
            exRange.Value = "Doanh thu";

            exRange = (Excel.Range)exSheet.Cells[1][1];

            exRange.Range["A5:A8"].Font.Size = 12;
            exRange.Range["A5:A8"].Font.Bold = true;

            if (id_movie == 0)
            {
                exRange.Range["A6"].Value = "Phim: " + "Tất cả";
            }
            else
            {
                Cinema_BLL bllMovie = new Cinema_BLL();
                MyMovieInfor m = bllMovie.GetMovieById(id_movie);
                exRange.Range["A6"].Value = "Phim: " + m.Title;
            }
            
            exRange.Range["A7"].Value = "Ngày bắt đầu: " + start.ToString("MM/dd/yyyy");
            exRange.Range["A8"].Value = "Ngày kết thúc: " + end.ToString("MM/dd/yyyy");

            exRange.Range["D7"].Font.Size = 12;
            exRange.Range["D7"].Font.Bold = true;
            exRange.Range["D7"].Value = "Ngày lập: " + DateTime.Now.ToString("MM/dd/yyyy");

            exRange.Range["A10:F10"].Font.Size = 12;
            exRange.Range["A10:F10"].Font.Bold = true;
            exRange.Range["A10"].Value = "STT";
            exRange.Range["A10"].ColumnWidth = 5;
            exRange.Range["B10"].Value = "Tên phim";
            exRange.Range["B10"].ColumnWidth = 30;
            exRange.Range["C10"].Value = "Phòng chiếu";
            exRange.Range["C10"].ColumnWidth = 15;
            exRange.Range["D10"].Value = "Ngày chiếu";
            exRange.Range["D10"].ColumnWidth = 18;
            exRange.Range["E10"].Value = "Tổng tiền";
            exRange.Range["E10"].ColumnWidth = 10;
            exRange.Range["F10"].Value = "Tổng ghế";
            exRange.Range["F10"].ColumnWidth = 5;
            int row = 11;
            int n = list.Count;
            int sum = 0;
            int seat_sum = 0;
            for (int i = 0; i < n; i++)
            {
                exRange.Range["A" + (row + i).ToString()].Value = i + 1;
                exRange.Range["B" + (row + i).ToString()].Value = list[i].Title;
                exRange.Range["C" + (row + i).ToString()].Value = list[i].Name_Auditorium;
                exRange.Range["D" + (row + i).ToString()].Value = list[i].Date.ToString("MM/dd/yyyy") + " " + list[i].Time.ToString();
                exRange.Range["E" + (row + i).ToString()].Value = list[i].Sum;
                exRange.Range["F" + (row + i).ToString()].Value = list[i].Seat_Sum;
                sum += list[i].Sum;
                seat_sum += list[i].Seat_Sum;
            }

            exRange.Range["D" + (row + n).ToString() + ":" + "F" + (row + n).ToString()].Font.Size = 12;
            exRange.Range["D" + (row + n).ToString() + ":" + "F" + (row + n).ToString()].Font.Bold = true;
            exRange.Range["D" + (row + n).ToString()].Value = "Tổng";
            exRange.Range["E" + (row + n).ToString()].Value = sum;
            exRange.Range["F" + (row + n).ToString()].Value = seat_sum;


            exBook.Activate();

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel file (*.xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    exBook.SaveAs(saveFileDialog.FileName);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            exBook.Saved = false;
            exApp.Quit();
            return true;
        }
    }
}
