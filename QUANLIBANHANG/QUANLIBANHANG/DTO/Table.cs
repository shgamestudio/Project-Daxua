using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLIBANHANG.DTO
{
    class Table
    {
        private string name;
        private int iD;
        private string status;

        public Table(DataRow row)
        {
            Name = row["NAME"].ToString();
            ID = (int)row["ID"];
            Status = row["STATUS"].ToString();
        }

        private Table(int id, string name, string status)
        {
            ID = id;
            Name = name;
            Status = status;
        }

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Status { get => status; set => status = value; }
    }
}
