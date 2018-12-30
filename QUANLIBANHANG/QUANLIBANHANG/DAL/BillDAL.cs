using QUANLIBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLIBANHANG.DAL
{
    class BillDAL
    {
        private static BillDAL instance;

        internal static BillDAL Instance
        {
            get
            {if(instance==null)
                {
                    instance = new BillDAL();
                    return instance;
                }
                return instance;
            }
            private set => instance = value;
        }
         private BillDAL() { }
        public int GetUnCheckOutBillByTableId(int id)
        {
            DataTable dataTable = DataProvider.Instance.ExcuteQuery("SELECT * FROM BILL WHERE IDTABLE='" + id + "' AND ISPAID=0");
            if(dataTable.Rows.Count>0)
            {
                Bill bill = new Bill(dataTable.Rows[0]);
                return bill.Id;
            }
            return -1;
        }
    }
}
