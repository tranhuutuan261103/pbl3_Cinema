﻿using pbl3_Cinema.DAL;
using pbl3_Cinema.DTO;
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

        public int GetRole(string email)
        {
            Account_DAL dAL = new Account_DAL();
            return dAL.GetRole(email);
        }

        public int GetDiscountPoint(string email)
        {
            Account_DAL dal = new Account_DAL();
            return dal.GetDiscountPoint(email);
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

        public int UpdatePassword(string email, string password)
        {
            Account_DAL dal = new Account_DAL();
            return dal.UpdatePassword(email, password);
        }

        public Customer_Infor GetInforCustomer(string email)
        {
            Account_DAL dal = new Account_DAL();
            return dal.GetInforCustomer(email);
        }
        public int UpdateInforCustomer(string email, string userName, string gender, string phoneNum, DateTime DoB)
        {
            Account_DAL dal = new Account_DAL();
            return dal.UpdateInforCustomer(email, userName, gender, phoneNum, DoB);
        }
    }
}
