using QUANLIBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLIBANHANG.DAL
{
    class BillInfoDAL
    {
        private static BillInfoDAL instance;

        internal static BillInfoDAL Instance
        { get
            {
                if(instance==null)
                {
                    instance = new BillInfoDAL();
                    return instance;
                }
                return instance;
            }
           private set => instance = value;
        }
        private BillInfoDAL() { }
        public List<Billinfo> GetListBillInfo(int idBill)
        {
            List<Billinfo> billinfos = new List<Billinfo>();
            DataTable dataTable = DataProvider.Instance.ExcuteQuery("SELECT * FROM BILLINFO WHERE IDBILL='" + idBill + "'");
            foreach (DataRow row in dataTable.Rows)
            {
                Billinfo billinfo = new Billinfo(row);
                billinfos.Add(billinfo);

            }
            return billinfos;
        }
        public void InsertValueBillInfo(int idBILL, int idFOOD, int SOLUONG)
        {
            DataProvider.Instance.ExcuteQuery("USP_insertBillinfo @idbill , @idfood , @count ", new object[] {idBILL,idFOOD,SOLUONG });
        }
    }
}
