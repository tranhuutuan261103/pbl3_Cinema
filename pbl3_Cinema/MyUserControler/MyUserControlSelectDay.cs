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
    public partial class MyUserControlSelectDay : UserControl
    {
        public MyUserControlSelectDay()
        {
            InitializeComponent();
            myInit();
        }
        #region Properties
        private DateTime _myDateTime;
        private int _hightLight;
        [Category("Custom Props")]
        public DateTime myDateTime
        {
            set
            {
                _myDateTime = value;
                label_Day.Text = value.Day.ToString();
                SetTextDay(value);
            }
            get
            {
                return _myDateTime;
            }
        }

        public int hightLight
        {
            set
            {
                _hightLight = value;
            }
            get
            {
                return _hightLight;
            }
        }
        #endregion

        private void myInit()
        {
            panel_Color.Height = Height/2;
        }

        private void SetTextDay(DateTime date)
        {
            if (date == null)
            {
                label_TextDay.Text = "Error";
                return;
            }

            if (date.Day == DateTime.Now.Day)
            {
                label_TextDay.Text = "Today";
                return;
            }

            label_TextDay.Text = date.DayOfWeek.ToString();
        }

        private void SetColor(Color color)
        {
            if (color != null && color != BackColor)
            {
                BackColor = color;
            }
        }

        private void Mouse_Enter(object sender, EventArgs e)
        {
            SetColor(Color.Blue);
            Cursor = Cursors.Hand;
        }

        private void Mouse_Leave(object sender, EventArgs e)
        {
            SetColor(DefaultBackColor);
            Cursor = Cursors.Default;
        }
        public event EventHandler clickDay;
        public void button_Clicked()
        {
            clickDay(this, null);
        }

        private void button_Click(object sender, EventArgs e)
        {
            clickDay(this, e);
        }

        public void SetSelectedShowDay()
        {
            panel_Color.BackColor = Color.Green;
        }

        public void SetNotSelectedShowDay()
        {
            panel_Color.BackColor = DefaultBackColor;
        }
    }
}
