using QUANLIBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLIBANHANG.DAL
{
    class CatagoryDAL
    {
        private static CatagoryDAL instance;

        internal static CatagoryDAL Instance
        { get
            {
                if(instance==null)
                {
                    instance = new CatagoryDAL();
                    return instance;
                }
                return instance;
            }
            set => instance = value;
        }

        public List<Catagory> GetCatagories()
        {
            List<Catagory> catagories = new List<Catagory>();
            DataTable dataTable = DataProvider.Instance.ExcuteQuery("SELECT * FROM FOODCATEGORY");
            foreach (DataRow row in dataTable.Rows)
            {
                Catagory catagory = new Catagory(row);
                catagories.Add(catagory);
            }
            return catagories;
        }
    }
}
