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
            DataTable dataTable = DataProvider.Instance.ExcuteQuery("SELECT  * FROM FOOD");
            foreach (DataRow row in dataTable.Rows)
            {
                Food food = new Food(row);
                foods.Add(food);
            }
            return foods;
        }
    }
}
