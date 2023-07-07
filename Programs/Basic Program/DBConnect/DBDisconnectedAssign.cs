using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnect
{
    internal class DBDisconnectedAssign
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;

        public void OpenConn()
        {
            string cnnstr = "data source=LAPTOP-BMALL679\\SQLEXPRESS;Initial catalog=DataBank;integrated security=SSPI";
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

        string query1 = "select r.region_name, count( distinct node_id) node_counts from customer_nodes c inner join regions r on c.region_id=r.region_id group by r.region_name";
        public void NodesPerRegion()
        {
            da = new SqlDataAdapter(query1, conn);
            ds = new DataSet();
            da.Fill(ds, "sd");
            //Console.WriteLine("Region Name" + " " + "Node Counts");
            Console.WriteLine("Displaying the number of nodes per region");
            foreach (DataRow dr in ds.Tables["sd"].Rows)
            {
                Console.WriteLine(dr[0].ToString() + ":" + dr[1] + " nodes");
            }
            conn.Close();
        }

        string query2 = "select r.region_name, count(distinct c.customer_id) customer_counts from customer_nodes c inner join regions r on c.region_id=r.region_id group by r.region_name";

        public void CustomerPerRegion()
        {
            da = new SqlDataAdapter(query2, conn);
            ds = new DataSet();
            da.Fill(ds, "sd");
            Console.WriteLine("Displaying the number of customers allocated to each region");
            foreach (DataRow dr in ds.Tables["sd"].Rows)
            {
                Console.WriteLine(dr[0].ToString() + ":" + dr[1] + " customers");
            }
            conn.Close();
        }

        string query3 = "select count(*) Total_count , AVG(txn_amount) Average_amount from customer_transactions where txn_type='deposit'";

        public void AverageAmount()
        {
            da = new SqlDataAdapter(query3, conn);
            ds = new DataSet();
            da.Fill(ds, "sd");
            Console.WriteLine("Displaying the total count and average amount of deposits for all the customers");
            foreach (DataRow dr in ds.Tables["sd"].Rows)
            {
                Console.WriteLine("Total Count : " + dr[0].ToString() + "\n" +"Average Amount : " + dr[1]);
            }
            conn.Close();
        }

        string query4 = "WITH CTE as (SELECT customer_id, DATEPART(MONTH,txn_date) as month,SUM(CASE WHEN txn_type ='deposit' then txn_amount else 0 end) as deposit, SUM(CASE WHEN txn_type ='purchase' then -txn_amount else 0 end) as purchase , SUM(CASE WHEN txn_type ='withdrawal' then -txn_amount else 0 end)  as  withdrawal from customer_transactions GROUP BY customer_id,DATEPART(MONTH,txn_date)),CTE_2 AS (SELECT customer_id,month,(deposit +purchase +withdrawal) as total from CTE) SELECT customer_id, month, SUM(total) OVER (PARTITION BY customer_id ORDER BY customer_id,month  ROWS BETWEEN UNBOUNDED PRECEDING AND current ROW) AS balance FROM CTE_2";
        public void ClosingBalance()
        {
            da = new SqlDataAdapter(query4, conn);
            ds = new DataSet();
            da.Fill(ds, "sd");
            Console.WriteLine("Displaying the closing balance for each customer at the end of the month");
            Console.WriteLine("Customer_id, Month, Balance");
            foreach (DataRow dr in ds.Tables["sd"].Rows)
            {
                Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2]);
            }
            conn.Close();
        }

        string query5 = "WITH CTE as (SELECT customer_id, DATEPART(MONTH,txn_date) as month, SUM(CASE WHEN txn_type ='deposit' then txn_amount else 0 end) as deposit,SUM(CASE WHEN txn_type ='purchase' then -txn_amount else 0 end) as purchase ,SUM(CASE WHEN txn_type ='withdrawal' then -txn_amount else 0 end) as withdrawal from customer_transactions GROUP BY customer_id,DATEPART(MONTH,txn_date)),CTE_2 AS (SELECT customer_id,month,(deposit +purchase +withdrawal) as total from CTE) SELECT count(*) AS change_in_balance FROM CTE_2";
        public void IncreasedClosingBalance()
        {
            da = new SqlDataAdapter(query5, conn);
            ds = new DataSet();
            da.Fill(ds, "sd");
            Console.WriteLine("Displaying the number of customers who have increased their closing balance compared to the previous month.");
            foreach (DataRow dr in ds.Tables["sd"].Rows)
            {
                Console.WriteLine(dr[0]);
            }
            conn.Close();
        }

    }
}
