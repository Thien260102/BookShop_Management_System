using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop_Management.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return instance; }
            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }

        private string connectionSTR = "Data Source=MSI;Initial Catalog=QLNS;Integrated Security=True";

        // trả về dữ liệu
        public DataTable ExecuteQuery(string query, object[] parameter = null) 
        {
            DataTable data = new DataTable();

            using(SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);


                if(parameter != null)
                {
                    string[] listPara = query.Split(' ');

                    int i = 0;
                    foreach (string item in listPara)
                        if (item.Contains('@'))
                            command.Parameters.AddWithValue(item, parameter[i++]);
                    

                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        // trả về số dòng thành công
        public int ExecuteNonQuery(string query, object[] parameter = null) 
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);


                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');

                    int i = 0;
                    foreach (string item in listPara)
                        if (item.Contains('@'))
                            command.Parameters.AddWithValue(item, parameter[i++]);


                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }

            return data;
        }

        //để sử dụng cho câu lệnh select count(*)
        public object ExecuteScalar(string query, object[] parameter = null) 
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);


                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');

                    int i = 0;
                    foreach (string item in listPara)
                        if (item.Contains('@'))
                            command.Parameters.AddWithValue(item, parameter[i++]);


                }

                data = command.ExecuteScalar();

                connection.Close();
            }

            return data;
        }

    }
}
