using QUANLIBANHANG.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLIBANHANG.DTO
{
    public class Accounts
    {
        private string userName;
        private string name;
        private string passWord;
        private int kindOfAcc;
        public Accounts(string username, string name, string password, int kindofacc)
        {
            this.userName = username;
            this.name = name;
            this.passWord = password;
            this.kindOfAcc = kindofacc;
        }

        public Accounts(DataRow row)
        {
            this.userName = row["USERNAME"].ToString();
            this.name = row["NAME"].ToString();
            this.passWord = row["PASSWORD"].ToString();
            this.kindOfAcc = (int)row["KINDOFACC"];
        }
        public string UserName { get => userName; set => userName = value; }
        public string Name { get => name; set => name = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public int KindOfAcc { get => kindOfAcc; set => kindOfAcc = value; }
    }
}
