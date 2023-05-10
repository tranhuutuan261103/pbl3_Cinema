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
using pbl3_Cinema.View.SignView;

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
        public void ResetTextboxPassword()
        {
            textBox_Password.Text = "";
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            haveEvent(sender, e);
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string email = textBox_Account.Text;
            string password = textBox_Password.Text;
            if (email=="" || password == "" && email!="admin")
            {
                MessageBox.Show("Thông tin không được bỏ trống");
                return;
            }
            if (MyFuncStatic.MyEmailFunc.checkValidEmail(email) == false && email!= "admin")
            {
                MessageBox.Show("Email không hợp lệ");
                return;
            }


            Account_BLL bll = new Account_BLL();
            int role = bll.GetRole(textBox_Account.Text, textBox_Password.Text);
            if (role != -1)
            {
                if (CheckActive(textBox_Account.Text) == false)
                {
                    MessageBox.Show("Tài khoản " + textBox_Account.Text + " đã bị khóa");
                    return;
                }
                loadMainForm(textBox_Account.Text, role);
            }
            else
            {
                MessageBox.Show("Sai mat khau");
            }
        }

        private bool CheckActive(string email)
        {
            Account_BLL bll = new Account_BLL();
            if (bll.GetActive(email) == 1)
            {
                return true;
            }
            return false;
        }


        private void label_ChangePassword_Click(object sender, EventArgs e)
        {
            Form_ForgotPassword form = new Form_ForgotPassword();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }
    }
}
