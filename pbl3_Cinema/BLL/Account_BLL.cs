using pbl3_Cinema.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl3_Cinema.BLL
{
    internal class Account_BLL
    {
        public int GetRole(string email, string password)
        {
            Account_DAL dAL = new Account_DAL();
            return dAL.GetRole(email, password);
        }

        public bool checkExistEmailInDB(string email)
        {
            Account_DAL dal = new Account_DAL();
            return dal.checkExistEmailInDB(email);
        }

        public int createAccount(string email, string password, string fullName, string Gender, string phoneNum, DateTime DayOfBirth)
        {
            Account_DAL dal = new Account_DAL();
            return dal.createAccount(email, password, fullName, Gender, phoneNum, DayOfBirth);
        }
    }
}
