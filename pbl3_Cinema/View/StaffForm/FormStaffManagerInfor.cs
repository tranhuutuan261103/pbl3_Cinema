using pbl3_Cinema.BLL;
using pbl3_Cinema.DTO;
using pbl3_Cinema.MyUserControler;
using pbl3_Cinema.View.SignView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3_Cinema.View.StaffForm
{
    public partial class FormStaffManagerInfor : Form
    {
        public string Account { set; get; }

        Staff_Infor staff_infor;
        private void InitUserInfor()
        {
            Account_BLL bll = new Account_BLL();
            staff_infor = bll.GetInforStaffByEmail(Account);
            UserControlStaff.email = staff_infor.email;
            UserControlStaff.UserName = staff_infor.nameUser;
            UserControlStaff.PhoneNum = staff_infor.PhoneNumber;
            UserControlStaff.Gender = staff_infor.Gender;
            UserControlStaff.DoB = staff_infor.DayOfBirth;
            UserControlStaff.Position = staff_infor.position;
            UserControlStaff.Luong = staff_infor.wage.ToString();
        }
        public FormStaffManagerInfor()
        {
            InitializeComponent();
        }

        private void FormStaffManagerInfor_Load(object sender, EventArgs e)
        {
            InitUserInfor();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            Form_ForgotPassword form = new Form_ForgotPassword();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }
    }
}
