using System;
using System.Collections.Generic;
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

        private Table(int id, string name, string status)
        {
            ID = id;
            Name = name;
            Status = status;
        }

        public int ID { get => iD; set => iD = value; }
        public string Name { get => Name; set => Name = value; }
        public string Status { get => status; set => status = value; }
    }
}
