using pbl3_Cinema.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace pbl3_Cinema.DAL
{
    internal class Account_DAL
    {
        public int GetRole(string email, string password)
        {
            using (CinemaEntities entities = new CinemaEntities())
            {
                var find = entities.accounts.Where(p => p.email == email).ToList().Where(p => p.pass_word == password).FirstOrDefault();
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

        public int GetActive(string email)
        {
            using(CinemaEntities db = new CinemaEntities())
            {
                var a = db.accounts.Where(p => p.email.CompareTo(email) == 0).FirstOrDefault();
                if (a == null)
                {
                    return -1;
                }
                return Convert.ToInt32(a.active);
            }
        }

        public bool SetActive(string email, bool _active)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                try
                {
                    var a = db.accounts.Where(p => p.email.CompareTo(email) == 0).FirstOrDefault();
                    a.active = _active;
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
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

        public List<Customer_Infor> GetInforAllCustomer()
        {
            List<Customer_Infor> list = new List<Customer_Infor> ();
            using (CinemaEntities db = new CinemaEntities())
            {
                var l = db.customers.Select(p => new { p.email, p.discount_points, p.account.active, p.user_infor.full_name, p.user_infor.day_of_birth, p.user_infor.gender, p.user_infor.phone_number });
                foreach (var item in l)
                {
                    Customer_Infor cus_infor = new Customer_Infor
                    {
                        email = item.email,
                        nameUser = item.full_name,
                        Gender = item.gender,
                        DayOfBirth = item.day_of_birth.Value,
                        PhoneNumber = item.phone_number,
                        Active = item.active,
                        PointUser = item.discount_points,
                    };
                    list.Add(cus_infor);
                }
                return list;
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

        //New 
        internal List<Staff_Infor> GetInforAllStaff()
        {
            List<Staff_Infor> list = new List<Staff_Infor>();
            using (CinemaEntities db = new CinemaEntities())
            {
                var find = db.staffs.Select(p => new { p.position, p.wage, p.email, p.account.active, p.user_infor.full_name, p.user_infor.day_of_birth, p.user_infor.gender, p.user_infor.phone_number }).ToList();
                foreach (var i in find)
                {
                    Staff_Infor temp = new Staff_Infor
                    {
                        nameUser = i.full_name,
                        email = i.email,
                        position = i.position,
                        Gender = i.gender,
                        DayOfBirth = (DateTime)i.day_of_birth,
                        PhoneNumber = i.phone_number,
                        Active = i.active,
                        wage = i.wage,
                    };
                    list.Add(temp);
                }
            }
            return list;
        }

        public int createAccountStaff(string email, string password, string fullName, string Gender, string phoneNum, DateTime DayOfBirth, string position, int wage)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                account Account = new account()
                {
                    email = email,
                    pass_word = password,
                    role = 1,
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

                staff staff = new staff()
                {
                    email = email,
                    position = position,
                    wage = wage
                };
                db.staffs.Add(staff);

                db.SaveChanges();
            }
            return 1;
        }

        public int UpdateInforStaff(string email, string userName, string gender, string phoneNum, DateTime DoB, string position, int wage)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                var userinfor = db.user_infor.Where(p => p.email_id == email).FirstOrDefault();
                userinfor.full_name = userName;
                userinfor.gender = gender;
                userinfor.phone_number = phoneNum;
                userinfor.day_of_birth = DoB;
                userinfor.staff.position = position;
                userinfor.staff.wage = wage;
                db.SaveChanges();
            }
            return 1;
        }

        internal int deleteAccountStaff(List<string> email_list)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                foreach (string email in email_list)
                {

                    var staff = db.staffs.Where(p => p.email == email).FirstOrDefault();
                    var staff_account = db.accounts.Where(p => p.email == email).FirstOrDefault();
                    var staff_infor = db.user_infor.Where(p => p.email_id == email).FirstOrDefault();
                    db.staffs.Remove(staff);
                    db.accounts.Remove(staff_account);
                    db.user_infor.Remove(staff_infor); db.SaveChanges();
                }
            }
            return 1;
        }

        internal List<Staff_Infor> GetInforStaffByFullName(string text)
        {
            List<Staff_Infor> list = new List<Staff_Infor>();
            using (CinemaEntities db = new CinemaEntities())
            {
                var find = db.staffs.Where(p => p.user_infor.full_name.Contains(text)).Select(p => new { p.position, p.wage, p.email, p.account.active, p.user_infor.full_name, p.user_infor.day_of_birth, p.user_infor.gender, p.user_infor.phone_number }).ToList();
                foreach (var i in find)
                {
                    Staff_Infor temp = new Staff_Infor
                    {
                        nameUser = i.full_name,
                        email = i.email,
                        position = i.position,
                        Gender = i.gender,
                        DayOfBirth = (DateTime)i.day_of_birth,
                        PhoneNumber = i.phone_number,
                        Active = i.active,
                        wage = i.wage,
                    };
                    list.Add(temp);
                }
            }
            return list;
        }

        internal Staff_Infor GetInforStaffByEmail(string account)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                var find = db.staffs.Where(p => p.email == account).Select(p => new { p.position, p.wage, p.email, p.account.active, p.user_infor.full_name, p.user_infor.day_of_birth, p.user_infor.gender, p.user_infor.phone_number }).FirstOrDefault();
                Staff_Infor staff_infor = new Staff_Infor
                {
                    email = find.email,
                    nameUser = find.full_name,
                    Gender = find.gender,
                    DayOfBirth = find.day_of_birth.Value,
                    PhoneNumber = find.phone_number,
                    Active = find.active,
                    position = find.position,
                    wage = find.wage
                };
                return staff_infor;
            }
        }

        public user_infor GetInforUser(string email)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                var find = db.user_infor.Where(p => p.email_id == email).Select(p => new { p.email_id, p.full_name, p.day_of_birth, p.gender, p.phone_number }).FirstOrDefault();
                user_infor user_infor = new user_infor
                {
                    email_id = find.email_id,
                    full_name = find.full_name,
                    gender = find.gender,
                    day_of_birth = find.day_of_birth.Value,
                    phone_number = find.phone_number,
                };
                return user_infor;
            }
        }

        internal void UpdateDiscountPoint(int id_reservation, int sumPay)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                var r = db.reservations.Find(id_reservation);
                var cus = db.customers.Where(p => p.email == r.customer_id).FirstOrDefault();
                cus.discount_points += sumPay / 2000;
                db.SaveChanges();
            }
        }
    }
}
