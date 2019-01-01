using QUANLIBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLIBANHANG.DAL
{
    class FoodDAL
    {
        private static FoodDAL instance;

        internal static FoodDAL Instance
        { get
            {
                if(instance ==null)
                {
                    instance = new FoodDAL();
                    return instance;
                }
                return instance;
            }
           private set => instance = value;
        }
        private FoodDAL() { }
        public List<Food> GetFoodsByCataInDex (int id)
        {
            List<Food> foods = new List<Food>();
            DataTable dataTable = DataProvider.Instance.ExcuteQuery("SELECT * FROM FOOD WHERE IDCATEGORY='" + id + "'");
            foreach (DataRow row in dataTable.Rows)
            {
                Food food = new Food(row);
                foods.Add(food);
            }
            return foods;
        }

        public List<Food> GetFoods()
        {
            List<Food> foods = new List<Food>();
            DataTable dataTable = DataProvider.Instance.ExcuteQuery("SELECT  * FROM FOOD ORDER BY IDCATEGORY ASC");
            foreach (DataRow row in dataTable.Rows)
            {
                Food food = new Food(row);
                foods.Add(food);
            }
            return foods;
        }

        public bool InsertFood(string name, int catagoryID, int price)
        {
            string query = string.Format("INSERT FOOD VALUES(N'{0}',N'{1}',N'{2}')", name, catagoryID, price);
            int result =DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public bool EditFood(int id,string name, int categoryID, int price)
        {
            string query = string.Format("UPDATE FOOD SET NAME=N'{0}', IDCATEGORY='{1}', PRICE='{2}' WHERE ID={3}", name, categoryID, price,id);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteFoodByID(int id)
        {
            BillInfoDAL.Instance.DeleteBillInfoByFoodId(id);
            int result = DataProvider.Instance.ExcuteNonQuery("DELETE FOOD WHERE ID='" + id + "'");
            return result > 0;
        }
        
        public void DeleteFoodByCateID(int id)
        {
            DataProvider.Instance.ExcuteQuery("DELETE FOOD WHERE IDCATEGORY='" + id + "'");
        }


    }
}
