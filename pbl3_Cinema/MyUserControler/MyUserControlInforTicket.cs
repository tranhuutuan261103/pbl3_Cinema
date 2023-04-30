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
using pbl3_Cinema.DTO;

namespace pbl3_Cinema.MyUserControler
{
    public partial class MyUserControlInforTicket : UserControl
    {
        public int id_screening { set; get; }
        public MyUserControlInforTicket()
        {
            InitializeComponent();
        }

        private void MyUserControlInforTicket_Load(object sender, EventArgs e)
        {
            if (id_screening != 0)
            {
                Cinema_BLL bll = new Cinema_BLL();
                ScreeningInfor screen = bll.GetScreeningInforById(id_screening);
                if (screen != null)
                {
                    label_Auditorium.Text = screen.nameAuditorium;
                    label_Title.Text = screen.nameMovie;
                    label_ShowDateTime.Text = screen.ShowTime + " " + screen.ShowDay.ToString("dd-MM-yyyy");
                }
                screening screen2 = bll.GetScreeningById(id_screening);
                if (screen2 != null)
                {
                    pictureBox_Poster.Image = bll.GetPosterById(screen2.movie_id);
                }
            }
        }
    }
}
