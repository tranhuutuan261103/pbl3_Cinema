using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pbl3_Cinema.BLL;

namespace pbl3_Cinema.View
{
    public partial class Form_SignIn : Form
    {
        public delegate void HaveEvent(object sender, EventArgs e);
        public HaveEvent haveEvent { set; get; }
        public delegate void LoadMainForm(object obj, object role);
        public LoadMainForm loadMainForm { set; get; }
        public Form_SignIn()
        {
            InitializeComponent();
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            haveEvent(sender, e);
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Cinema_BLL bll = new Cinema_BLL();
            int role = bll.GetRole(textBox_Account.Text, textBox_Password.Text);
            if (role != -1)
            {

                loadMainForm(textBox_Account.Text, role);
                textBox_Account.Text = "";
                textBox_Password.Text = "";
            }
            else
            {
                MessageBox.Show("Sai mat khau");
            }
        }

        private void label_ChangePassword_Click(object sender, EventArgs e)
        {

        }
    }
}
