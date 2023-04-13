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

namespace pbl3_Cinema.View
{
    public partial class Form_SignUp : Form
    {
        public delegate void HaveEvent(object sender, EventArgs e);
        public HaveEvent haveEvent { set; get; }
        private int otp { set; get; }
        public Form_SignUp()
        {
            InitializeComponent();
            dateTimePicker_DoB.MaxDate = DateTime.Now;
            otp = -1;
        }

        private void label_Exit_Click(object sender, EventArgs e)
        {
            haveEvent(sender, e);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string email = textBox_Email.Text;
            if (email == "")
            {
                otp = -1;
                MessageBox.Show("Vui lòng nhập email!");
                return;
            }
            if (MyFuncStatic.MyEmailFunc.checkValidEmail(email)==false) 
            {
                otp = -1;
                MessageBox.Show("Email không hợp lệ");
                return;
            }
            Account_BLL bll = new Account_BLL();
            if (bll.checkExistEmailInDB(email) == true)
            {
                MessageBox.Show("Email này đã đăng ký");
                return;
            }
            otp = MyFuncStatic.MyEmailFunc.getOTP(email);
            MessageBox.Show("Chúng tôi đã gửi OTP qua email của bạn đã cung cấp");
        }

        private void btn_Accept_SignUp_Click(object sender, EventArgs e)
        {
            string name = textBox_Name.Text;
            string gender = "Khác";
            if (cbb_Gender.SelectedIndex != -1)
            {
                gender = cbb_Gender.SelectedItem.ToString();
            }
            string phoneNum = textText_PhoneNumber.Text;
            if(checkValidPhoneNumber(phoneNum) != true)
            {
                MessageBox.Show("Số điện thoại không hợp lệ!");
                return;
            }
            string email = textBox_Email.Text;
            string password = textBox_Password.Text;
            string passwordComfirm = textBox_PasswordConfirm.Text;
            if (name == "" || email =="" || password =="" || passwordComfirm == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            if (checkValidPassword(password) == false)
            {
                MessageBox.Show("Mật khẩu phải có độ dài từ 6 đến 24 ký tự!");
                return;
            }
            if (passwordComfirm.CompareTo(password) != 0)
            {
                MessageBox.Show("Mật khẩu không trùng khớp");
                return;
            }
            int MyOTP = -1;
            try
            {
                MyOTP = Convert.ToInt32(textBox_OTP.Text);
            } catch (Exception)
            {
                MyOTP = -1;
            }
            if (MyOTP == -1 || MyOTP < 100000 || MyOTP > 999999)
            {
                MessageBox.Show("OTP không hợp lệ");
                return;
            }
            if (otp == -1 || otp!=MyOTP)
            {
                MessageBox.Show("Thông tin không trùng khớp");
                return;
            }

            
            Account_BLL bll = new Account_BLL();
            bll.createAccount(email, password, name, gender, phoneNum, dateTimePicker_DoB.Value);
            MessageBox.Show("Bạn đã đăng ký thành công");
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

        private bool checkValidPhoneNumber(string phoneNumber)
        {
            if (phoneNumber == null)
            {
                return false;
            }
            int length = phoneNumber.Length;
            if (length != 10)
            {
                return false;
            }
            for (int i = 0;i<length;i++)
            {
                if (phoneNumber[i] < 48 || phoneNumber[i] > 57)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
