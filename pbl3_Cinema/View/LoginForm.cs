using pbl3_Cinema.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3_Cinema
{
    public partial class LoginForm : Form
    {
        private Form activeForm;
        public LoginForm()
        {
            InitializeComponent();
            myInit();
        }

        private void myInit()
        {
            Form_SignIn childForm = new Form_SignIn();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.Panel_Account.Controls.Add(childForm);
            childForm.Show();
            childForm.haveEvent += new Form_SignIn.HaveEvent(Open_SignUp_Form);
            childForm.loadMainForm += new Form_SignIn.LoadMainForm(Open_Main_Form);
        }

        private void Open_SignUp_Form(object o, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            Form_SignUp childForm = new Form_SignUp();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.Panel_Account.Controls.Add(childForm);
            childForm.Show();
            childForm.haveEvent += new Form_SignUp.HaveEvent(Open_SignIn_Form);
        }
        private void Open_SignIn_Form(object o, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            Form_SignIn childForm = new Form_SignIn();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.Panel_Account.Controls.Add(childForm);
            childForm.Show();
            childForm.haveEvent += new Form_SignIn.HaveEvent(Open_SignUp_Form);
            childForm.loadMainForm += new Form_SignIn.LoadMainForm(Open_Main_Form);
        }
        private void Open_Main_Form(object o, object role)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Authorization(o, (int)role);
            string account = (string)o;
            mainForm.account = account;
            mainForm.ShowDialog();
            if (activeForm != null)
            {
                if (activeForm.GetType() == typeof(Form_SignIn))
                {
                    ((Form_SignIn)activeForm).ResetTextboxPassword();
                }
            }
            this.Show();
        }
    }
}
