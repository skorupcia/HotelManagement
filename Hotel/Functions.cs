using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Hotel
{
    internal class Functions
    {
        private SqlConnection Con;
        private SqlCommand Cmd;
        private DataTable dt;
        private SqlDataAdapter Sda;
        private string ConStr;

        public Functions()
        {
            string relativePath = @"..\..\Hotel.mdf";
            string projectFolder = AppDomain.CurrentDomain.BaseDirectory;
            string absolutePath = Path.GetFullPath(Path.Combine(projectFolder, relativePath));

            //When relative path is not working, adjust path and use this:
            //ConStr = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\source\repos\Hotel\Hotel\Hotel.mdf;Integrated Security=True;Connect Timeout=30";
            
            ConStr = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={absolutePath};Integrated Security=True;Connect Timeout=30";
            Con = new SqlConnection(ConStr);
            Cmd = new SqlCommand();
            Cmd.Connection = Con;
        }

        public DataTable GetData(string Query)
        {
            dt = new DataTable();
            Sda = new SqlDataAdapter(Query, Con);
            Sda.Fill(dt);
            return dt;
        }

        public int SetData(String Query)
        {
            int Cnt = 0;
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            Cmd.CommandText = Query;
            Cnt = Cmd.ExecuteNonQuery();
            Con.Close();
            return Cnt;
        }
    }
}
