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

      ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
      /////////////////////////////// THIS DOESNT WORK ATM //////////////////////////////////////////////////////////////////////
      public string searchForProductByPartialId(string partialId)
      {
         return searchForProducts(partialId, "SearchForProductByIdLikness", "@id");
      }
      /////////////////////////////// THIS DOESNT WORK ATM //////////////////////////////////////////////////////////////////////
      ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

      /// <summary>
      /// Returns a string of zero to many products, dependant on the search results.
      /// A serch will be carried out using a wildcard to the right of the string.
      /// example:
      /// "ABC" would return "ABC", "ABCD" and "abcde"
      /// "ABC" would not return "AABC"or "babc"
      /// </summary>
      /// <param name="partialName"></param>
      /// <returns>string
      /// String construction: 
      /// each product is seperated by a colon. 
      /// each field of a product is seperated by a comma. 
      /// Fields are: Name, Id. 
      /// </returns>
      public string searchForProductByPartialName(string partialName)
      {
         return searchForProducts(partialName, "SearchForProductByNameLikness", "@name");
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
      /// <summary>
      /// Method to add a new product to stock.
      /// </summary>
      /// <param name="productDetails">Array 
      /// element[0] Category. 
      /// element[1] Product Name. 
      /// element[2] OnSale - 1 for yes, 2 for no. 
      /// element[3] Product description - upto 254 characters. 
      /// element[4] Product Quantity - must be numbers only. 
      /// element[5] Minimum Stock - must be numbers only. 
      /// element[6] File path for the product picture. 
      /// element[7] Retail price - must be in a currency format e.g. 1.99. 
      /// </param>
      public void AddNewProductForSale(string[] productDetails)
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

      /// <summary>
      /// Returns a String of all products that are NOT for sale.
      /// </summary>
      /// <returns>string
      /// String construction: 
      /// each product is seperated by a colon. 
      /// each field of a product is seperated by a comma. 
      /// Fields are: Name, ForSale, Description, Quantity, MinimumStock, NumberSold, PictureFilePath, RetailPrice, CategoryName. 
      /// </returns>
      public string viewStockNotForSale()
      {
         return getDataFromView("ViewAllProductsNotForSale");
      }

      /// <summary>
      /// Returns a String of all products that are for sale.
      /// </summary>
      /// <returns>string
      /// String construction: 
      /// each product is seperated by a colon. 
      /// each field of a product is seperated by a comma. 
      /// Fields are: Name, ForSale, Description, Quantity, MinimumStock, NumberSold, PictureFilePath, RetailPrice, CategoryName. 
      /// </returns>
      public string viewStockForSale()
      {
         return getDataFromView("ViewAllProductsForSale");
      }

      /// <summary>
      /// Returns a string of all products which have the current stock levels below thier minimum stock levels
      /// </summary>
      /// <returns>string
      /// String construction: 
      /// each product is seperated by a colon. 
      /// each field of a product is seperated by a comma. 
      /// Fields are: Name, Quantity, MinimumStock. 
      /// </returns>
      public string CurrentStockUnderMinimumOrderAmount()
      {
         return getDataFromView("ViewAllProductsBelowMinimumStockLevels");
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

