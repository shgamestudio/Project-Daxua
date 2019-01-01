﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLIBANHANG.DAL;

namespace QUANLIBANHANG.DTO
{
    class Category
    {
        private int iD;
        private string name;

        public Category(int id , string name )
        {
            this.iD = id;
            this.name = name;
        }

        public Category(DataRow row)
        {
            this.iD = (int)row["ID"];
            this.name = row["NAME"].ToString();
        }

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }

        
    }
}
