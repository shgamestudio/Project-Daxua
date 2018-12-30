using QUANLIBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLIBANHANG.DAL
{
    class CategoryDAL
    {
        private static CategoryDAL instance;

        internal static CategoryDAL Instance
        { get
            {
                if(instance==null)
                {
                    instance = new CategoryDAL();
                    return instance;
                }
                return instance;
            }
            set => instance = value;
        }
        private CategoryDAL() { }

        public List<Category> GetCatagories()
        {
            List<Category> catagories = new List<Category>();
            DataTable dataTable = DataProvider.Instance.ExcuteQuery("SELECT * FROM FOODCATEGORY");
            foreach (DataRow row in dataTable.Rows)
            {
                Category catagory = new Category(row);
                catagories.Add(catagory);
            }
            return catagories;
        }
    }
}
