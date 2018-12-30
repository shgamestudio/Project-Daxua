using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLIBANHANG.DAL
{
    class DataProvider
    {
        private static DataProvider instance;

        private DataProvider(){}
        internal static DataProvider Instance
        {
            get
            {
                if(instance ==null)
                {
                    instance = new DataProvider();
                }
                return instance;
            }
            
            private set => instance = value;
        }//Cap Instance
        string conection = @"Data Source=DESKTOP-EURJ2PN\SQLEXPRESS;Initial Catalog=QUANLIBANHANG;Integrated Security=True";
        public DataTable ExcuteQuery(string query)
        {

            DataTable dataTable = new DataTable();
            using (SqlConnection SQLconnection = new SqlConnection(conection))
            {
                SQLconnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, SQLconnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTable);
                SQLconnection.Close();
            }
            return dataTable;
        }
        public int ExcuteNonQuery(string query)
        {
            int i = 0;
            using (SqlConnection SQLconnection = new SqlConnection(conection))
            {
                SQLconnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, SQLconnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                i = sqlCommand.ExecuteNonQuery();
                SQLconnection.Close();
            }
            return i;
        }
    }
}
