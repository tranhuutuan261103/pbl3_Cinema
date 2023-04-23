using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3_Cinema.View.ReservationView
{
    public partial class Form_Reservation : Form
    {
        public int id_screening { set; get; }
        public string Account { set; get; }
        private Form activeForm;
        public Form_Reservation()
        {
            InitializeComponent();
        }

        private void Form_Reservation_Load(object sender, EventArgs e)
        {
            label_Title.Text = "Đặt vé";
            Form_SeatMap form = new Form_SeatMap();
            form.id_screening = id_screening;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            activeForm = form;
            panel_Body.Controls.Add(activeForm);
            form.Show();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if (label_Title.Text == "Đặt vé")
            {
                Close();
            }
        }

        private void btn_Continute_Click(object sender, EventArgs e)
        {
            if (label_Title.Text == "Đặt vé")
            {
                Form_SeatMap form_Seat = (Form_SeatMap)activeForm;
                List<int> li = form_Seat.GetAllSelectedSeat();
                string s = "";
                foreach (int id in li)
                {
                    s += " " + id;
                }
                MessageBox.Show(s);
            }
        }
    }
}
