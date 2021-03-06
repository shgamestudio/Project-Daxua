﻿using System;
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
        string conection = @"Data Source=.\SQLEXPRESS;Initial Catalog=QUANLIBANHANG;Integrated Security=True";

        

        public DataTable ExcuteQuery(string query, object[] parameter =null)
        {

            DataTable dataTable = new DataTable();
            using (SqlConnection SQLconnection = new SqlConnection(conection))
            {
                SQLconnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, SQLconnection);
                if(parameter !=null)
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listpara)
                    {
                        if (item.Contains("@"))
                        {
                            sqlCommand.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTable);
                SQLconnection.Close();
            }
            return dataTable;
        }
        public int ExcuteNonQuery(string query, object[] parameter = null)
        {
            int i = 0;
            using (SqlConnection SQLconnection = new SqlConnection(conection))
            {
                SQLconnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, SQLconnection);
               
                if (parameter != null)
                {
                    string[] listpara = query.Split(' ');
                    int j = 0;
                    foreach (string item in listpara)
                    {
                        if (item.Contains("@"))
                        {
                            sqlCommand.Parameters.AddWithValue(item, parameter[j]);
                            j++;
                        }
                    }
                }
                i = sqlCommand.ExecuteNonQuery();
                SQLconnection.Close();
            }
            return i;
        }
    }
}
