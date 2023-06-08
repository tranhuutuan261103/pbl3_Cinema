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

        public bool CreateExcel(int id_screening, DateTime dayShow, TimeSpan timeShow, string titleMovie, string nameAuditorium)
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
            exRange.Range["A5"].Value = "Mã suất chiếu: " + id_screening;
            exRange.Range["A6"].Value = "Phim: " + titleMovie;
            exRange.Range["A7"].Value = "Ngày chiếu: " + dayShow.ToString("MM/dd/yyyy") + " " + timeShow;
            exRange.Range["A8"].Value = "Phòng chiếu: " + nameAuditorium;

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
            for(int i = 0; i < list.Count; i++)
            {
                exRange.Range["A" + (row + i).ToString()].Value = i + 1;
                exRange.Range["B" + (row + i).ToString()].Value = list[i].customer_id;
                exRange.Range["C" + (row + i).ToString()].Value = list[i].booking_date.ToString();
                exRange.Range["D" + (row + i).ToString()].Value = list[i].pay;
                exRange.Range["E" + (row + i).ToString()].Value = list[i].discount_pay;
                exRange.Range["F" + (row + i).ToString()].Value = list[i].sum_pay;
            }

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
                    MessageBox.Show(e.Message);
                }
            }
            exApp.Quit();
            return true;
        }
    }
}
