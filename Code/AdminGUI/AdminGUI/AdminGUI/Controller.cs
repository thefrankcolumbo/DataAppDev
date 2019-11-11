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
      public string searchForProductByPartialId(string partialId)
      {
         return searchForProducts(partialId, "SearchForProductByIdLikness", "@id");
      }
      public string searchForProductByPartialName(string partialName)
      {
         return searchForProducts(partialName, "SearchForProductByNameLikness", "@name");
      }
      private string searchForProducts(string partialString, string storedProcedure, string field)
      {
         string Output = "";
         openConnection();
         SqlCommand cmd = new SqlCommand(storedProcedure, conn);
         cmd.CommandType = CommandType.StoredProcedure;
         cmd.Parameters.AddWithValue(field, partialString);
         SqlDataReader datareader = cmd.ExecuteReader();
         while (datareader.Read())
         {
            for (int count = 0; count < datareader.FieldCount; count++)
            {
               Output += datareader.GetValue(count) + " ,";
            }
            Output = Output.Substring(0, Output.Length - 1);
            Output = Output + ":";
         }
         closeConnection();
         if (Output != "") Output = Output.Substring(0, Output.Length - 1);
         return Output;
      }
      public void updateProductForSaleById(string[] productDetails)
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
      public string viewStockNotForSale()
      {
         return getDataFromView("ViewAllProductsNotForSale");
      }
      public string viewStockForSale()
      {
         return getDataFromView("ViewAllProductsForSale");
      }
      public string CurrentStockUnderMinimumOrderAmount()
      {
         return getDataFromView("ViewAllProductsBelowMinimumStockLevels");
      }
      private string getDataFromView(string view)
      {
         openConnection();
         SqlCommand command;
         SqlDataReader datareader;
         string sql, Output = "";
         sql = "SELECT * FROM " + view;
         command = new SqlCommand(sql, conn);
         datareader = command.ExecuteReader();
         while (datareader.Read())
         {
            for(int count = 0; count < datareader.FieldCount; count++)
            {
               Output = Output + datareader.GetValue(count) + " ,";
            }
            Output = Output.Substring(0, Output.Length - 1);
            Output = Output + ":";
         }
         closeConnection();
         return Output;
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

