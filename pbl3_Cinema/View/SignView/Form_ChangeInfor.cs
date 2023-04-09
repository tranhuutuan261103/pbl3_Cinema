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
using pbl3_Cinema.DTO;

namespace pbl3_Cinema.View.SignView
{
    public partial class Form_ChangeInfor : Form
    {
        private string email;
        public Form_ChangeInfor()
        {
            InitializeComponent();
            myInit();
        }

        public void myInit()
        {
            for (int i = 0; i < cbb_Gender.Items.Count; i++)
            {
                if (cbb_Gender.Items[i].ToString() == "Khác")
                {
                    cbb_Gender.SelectedIndex = i;
                    break;
                }
            }

            dateTimePicker_DoB.MaxDate = DateTime.Now;
        }

        public void SetInfor(object infor)
        {
            Customer_Infor customer_Infor = (Customer_Infor) infor;
            email = customer_Infor.email;
            textBox_NameUser.Text = customer_Infor.nameUser;

            for (int i = 0; i < cbb_Gender.Items.Count; i++)
            {
                if (cbb_Gender.Items[i].ToString() == customer_Infor.Gender)
                {
                    cbb_Gender.SelectedIndex = i;
                    break;
                }
            }

            textBox_PhoneNum.Text = customer_Infor.PhoneNumber;
            dateTimePicker_DoB.Value = customer_Infor.DayOfBirth;
        }

        private void btn_Oke_Click(object sender, EventArgs e)
        {
            string gender = "Khác";
            string nameUser = textBox_NameUser.Text;
            string phone = textBox_PhoneNum.Text;
            DateTime dob = dateTimePicker_DoB.Value;
            if(cbb_Gender.SelectedIndex != -1)
            {
                gender = cbb_Gender.SelectedItem.ToString();
            }

            if(nameUser == "" || phone == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            if (checkValidPhoneNumber(phone) == false)
            {
                MessageBox.Show("Số điện thoại không hợp lệ");
                return;
            }

            Account_BLL bll = new Account_BLL();
            if(bll.UpdateInforCustomer(email, nameUser,gender, phone, dob) == 1)
            {
                MessageBox.Show("Cập hật thông tin thành công");
                Dispose();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Dispose();
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
            for (int i = 0; i < length; i++)
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
