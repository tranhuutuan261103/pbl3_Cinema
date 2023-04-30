using pbl3_Cinema.MyUserControler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3_Cinema.View.CustomerView.ManageBooking
{
    public partial class Form_InforBooking : Form
    {
        public int id_screening { set; get; }
        public Form_InforBooking()
        {
            InitializeComponent();
        }

        private void LoadInforScreening()
        {
            MyUserControlInforTicket uc = new MyUserControlInforTicket()
            {
                id_screening = id_screening,
            };
            panel_InforTicket.Controls.Add(uc);
            uc.Show();
        }
        private void LoadInit()
        {
            LoadInforScreening();
        }
        private void Form_InforBooking_Load(object sender, EventArgs e)
        {
            LoadInit();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
