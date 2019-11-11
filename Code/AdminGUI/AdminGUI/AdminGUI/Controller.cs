using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminGUI
{



   public class Controller
   {
      private SqlConnection conn;
      public Controller()
      {
         setupConnection();
      }
      public void updateProductForSaleById(String[] productDetails)
      {
         openConnection();
         SqlCommand cmd = new SqlCommand("EditProduct", conn);
         cmd.CommandType = CommandType.StoredProcedure;
         cmd.Parameters.AddWithValue("@CatName", productDetails[0]);
         cmd.Parameters.AddWithValue("@ProdName", productDetails[1]);
         cmd.Parameters.AddWithValue("@OnSale", productDetails[2]);
         cmd.Parameters.AddWithValue("@ProdDescription", productDetails[3]);
         cmd.Parameters.AddWithValue("@ProdQuantity", productDetails[4]);
         cmd.Parameters.AddWithValue("@MinStock", productDetails[5]);
         cmd.Parameters.AddWithValue("@PictFilePath", productDetails[6]);
         cmd.Parameters.AddWithValue("@RetPrice", productDetails[7]);
         cmd.Parameters.AddWithValue("@id", productDetails[8]);
         cmd.ExecuteReader();
         closeConnection();
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
         closeConnection();
      }
      public String viewStockNotForSale()
      {
         openConnection();
         SqlCommand command;
         SqlDataReader datareader;
         String sql, Output = "";
         sql = "SELECT * FROM ViewAllProductsNotForSale";
         command = new SqlCommand(sql, conn);
         datareader = command.ExecuteReader();
         while (datareader.Read())
         {
            Output = Output +
               datareader.GetValue(0) + " , " +
               datareader.GetValue(1) + " , " +
               datareader.GetValue(2) + " , " +
               datareader.GetValue(3) + " , " +
               datareader.GetValue(4) + " , " +
               datareader.GetValue(5) + " , " +
               datareader.GetValue(6) + " , " +
               datareader.GetValue(7) + " , " +
               datareader.GetValue(8) + " : ";
         }
         Output = Output.Substring(0, Output.Length - 2);
         closeConnection();
         return Output;
      }
      public String viewStockForSale()
      {
         openConnection();
         SqlCommand command;
         SqlDataReader datareader;
         String sql, Output = "";
         sql = "SELECT * FROM ViewAllProductsForSale";
         command = new SqlCommand(sql, conn);
         datareader = command.ExecuteReader();
         while (datareader.Read())
         {
            Output = Output +
               datareader.GetValue(0) + " , " +
               datareader.GetValue(1) + " , " +
               datareader.GetValue(2) + " , " +
               datareader.GetValue(3) + " , " +
               datareader.GetValue(4) + " , " +
               datareader.GetValue(5) + " , " +
               datareader.GetValue(6) + " , " +
               datareader.GetValue(7) + " , " +
               datareader.GetValue(8) + " : ";
         }
         Output = Output.Substring(0, Output.Length - 2);
         closeConnection();
         return Output;
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

