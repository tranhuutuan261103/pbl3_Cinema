using pbl3_Cinema.BLL;
using pbl3_Cinema.DTO;
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
    public partial class MyUserControlInforComment : UserControl
    {
        public rating r { set; get; }
        public MyUserControlInforComment()
        {
            InitializeComponent();
        }

        private void MyUserControlInforComment_Load(object sender, EventArgs e)
        {
            Account_BLL bll = new Account_BLL();
            Customer_Infor c = bll.GetInforCustomer(r.customer_id);
            label_NameUser.Text = c.nameUser;
            guna2RatingStar.Value = r.point / 2;
            richTextBox.Text = r.comment;
        }
    }
}
