using QUANLIBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLIBANHANG.DAL
{
    class TableDAL
    {
        private static TableDAL instance;
        public static int TableButtonWidth = 70;
        public static int TableButtonHeigh = 70;

        private TableDAL() { }


        internal static TableDAL Instance
        {
            get
            {
                if(instance==null)
                {
                    Instance = new TableDAL();
                    return instance;
                }
                return instance;
            }
            
            set => instance = value;
        }


        public List<Table> LoadTableList()
        {
            List<Table> tables = new List<Table>();
            DataTable dataTable = DataProvider.Instance.ExcuteQuery("SELECT * FROM ATABLE");
            foreach ( DataRow row in dataTable.Rows)
            {
                Table table = new Table(row);
                tables.Add(table);
                
            }

            return tables;
        }
    }
}
