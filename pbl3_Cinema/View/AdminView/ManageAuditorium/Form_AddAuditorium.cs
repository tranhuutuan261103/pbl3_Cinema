using pbl3_Cinema.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3_Cinema.View.AdminView.ManageScreen
{
    public partial class Form_AddAuditorium : Form
    {
        public Form_AddAuditorium()
        {
            InitializeComponent();
        }

        private void btn_Oke_Click(object sender, EventArgs e)
        {
            string nameAu = textBox_NameAuditorium.Text;
            int row, col;
            try
            {
                row = Convert.ToInt32(textBox_Seat_No_Row.Text);
                col = Convert.ToInt32(textBox_Seat_No_Col.Text);
            }
            catch 
            {
                MessageBox.Show("Sai định dạng");
                return;
            }
            
            if (row <= 0 || col <= 0)
            {
                MessageBox.Show("Sai dữ liệu");
                return;
            }

            auditorium a = new auditorium()
            {
                name_auditorium = nameAu,
                seat_no_row = row,
                seat_no_column = col,
                active = true
            };

            Auditorium_BLL bll = new Auditorium_BLL();
            if (bll.AddAuditorium(a) == 1)
            {
                MessageBox.Show("Thêm thành công");
                Dispose();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
