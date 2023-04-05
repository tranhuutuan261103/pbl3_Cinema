using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3_Cinema.View.CustomerView.ManageAccount
{
    public partial class FormAccountCustomerManage : Form
    {
        private string _account;
        public string account 
        {
            set
            {
                _account = value;
                label1.Text = _account;
            }
            get
            {
                return _account;
            }
        }
        public FormAccountCustomerManage()
        {
            InitializeComponent();
        }
    }
}
