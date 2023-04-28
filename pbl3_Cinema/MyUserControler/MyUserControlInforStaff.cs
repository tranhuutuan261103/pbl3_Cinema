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
    public partial class MyUserControlInforStaff : UserControl
    {
        public string _email;
        public string email
        {
            set
            {
                _email = value;
                label_Email.Text = _email;
            }
            get
            {
                return _email;
            }
        }
        public string _UserName;
        public string UserName
        {
            set
            {
                _UserName = value;
                label_Name.Text = _UserName;
            }
            get
            {
                return _UserName;
            }
        }
        public string _gender;
        public string Gender
        {
            set
            {
                _gender = value;
                label_Gender.Text = _gender;
            }
            get
            {
                return _gender;
            }
        }
        public string _phoneNum;
        public string PhoneNum
        {
            set
            {
                _phoneNum = value;
                label_PhoneNum.Text = _phoneNum;
            }
            get
            {
                return _phoneNum;
            }
        }
        private DateTime _DoB;
        public DateTime DoB
        {
            set
            {
                _DoB = value;
                label_DoB.Text = DoB.Day + "/" + DoB.Month + "/" + DoB.Year;
            }
            get
            {
                return _DoB;
            }
        }
        private string _position;
        public string Position
        {
            set
            {
                _position = value;
                label_position.Text = _position.ToString();
            }
            get
            {
                return _position;
            }
        }

        private string _luong;
        public string Luong
        {
            set
            {
                _luong = value;
                label_Luong.Text = _luong.ToString();
            }
            get
            {
                return _luong;
            }
        }
        public MyUserControlInforStaff()
        {
            InitializeComponent();
        }
    }
}
