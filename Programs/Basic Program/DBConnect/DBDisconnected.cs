using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DBConnect
{
    internal class DBDisconnected
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;

        public void OpenConn()
        {
            string cnnstr = "data source=LAPTOP-BMALL679\\SQLEXPRESS;Initial catalog=student;integrated security=SSPI";
            conn = new SqlConnection(cnnstr);
            try
            {

                conn.Open();
                Console.WriteLine("Connection Established");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Connection not established");
            }
        }
        public void ReadData()
        {
            da = new SqlDataAdapter("select * from stud_details", conn);
            ds = new DataSet();
            da.Fill(ds, "sd");
            Console.WriteLine(ds.Tables["sd"].Columns[0].ColumnName);
            foreach(DataRow dr in ds.Tables["sd"].Rows)
            {
                Console.WriteLine(dr["name"].ToString() + dr["rno"]);
            }
            conn.Close();
        }
        public void InsertRecord(int rno)
        {
            SqlCommandBuilder scb = new SqlCommandBuilder(da);
            //int rno = 103; string nm = "CCC";
            ds.Tables["sd"].Columns["rno"].Unique = true;
            ds.Tables["sd"].Columns["name"].DefaultValue = "XXX";
            DataRow dr = ds.Tables["sd"].NewRow();
            dr[0] = rno;
            //dr[1] = nm;
            ds.Tables["sd"].Rows.Add(dr);
            da.Update(ds, "sd");
            Console.WriteLine("Inserted");
            conn.Close();
        }

        public void UpdateRecord(int rno)
        {
            SqlCommandBuilder scb = new SqlCommandBuilder(da);
            foreach (DataRow dr in ds.Tables["sd"].Rows)
            {
                if (Int32.Parse(dr["rno"].ToString())==rno)
                {
                    dr["name"] = "Aakash";
                    break;
                }
            }
            foreach (DataRow dr in ds.Tables["sd"].Rows)
            {
                Console.WriteLine(dr["name"].ToString() + dr["rno"]);
            }
            da.Update(ds, "sd");
            Console.WriteLine("Updated");
            conn.Close();
            
        }

        public void DeleteRecord(int rno) 
        {
            SqlCommandBuilder scb = new SqlCommandBuilder(da);
            foreach (DataRow dr in ds.Tables["sd"].Rows)
            {
                if (Int32.Parse(dr["rno"].ToString()) == rno)
                {
                    dr.Delete();
                    break;
                }
            }
            da.Update(ds, "sd");
            Console.WriteLine("Deleted");
            conn.Close();

        }
    }
}
