using System;
using System.Data;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnect
{
    internal class DB
    {
        SqlConnection conn;

        public DB()
        {
            conn = null;
        }
        public void OpenConn(string cnnstr)
        {
            ConfigurationManager.RefreshSection("connectionStrings");
            //conn = new SqlConnection("data source=LAPTOP-BMALL679\\SQLEXPRESS;" + "database=student;" + "integrated security=SSPI");
            conn = new SqlConnection(cnnstr);
            try
            {
                
                conn.Open();
                Console.WriteLine("Connection Established");
            }
            catch(SqlException ex)
            {
                Console.WriteLine("Connection not established");
            }  
        }
        public void CreateTable()
        {
            SqlCommand cmd = new SqlCommand("create table stud_details (rno int, name nvarchar(20))", conn);
            if (conn != null)
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table created");
            }
        }

        public void InsertTable()
        {
            SqlCommand cmd = new SqlCommand("insert into stud_details values (103, 'Hari'),(104, 'ABC')", conn);
            if (conn!=null)
            {
                int cou = cmd.ExecuteNonQuery();
                Console.WriteLine(cou + " Row inserted");
            }
        }

        public void UpdateTable()
        {
            SqlCommand cmd = new SqlCommand("update stud_details set name='Raghul' where rno=103", conn);
            if (conn!=null)
            {
                int cou = cmd.ExecuteNonQuery();
                Console.WriteLine(cou + " Table Updated");
            }
        }

        public void DeleteTable() 
        {
            SqlCommand cmd = new SqlCommand("delete from stud_details", conn);
            if (conn!=null)
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Row Deleted");
            }
        }

        public void ReadTable()
        {
            SqlCommand cmd = new SqlCommand("select * from stud_details", conn);
            SqlDataReader sdr;
            if (conn != null)
            {
                sdr = cmd.ExecuteReader();
                if (!sdr.HasRows)
                {
                    Console.WriteLine("Dataset is empty");
                }
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["rno"] + " " + sdr["name"]);
                }
            }
        }

        public void CountOfStud()
        {
            SqlCommand cmd = new SqlCommand("select count(*) from stud_details", conn);
            object res = cmd.ExecuteScalar();
            if(res != null)
            {
                Console.WriteLine(res.ToString());
            }
        }

        public void FetchStudDetails()
        {
            SqlCommand cmd = new SqlCommand("[dbo].usp_readStudet", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter parameter;
            parameter = cmd.Parameters.Add("@rollno", SqlDbType.Int);
            parameter.Value = 10;

            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                Console.WriteLine(sdr["rno"] + " " + sdr["name"]);
            }
        }
        public void CloseConn()
        {
            if (conn!=null)
            {
                conn.Close();
            }
        }
    }
}
