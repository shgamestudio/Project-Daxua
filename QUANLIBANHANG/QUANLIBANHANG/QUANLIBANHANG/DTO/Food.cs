using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLIBANHANG.DTO
{
    class Food
    {
        private int iD;
        private string name;
        private int iDCata;
        private int price;

        public Food(int id , string name, int idcata, int price)
        {
            this.iD = id;
            this.name = name;
            this.iDCata = idcata;
            this.price = price;
        }
        public Food(DataRow row)
        {
            this.iD = (int)row["ID"];
            this.name = row["NAME"].ToString() ;
            this.iDCata = (int)row["IDCATEGORY"];
            this.price = (int)row["PRICE"];
        }
        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public int IDCata { get => iDCata; set => iDCata = value; }
        public int Price { get => price; set => price = value; }
    }
}
