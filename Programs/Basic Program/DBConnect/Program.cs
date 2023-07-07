using DBConnect;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;

class Program:ConfigurationSection
{
    
    public static void Main(string[] args)
    {
        // Console.WriteLine(ConfigurationManager.AppSettings["num1"]);
        // Console.WriteLine(ConfigurationManager.AppSettings["num2"]);

        //string cnnstr = ConfigurationManager.ConnectionStrings["SQLStudentDB"].ConnectionString;
        //DB db = new DB();
        //db.OpenConn(cnnstr.ToString());

        /*
        DB db = new DB();
        //db.CreateTable();
        db.OpenConn();
        //db.InsertTable();
        //db.UpdateTable();
        db.DeleteTable();
        db.ReadTable();
        db.CloseConn();
        */
        /*
        StringBuilder cnnstr = new StringBuilder("data source=");
        Console.WriteLine("Enter Data Source");
        cnnstr.Append(Console.ReadLine());
        cnnstr.Append(";Initial Catalog=");

        Console.WriteLine("Enter Database name");
        cnnstr.Append(Console.ReadLine());

        cnnstr.Append(";Integrated Security=SSPI;");
        Console.WriteLine(cnnstr);
        DB db = new DB();
        db.OpenConn(cnnstr.ToString());
        

        //DBDisconnected dbd = new DBDisconnected();
        //dbd.OpenConn();
        //dbd.ReadData();
        //dbd.InsertRecord(104);
        //dbd.UpdateRecord(2);
        //dbd.DeleteRecord(104);

        string cnnstr = ConfigurationManager.ConnectionStrings["SQLStudentDB"].ConnectionString;
        DB db = new DB();
        db.OpenConn(cnnstr.ToString());
        //db.InsertTable();
        //db.UpdateTable();
        //db.CountOfStud();
        db.FetchStudDetails();
         */

        //DBDisconnectedAssign dbd = new DBDisconnectedAssign();
        //dbd.OpenConn();
        //dbd.NodesPerRegion();
        //dbd.CustomerPerRegion();
        //dbd.AverageAmount();
        //dbd.ClosingBalance();
        //dbd.IncreasedClosingBalance();

        StoreManagement sm = new StoreManagement();
        sm.Login();
    }

}

