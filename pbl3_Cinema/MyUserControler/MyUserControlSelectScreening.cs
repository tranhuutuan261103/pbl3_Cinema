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

namespace pbl3_Cinema.MyUserControler
{
    public partial class MyUserControlSelectScreening : UserControl
    {
        public int id_movie { get; set; }
        public string nameMovie { get; set; }
        public DateTime dayShow {  get; set; }
        public MyUserControlSelectScreening()
        {
            InitializeComponent();
        }

        private void MyUserControlSelectScreening_Load(object sender, EventArgs e)
        {
            label_Title.Text = nameMovie;
            Cinema_BLL bll = new Cinema_BLL();
            List<ScreeningInfor> list = bll.GetScreeningInforsFilterIdMovie(dayShow, id_movie);
            if (list.Count == 0)
            {
                label_NullScreening.Visible = true;
            }
            this.Height += (list.Count / 4) * 120;
            foreach (ScreeningInfor item in list)
            {
                MyUserControlScreening myUserControlScreening = new MyUserControlScreening();
                myUserControlScreening.screeningInfor = item;
                myUserControlScreening.clickScreening += new EventHandler(clicked_Screening);
                flowLayoutPanel_Screening.Controls.Add(myUserControlScreening);
            }
        }

        public EventHandler clickedScreening;
        public void clicked_Screening (object sender, EventArgs e)
        {
            clickedScreening(sender, e);
        }
    }
}
