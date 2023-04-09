using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3_Cinema.MyFuncStatic
{
    internal class MyEmailFunc
    {
        public static bool checkValidEmail(string email)
        {
            Regex regex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
            RegexOptions.CultureInvariant | RegexOptions.Singleline);
            Console.WriteLine($"The email is {email}");
            bool isValidEmail = regex.IsMatch(email);
            return isValidEmail;
        }

        public static int getOTP(string email)
        {
            int OTP = -1;
            Random rd = new Random();
            OTP = rd.Next(100000,999999);
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("tranhuutuan26112003@gmail.com");
            mailMessage.To.Add(email);
            mailMessage.Subject = "Mã xác nhận";
            mailMessage.Body = "Mã xác nhận là " + OTP;

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.EnableSsl = true;
            smtpClient.Port = 25;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("tranhuutuan26112003@gmail.com", "pjajvfdqktjxayzd");
            try
            {
                smtpClient.Send(mailMessage);
                //MessageBox.Show("You sent succesfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OTP;
        }
    }
}
