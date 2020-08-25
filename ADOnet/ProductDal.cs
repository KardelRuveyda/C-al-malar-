using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOnet
{
   public class ProductDal
    {
        public DataTable GetAll2()
        {
            SqlConnection sqlConnection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ETradeWork; integrated security=true");

            if(sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Products",sqlConnection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            DataTable dataTable = new DataTable();

            dataTable.Load(sqlDataReader);

            sqlDataReader.Close();
            sqlConnection.Close();

            return dataTable;
        }

        public List<Product> GetAll()
        {
            SqlConnection sqlConnection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ETradeWork; integrated security=true");

            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Products", sqlConnection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            List<Product> products = new List<Product>();

            while (sqlDataReader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(sqlDataReader["Id"]),
                    Name =Convert.ToString(sqlDataReader["Name"]),
                    UnitPrice = Convert.ToDecimal(sqlDataReader["UnitPrice"]),
                    StockAmount = Convert.ToInt32(sqlDataReader["StockAmount"])
                };
                products.Add(product);
            }

            sqlDataReader.Close();
            sqlConnection.Close();

            return products;
        }
    }
}
