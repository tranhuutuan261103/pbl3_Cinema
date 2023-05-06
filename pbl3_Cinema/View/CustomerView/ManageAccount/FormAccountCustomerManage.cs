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
using pbl3_Cinema.View.SignView;

namespace pbl3_Cinema.View.CustomerView.ManageAccount
{
    public partial class FormAccountCustomerManage : Form
    {
        public string Account { set; get; }
        Customer_Infor cus_infor;
        public FormAccountCustomerManage()
        {
            InitializeComponent();
        }
        private void InitUserInfor()
        {
            Account_BLL bll = new Account_BLL();
            cus_infor = bll.GetInforCustomer(Account);

            myUserControlInforUser.email = cus_infor.email;
            myUserControlInforUser.UserName = cus_infor.nameUser;
            myUserControlInforUser.PhoneNum = cus_infor.PhoneNumber;
            myUserControlInforUser.Gender = cus_infor.Gender;
            myUserControlInforUser.DoB = cus_infor.DayOfBirth;
            myUserControlInforUser.Point = cus_infor.PointUser;
        }

        private void FormAccountCustomerManage_Load(object sender, EventArgs e)
        {
            InitUserInfor();
        }

        private void btn_UpdateInfor_Click(object sender, EventArgs e)
        {
            Form_ChangeInfor form = new Form_ChangeInfor();
            form.SetInfor(cus_infor);
            form.ShowDialog();
            InitUserInfor();
        }

        private void btn_ChangePass_Click(object sender, EventArgs e)
        {
            Form_ForgotPassword form = new Form_ForgotPassword();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        public delegate void SignOut();
        public SignOut signOut;
        private void btn_DelAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa tài khoản", "Xóa tài khoản", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Account_BLL bll = new Account_BLL();
                bll.SetActive(Account, false);
                signOut();
            }
        }
    }
}
