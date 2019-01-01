using QUANLIBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLIBANHANG.DAL
{
    class MenuDAL
    {
        private static MenuDAL instance;

        internal static MenuDAL Instance
        { get
            {
                if(instance==null)
                {
                    instance = new MenuDAL();
                    return instance;
                }
                return instance;
            }


            set => instance = value;
        }

        public List<Menu> GetMenus(int idTable)
        {
            List<Menu> menus = new List<Menu>();
            string query = "SELECT F.NAME AS 'Tên Món Ăn', BI.SOLUONG AS 'Số Lượng', F.PRICE AS 'Giá' , BI.SOLUONG*F.PRICE AS 'Tổng Tiền' FROM BILLINFO AS BI,BILL AS B,FOOD AS F WHERE BI.IDBILL = B.ID AND BI.IDFOOD = F.ID AND B.IDTABLE = '"+idTable+"' AND B.ISPAID=0";
            DataTable dataTable = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                Menu menu = new Menu(row);
                menus.Add(menu);
            }
            return menus;
        }
        
    }
}
