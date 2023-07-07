using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace DBConnect
{
    internal class Customer<T> : StoreManagement
    {
        SqlConnection conn;
        SqlDataAdapter cda;
        DataSet cds;

        public void OpenConn()
        {
            string cnnstr = "data source=LAPTOP-BMALL679\\SQLEXPRESS;Initial catalog=StoreManagement;integrated security=SSPI";
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
        public void ProductDb()
        {
            OpenConn();
            bool exit = false;
            while (exit != true)
            {
                Console.WriteLine("1. Display products \t 2.buy \t3.bill \t 4.exit");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        OpenConn();
                        cda = new SqlDataAdapter("select * from ProductData", conn);
                        cds = new DataSet();
                        cda.Fill(cds, "pd");
                        foreach (DataRow drow in cds.Tables["pd"].Rows)
                        {
                            Console.WriteLine(drow["product_id"].ToString() + "  " + drow["product_name"].ToString() + "  " + drow["quantity_available"] + "  " + drow["cost"]);

                        }
                        conn.Close();
                        break;

                    case 2:

                        Console.WriteLine("Enter the Customer id");
                        int cus_id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the customer name");
                        string cus_name = Console.ReadLine();
                        Console.WriteLine("Enter the phone number");
                        int phne = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the emailid");
                        string emil = Console.ReadLine();
                        InsertRecord(cus_id, cus_name, phne, emil);
                        Console.WriteLine("enter the product id to buy");
                        string pdid = Console.ReadLine();
                        Console.WriteLine("enter the quantity");
                        int pdqn = Convert.ToInt32(Console.ReadLine());
                        string query = string.Format("select cost from ProductData where product_id='" + pdid + "'");
                        cda = new SqlDataAdapter(query, conn);
                        cds  = new DataSet();
                        cda.Fill(cds, "Products");
                        decimal cost = 0;
                        foreach (DataRow drow in cds.Tables["Products"].Rows)
                        {
                            cost = (decimal)drow["cost"];
                        }
                        decimal total = cost * pdqn;


                        //Console.WriteLine(cost);
                        PrdTble(cus_id, pdid, pdqn, total);

                        bool exits = false;
                        while (exits != true)
                        {
                            Console.WriteLine("BUY 1. NEW PRODUCT \t 2.BILL\t 3.EXIT");
                            int chse = Convert.ToInt32(Console.ReadLine());
                            switch (chse)
                            {
                                case 1:
                                    Console.WriteLine("enter the product id to buy");
                                    string pdids = Console.ReadLine();
                                    Console.WriteLine("enter the quantity");
                                    int pdqns = Convert.ToInt32(Console.ReadLine());
                                    string query1 = string.Format("select cost from ProductData where product_id='" + pdids + "'");
                                    cda = new SqlDataAdapter(query1, conn);
                                    cds = new DataSet();
                                    cda.Fill(cds, "Products");
                                    decimal cost1 = 0;
                                    foreach (DataRow drow in cds.Tables["Products"].Rows)
                                    {
                                        cost1 = (decimal)drow["cost"];
                                    }
                                    decimal total1 = cost1 * pdqns;
                                    PrdTble(cus_id, pdids, pdqns, total1);
                                    //exits = true;
                                    break;
                                case 2:
                                    Bill();
                                    break;
                                case 3:
                                    exits = true;
                                    break;
                                default:
                                    Console.WriteLine("Give proper value");
                                    exits = true;
                                    break;
                            }
                        }
                        break;
                    case 3:


                    case 4:
                        exit = true;
                        break;


                    default:
                        Console.WriteLine("Give proper value");
                        exit = true;
                        break;
                }
            }
        }
        public void InsertRecord(int customer_id, string customer_name, int phone, string email)
        {
            cda = new SqlDataAdapter("select * from Customer", conn);
            cds = new DataSet();
            cda.Fill(cds, "csd");
            SqlCommandBuilder scb = new SqlCommandBuilder(cda);
            DataRow cdrow = cds.Tables["csd"].NewRow();
            cdrow[0] = customer_id; cdrow[1] = customer_name; cdrow[2] = phone; cdrow[3] = email;
            cds.Tables["csd"].Rows.Add(cdrow);
            cda.Update(cds, "csd");
            Console.WriteLine("Inserted customer");
        }
        public void PrdTble(int customer_id, string prodctid, int productQuantity, decimal total)
        {
            cda = new SqlDataAdapter("select * from CustomerProd", conn);
            cds = new DataSet();
            cda.Fill(cds, "csd");
            SqlCommandBuilder scb = new SqlCommandBuilder(cda);
            DataRow cdrow = cds.Tables["csd"].NewRow();
            cdrow[0] = customer_id; cdrow[1] = prodctid; cdrow[2] = productQuantity; cdrow[3] = total;
            cds.Tables["csd"].Rows.Add(cdrow);
            cda.Update(cds, "csd");
            Console.WriteLine("Inserted customer bill");
        }
        public void Bill()
        {

        }
    }
}
