﻿using QUANLIBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLIBANHANG.DAL
{
    public class AccDAL
    {
        private static AccDAL instance;

        public static AccDAL Instance
        {
            get { if (instance == null) {instance = new AccDAL(); }  return instance; }
            private set { instance = value; }
        }


        private AccDAL() { }

        public bool Login(string userName, string password)
        {
            string query = "SELECT * FROM dbo.Account WHERE UserName = N'"+userName+"' AND Password = N'"+password +"'";

            DataTable result = DataProvider.Instance.ExcuteQuery(query);

            return result.Rows.Count > 0;
        }
        public Accounts GetAccountByUserName(string UserName)
        {
            DataTable dataTable = DataProvider.Instance.ExcuteQuery("SELECT * FROM ACCOUNT WHERE USERNAME='" + UserName + "'");
            foreach (DataRow row in dataTable.Rows)
            {
                return new Accounts(row);
            }
            return null;
        }

        public bool EditAcc(string username, string name, string password, string newpassword)
        {
            int result = DataProvider.Instance.ExcuteNonQuery("USP_EDITACCOUNT @USERNAME , @NAME , @PASSWORD , @NEWPASSWORD", new object[] {username,name,password,newpassword });
            return result > 0;
        }
        public List<Accounts> GetAccounts ()
        {
            List<Accounts> accounts = new List<Accounts>();
            DataTable dataTable = DataProvider.Instance.ExcuteQuery("SELECT USERNAME,NAME,KINDOFACC FROM ACCOUNT");
            foreach (DataRow row in dataTable.Rows)
            {
                Accounts account = new Accounts(row);
                accounts.Add(account);
            }
            return accounts;

        }

        public bool InsertAcc(string UserName, string Name, int KindOfAcc)
        {
            string query = string.Format("INSERT ACCOUNT (UserName, Name, KindOfAcc) VALUES(N'{0}',N'{1}',N'{2}')", UserName, Name, KindOfAcc);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public bool EditAcc( string UserName, string Name, int KindOfAcc)
        {
            string query = string.Format("UPDATE ACCOUNT SET  NAME='{1}', KIND='{2}' WHERE USERNAME={0})", UserName, Name, KindOfAcc);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteAccByUserName(string UserName)
        {
            if(UserName=="ADMIN")
            {
                return false;
            }
            int result = DataProvider.Instance.ExcuteNonQuery("DELETE ACCOUNT WHERE USERNAME='" + UserName + "'");
            return result > 0;
        }
        public bool ResetPassByUserName(string UserName)
        {

            int result = DataProvider.Instance.ExcuteNonQuery("UPDATE ACCOUNT SET PASSWORD='0' WHERE USERNAME='" + UserName + "'");
            return result > 0;
        }
    }


}
