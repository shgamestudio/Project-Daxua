using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLIBANHANG.DTO
{
    class Menu
    {
        private string foodName;
        private int soLuong;
        private int price;
        private int totalPrice;


        public Menu(string foodname, int soluong, int price, int totalprice)
        {
            this.foodName = foodname;
            this.SoLuong = soluong;
            this.price = price;
            this.totalPrice = totalprice;
        }

        public Menu(DataRow row)
        {
            this.foodName = row["Tên Món Ăn"].ToString();
            this.SoLuong = (int)row["Số Lượng"];
            this.price = (int)row["Giá"];
            this.totalPrice = (int)row["Tổng Tiền"];
        }

            
        public string FoodName { get => foodName; set => foodName = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int Price { get => price; set => price = value; }
        public int TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}
