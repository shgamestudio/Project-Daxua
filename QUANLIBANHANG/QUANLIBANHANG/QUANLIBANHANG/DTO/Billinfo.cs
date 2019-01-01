using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLIBANHANG.DTO
{
    class Billinfo
    {
        private int iD;
        private int iDBill;
        private int iDFood;
        private int soluong;

        public Billinfo(int id,int idbill,int idfood,int soluong)
        {
            this.iD = id;
            this.iDBill = idbill;
            this.iDFood = idfood;
            this.soluong = soluong;
        }

        public Billinfo(DataRow row)
        {
            this.iD = (int)row["ID"];
            this.iDBill = (int)row["IDBILL"];
            this.iDFood = (int)row["IDFOOD"];
            this.soluong = (int)row["SOLUONG"];
        
        }
        public int ID { get => iD; set => iD = value; }
        public int IDBill { get => iDBill; set => iDBill = value; }
        public int IDFood { get => iDFood; set => iDFood = value; }
        public int Soluong { get => soluong; set => soluong = value; }
    }
}
