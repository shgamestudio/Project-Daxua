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

        public void Paid(int id)
        {
            DataProvider.Instance.ExcuteQuery("UPDATE BILL SET ISPAID = '1' WHERE ID =" + id);
        }

        public void InsertValueBill(int id)
        {
            DataProvider.Instance.ExcuteQuery("INSERT INTO BILL VALUES (GETDATE(),NULL,'" + id + " ','0' )");
        }
        public int GetMaxBillIndex()
        {
            DataTable dataTable= DataProvider.Instance.ExcuteQuery("select max(ID) AS ID FROM BILL");
            int i = (int)dataTable.Rows[0]["ID"];
            return i;
        }
    }
}
