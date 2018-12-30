using QUANLIBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLIBANHANG.DAL
{
    class TableDAL
    {
        private static TableDAL instance;
        private TableDAL() { }
        internal static TableDAL Instance { get => instance; set => instance = value; }
        public List<Table> LoadTableList()
        {
            List<Table> tables = new List<Table>();

            return tables;
        }
    }
}
