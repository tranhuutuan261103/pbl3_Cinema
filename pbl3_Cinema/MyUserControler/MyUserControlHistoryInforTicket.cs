using pbl3_Cinema.View.CustomerView.ManageBooking;
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
    public partial class MyUserControlHistoryInforTicket : UserControl
    {
        private int _id_reservation;
        private string _title_movie;
        private Image _image;
        private string _name_auditorium;
        private DateTime _booking_date;
        private DateTime _show_day;
        private TimeSpan _show_time;

        #region
        [Category("MyInfor")]
        public int id_reservation
        {
            set
            {
                _id_reservation = value;
            }
            get
            {
                return _id_reservation;
            }
        }
        [Category("MyInfor")]
        public string title_movie
        {
            set
            {
                _title_movie = value;
                label_Title.Text = _title_movie;
            }
            get
            {
                return _title_movie;
            }
        }

        [Category("MyInfor")]
        public Image image
        {
            set 
            { 
                _image = value; 
                pictureBox_Poster.Image = _image;
            }
            get
            {
                return _image;
            }
        }

        [Category("MyInfor")]
        public string name_auditorium
        {
            set
            {
                _name_auditorium = value;
                label_Auditorium.Text = _name_auditorium;
            }
            get
            {
                return _name_auditorium;
            }
        }
        [Category("MyInfor")]
        public DateTime booking_date
        {
            set
            {
                _booking_date = value;
                label_bookingDay.Text = _booking_date.ToString();
            }
            get
            {
                return _booking_date;
            }
        }
        [Category("MyInfor")]
        public DateTime showDay
        {
            set
            {
                _show_day = value;
            }
            get 
            { 
                return _show_day; 
            }
        }

        [Category("MyInfor")]
        public TimeSpan showTime
        {
            set
            {
                _show_time = value;
            }
            get 
            {
                return _show_time; 
            }
        }
        #endregion
        public MyUserControlHistoryInforTicket()
        {
            InitializeComponent();
        }

        private void MyUserControlHistoryInforTicket_Load(object sender, EventArgs e)
        {
            label_ShowDayTime.Text = _show_time.ToString() + " " + _show_day.ToString("dd-MM-yyyy") ;
        }

        public event EventHandler clickEvent;
        private void btn_Detail_Click(object sender, EventArgs e)
        {
            clickEvent(this, e);
        }
    }
}
