using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_My_Version_DataAccessLayer
{
    public class clsUserDataAccesscs
    {
        public static bool CheckUserNameAndPassword(string Username, string Password)
        {
            string Query = "SELECT * FROM Users WHERE UserName = @Username AND Password = @Password";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.DataBaseInfos))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@Username", Username);
                    command.Parameters.AddWithValue("@Password", Password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            // يوجد مستخدم بالمعلومات
                            return true;
                        }
                        else
                        {
                            // لا يوجد مستخدم بهذه المعلومات
                            return false;
                        }
                    }
                }
            }
        }

        public static DataTable GetAllUsers()
        {
            string connectionString = clsDataAccessSettings.DataBaseInfos;
            string query = "SELECT * FROM Users"; // تأكد من اسم الجدول الصحيح

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable dtUsers = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dtUsers);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

                return dtUsers;
            }
        }

    }
}
