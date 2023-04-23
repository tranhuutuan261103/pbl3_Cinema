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
    public partial class MyUserControlScreening : UserControl
    {
        private ScreeningInfor _screeningInfor;
        public MyUserControlScreening()
        {
            InitializeComponent();
        }
        
        public ScreeningInfor screeningInfor
        {
            set
            {
                _screeningInfor = value;
            }
            get
            {
                return _screeningInfor;
            }
        }

        private void MyUserControlScreening_Load(object sender, EventArgs e)
        {
            if (_screeningInfor != null)
            {
                label_NameAuditorium.Text = _screeningInfor.nameAuditorium;
                label_ShowTime.Text = _screeningInfor.ShowTime.Hours + ":" + _screeningInfor.ShowTime.Minutes;
                label_NoSeat.Text = (_screeningInfor.SumSeat - _screeningInfor.SumSeatReserved) + "/" + _screeningInfor.SumSeat + " Ghế";
            }
        }

        public event EventHandler clickScreening;

        private void Clicked_Screening(object sender, EventArgs e)
        {
            clickScreening(_screeningInfor, e);
        }
    }
}
