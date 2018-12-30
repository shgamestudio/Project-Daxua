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
            get { if (instance == null) instance = new AccDAL();  return instance; }
            private set { instance = value; }
        }


        private AccDAL() { }

        public bool Login(string userName, string password)
        {
            string query = "SELECT * FROM dbo.Account WHERE UserName = N'"+userName+"' AND Password = N'"+password +"'";

            DataTable result = DataProvider.Instance.ExcuteQuery(query);

            return result.Rows.Count > 0;
        }




    }


}
