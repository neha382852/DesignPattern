using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern1
{
    class SqlRepository : IRepository
    {
        public void AddRecord(IProduct product, int price)
        {
            Logger.Instance.AppendToLogFile("----In AddRecord() of SqlRepository Class---- ");
            Logger.Instance.AppendToLogFile("Adding" + product.ProductType + "details to the MYSQL database.");
            SqlConnection connectionobject = new SqlConnection();
            connectionobject.ConnectionString = "Data Source=TAVDESK045;Initial Catalog=Products;User ID=sa;Password=test123!@#";
            connectionobject.Open();
            string query = "insert into " + product.ProductType + " values(@Name,@Price,@isBooked)";
            SqlCommand cmd = new SqlCommand(query, connectionobject);
            cmd.Parameters.Add(new SqlParameter("@Name", product.ProductName));
            cmd.Parameters.Add(new SqlParameter("@Price", price));
            cmd.Parameters.Add(new SqlParameter("@isBooked", product.IsBooked));
            cmd.ExecuteNonQuery();
            connectionobject.Close();
        }
    }
}