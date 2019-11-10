using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminGUI
{
   


   public class Controller
   {
      private SqlConnection conn;
      public Controller()
      {
         setupConnection();
      }
      public void AddNewProductForSale(String[] productDetails)
      {
         
         openConnection();
         SqlCommand cmd = new SqlCommand("AddNewProductAllDetails", conn);
         cmd.CommandType = CommandType.StoredProcedure;
         cmd.Parameters.AddWithValue("@CatName", productDetails[0]);
         cmd.Parameters.AddWithValue("@ProdName", productDetails[1]);
         cmd.Parameters.AddWithValue("@OnSale", productDetails[2]);
         cmd.Parameters.AddWithValue("@ProdDescription", productDetails[3]);
         cmd.Parameters.AddWithValue("@ProdQuantity", productDetails[4]);
         cmd.Parameters.AddWithValue("@MinStock", productDetails[5]);
         cmd.Parameters.AddWithValue("@PictFilePath", productDetails[6]);
         cmd.Parameters.AddWithValue("@RetPrice", productDetails[7]);
         cmd.ExecuteReader();
      }
      public List<List<string>> viewStockForSale()
      {
         List<List<string>> results = new List<List<string>>();
         int count = 0;
         openConnection();
         SqlCommand cmd = new SqlCommand("SELECT * FROM ViewAllProductsForSale", conn);
         cmd.CommandType = CommandType.Text;
         //using (SqlDataReader rdr = cmd.ExecuteReader())
         //{
         //   // iterate through results, printing each to console
         //   while (rdr.Read())
         //   {
         //      results[count][0] = rdr["Id"].ToString();
         //      results[count][1] = rdr["Name"].ToString();
         //      results[count][2] = rdr["Quantity"].ToString();
         //      results[count][3] = rdr["MinimumStock"].ToString();
         //      results[count][4] = rdr["RetailPrice"].ToString();
         //      results[count][5] = rdr["CategoryName"].ToString();
         //      count++;
         //   }
         //}
         //closeConnection();
         return results;
      }
      public void testprocedure()
      {
         openConnection();
         SqlCommand cmd = new SqlCommand("GetAllProductsForSale", conn);
         cmd.CommandType = CommandType.StoredProcedure;
         using (SqlDataReader rdr = cmd.ExecuteReader())
         {
            // iterate through results, printing each to console
            while (rdr.Read())
            {
               Console.WriteLine("Product: {0,-35} Total: {1,2}", rdr["Name"], rdr["Id"]);
            }
         }
         closeConnection();
      }
      private void openConnection()
      {
         conn.Open();
      }
      private void closeConnection()
      {
         conn.Close();
      }
      private void setupConnection()
      {
         conn = new SqlConnection(
            "###");
      }
   }
   
}
