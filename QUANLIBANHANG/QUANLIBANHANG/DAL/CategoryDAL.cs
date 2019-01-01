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

        public Category GetCategoryByID( int id)
        {
            Category category = null;
            DataTable dataTable = DataProvider.Instance.ExcuteQuery("SELECT * FROM FOODCATEGORY WHERE ID='"+id+"'");
            category = new Category(dataTable.Rows[0]);
            return category;

        }
        public bool InsertCate(string name)
        {
            string query = string.Format("INSERT FOODCATEGORY VALUES(N'{0}')", name);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public bool EditCate(int id,string name)
        {
            string query = string.Format("UPDATE FOODCATEGORY SET NAME=N'{0}' WHERE ID=N'{1}'", name,id);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteCateByID(int id)
        {
            FoodDAL.Instance.DeleteFoodByCateID(id);
            int result = DataProvider.Instance.ExcuteNonQuery("DELETE FOODCATEGORY WHERE ID='" + id + "'");
            return result > 0;
        }

    }
}
