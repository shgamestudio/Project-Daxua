using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLIBANHANG.DTO
{
    class Catagory
    {
        private int iD;
        private string name;

        public Catagory(int id , string name )
        {
            this.iD = id;
            this.name = name;
        }

        public Catagory(DataRow row)
        {
            this.iD = (int)row["ID"];
            this.name = row["NAME"].ToString();
        }

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
    }
}
