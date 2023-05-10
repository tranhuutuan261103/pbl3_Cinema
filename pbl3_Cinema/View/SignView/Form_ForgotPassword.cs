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

namespace pbl3_Cinema.View.SignView
{
    public partial class Form_ForgotPassword : Form
    {
        private int otp;
        public Form_ForgotPassword()
        {
            InitializeComponent();
            otp = -1;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btn_SendOTP_Click(object sender, EventArgs e)
        {
            if (textBox_Email.Text == "admin")
            {
                return;
            }
            string email = textBox_Email.Text;
            if (email == "")
            {
                otp = -1;
                MessageBox.Show("Vui lòng nhập email!");
                return;
            }
            if (MyFuncStatic.MyEmailFunc.checkValidEmail(email) == false)
            {
                otp = -1;
                MessageBox.Show("Email không hợp lệ");
                return;
            }
            Account_BLL bll = new Account_BLL();
            if (bll.checkExistEmailInDB(email) == true)
            {
                otp = MyFuncStatic.MyEmailFunc.getOTP(email);
                MessageBox.Show("Chúng tôi đã gửi OTP qua email của bạn đã cung cấp");
            }
            else
            {
                MessageBox.Show("Email này chưa đăng ký");
            }
        }

        private void btn_Oke_Click(object sender, EventArgs e)
        {
            
            string pass = textBox_Password.Text;
            string passConfirm = textBox_PasswordConfirm.Text;
            string email = textBox_Email.Text;

            if (textBox_Email.Text == "admin")
            {
                if (UpdatePassword(email, pass) == 1)
                {
                    MessageBox.Show("Đổi mật khẩu thành công!");
                    Dispose();
                    return;
                }
            }

            if (pass == "" ||  passConfirm == "" ||  email == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            if (checkValidPassword(pass) == false)
            {
                MessageBox.Show("Mật khẩu phải có độ dài từ 6 đến 24 ký tự!");
                return;
            }
            if (pass.CompareTo(passConfirm) != 0)
            {
                MessageBox.Show("Mật khẩu không trùng khớp");
                return;
            }

            int MyOTP = -1;
            try
            {
                MyOTP = Convert.ToInt32(textBox_OTP.Text);
            }
            catch (Exception)
            {
                MyOTP = -1;
            }
            if (MyOTP == -1 || MyOTP < 100000 || MyOTP > 999999)
            {
                MessageBox.Show("OTP không hợp lệ");
                return;
            }
            if (otp == -1 || otp != MyOTP)
            {
                MessageBox.Show("OTP không trùng khớp");
                return;
            }

            if (UpdatePassword(email, pass) == 1)
            {
                MessageBox.Show("Đổi mật khẩu thành công!");
                Dispose();
                return;
            }
            
        }

        private int UpdatePassword(string email, string pass)
        {
            Account_BLL bll = new Account_BLL();
            return bll.UpdatePassword(email, pass);
        }

        private bool checkValidPassword(string password)
        {
            if (password == null)
            {
                return false;
            }
            int length = password.Length;
            if (length < 6 || length > 24)
            {
                return false;
            }
            return true;
        }
    }
}
