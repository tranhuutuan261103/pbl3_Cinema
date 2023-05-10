using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using pbl3_Cinema.BLL;
using pbl3_Cinema.DTO;

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

        public static void SendInforBookingToEmail(string email, int id_reservation)
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("tranhuutuan26112003@gmail.com");
            mailMessage.To.Add(email);
            mailMessage.Subject = "Mã xác nhận";
            Reservation_BLL bll = new Reservation_BLL();
            reservation r = bll.GetReservationById(id_reservation);
            string bodyText = GetInfor(r);

            

            mailMessage.Body = bodyText;

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.EnableSsl = true;
            smtpClient.Port = 25;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("tranhuutuan26112003@gmail.com", "pjajvfdqktjxayzd");
            try
            {
                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string GetInfor(reservation r)
        {
            string bodyText = "";
            Cinema_BLL bll = new Cinema_BLL();
            auditorium a = bll.GetAuditoriumByIdScreening((int)r.screening_id);
            screening s = bll.GetScreeningById((int)r.screening_id);
            MyMovieInfor m = bll.GetMovieById(s.movie_id);
            Reservation_BLL res_bll = new Reservation_BLL();
            List<seat_reserved> seat_Reserveds = res_bll.GetReservedSeatByIdReservation(r.id);
            List<seat> l = bll.GetAllReservedSeatLocation(seat_Reserveds);
            // Tao thong tin
            bodyText += "Chúc mừng! Bạn đã đặt vé thành công! \n";
            bodyText += m.Title.ToUpper();
            bodyText += "\nGhế: " ;
            foreach (seat item in l)
            {
                bodyText +=  (char)(item.row_location + 64) + (item.column_location).ToString() + " ";
            }
            bodyText += "\nNgày: " + s.show_day.ToString("dd-MM-yyyy ");
            bodyText += "\nThời gian: " + s.show_time.ToString();
            bodyText += "\nPhòng: " + a.name_auditorium;
            return bodyText;
        }
    }
}
