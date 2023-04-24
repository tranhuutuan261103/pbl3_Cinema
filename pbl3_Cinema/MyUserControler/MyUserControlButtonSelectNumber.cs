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
    public partial class MyUserControlButtonSelectNumber : UserControl
    {
        public int Number { get; set; }
        public MyUserControlButtonSelectNumber()
        {
            InitializeComponent();
            Number = 0;
            UpdateNumberText();
        }

        private void UpdateNumberText()
        {
            label_Number.Text = Number.ToString();
        }

        public EventHandler clickButton;

        public void clicked_Button(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button != null )
            {
                if ( button.Text == "-")
                {
                    if (Number > 0)
                    {
                        Number--;
                        UpdateNumberText();
                    }
                }
                if ( button.Text == "+")
                {
                    if (Number < 3)
                    {
                        Number++;
                        UpdateNumberText();
                    }
                    else
                    {
                        MessageBox.Show("Chỉ đặt tối đa 1 mặt hàng 3 phần!");
                    }
                }
            }
        }
    }
}
