using pbl3_Cinema.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace pbl3_Cinema.DAL
{
    internal class Account_DAL
    {
        public int GetRole(string email, string password)
        {
            using (CinemaEntities entities = new CinemaEntities())
            {
                var find = entities.accounts.Where(p => p.email == email && p.pass_word == password).FirstOrDefault();
                if (find == null)
                {
                    return -1;
                }
                int n = find.role;
                return n;
            }
        }

        public int GetRole(string email)
        {
            using (CinemaEntities entities = new CinemaEntities())
            {
                var find = entities.accounts.Where(p => p.email == email).FirstOrDefault();
                if (find == null)
                {
                    return -1;
                }
                int n = find.role;
                return n;
            }
        }

        public int GetDiscountPoint(string email)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                var cus = db.customers.Where(p=>p.email == email).FirstOrDefault();
                return cus.discount_points;
            }
        }

        public bool checkExistEmailInDB(string email)
        {
            using (CinemaEntities db = new CinemaEntities()) 
            {
                int count1 = db.accounts.Where(p => p.email == email).Count();
                if (count1 > 0)
                {
                    return true;
                }
                int count2 = db.customers.Where(p => p.email == email).Count();
                if (count2 > 0)
                {
                    return true;
                }
                int count3 = db.user_infor.Where(p => p.email_id == email).Count();
                if (count3 > 0)
                {
                    return true;
                }
                int count4 = db.staffs.Where(p=>p.email == email).Count();
                if (count4 > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public int createAccount(string email, string password, string fullName,string Gender, string phoneNum, DateTime DayOfBirth)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                account Account = new account()
                {
                    email = email,
                    pass_word = password,
                    role = 0,
                    active = true,
                };
                db.accounts.Add(Account);
                db.SaveChanges();

                user_infor infor = new user_infor()
                {
                    email_id = email,
                    full_name = fullName,
                    gender = Gender,
                    phone_number = phoneNum,
                    day_of_birth = DayOfBirth,
                };
                db.user_infor.Add(infor);
                db.SaveChanges();

                customer Customer = new customer()
                {
                    email = email,
                    discount_points = 0,
                };
                db.customers.Add(Customer);
                
                db.SaveChanges();
            }
            return 1;
        }

        public int UpdatePassword(string email, string password)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                var find = db.accounts.Where(p=>p.email == email).FirstOrDefault();
                find.pass_word = password;
                db.SaveChanges();
                return 1;
            }
        }

        public Customer_Infor GetInforCustomer(string email)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                var find = db.customers.Where(p => p.email == email).Select(p => new { p.email, p.discount_points, p.account.active, p.user_infor.full_name, p.user_infor.day_of_birth, p.user_infor.gender, p.user_infor.phone_number }).FirstOrDefault();
                Customer_Infor cus_infor = new Customer_Infor
                {
                    email = find.email,
                    nameUser = find.full_name,
                    Gender = find.gender,
                    DayOfBirth = find.day_of_birth.Value,
                    PhoneNumber = find.phone_number,
                    Active = find.active,
                    PointUser = find.discount_points,
                };
                return cus_infor;
            }
        }

        public int UpdateInforCustomer(string email, string userName, string gender,string phoneNum, DateTime DoB)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                var userinfor = db.user_infor.Where(p => p.email_id == email).FirstOrDefault();
                userinfor.full_name = userName;
                userinfor.gender = gender;
                userinfor.phone_number = phoneNum;
                userinfor.day_of_birth = DoB;
                db.SaveChanges();
            }
            return 1;
        }
    }
}
