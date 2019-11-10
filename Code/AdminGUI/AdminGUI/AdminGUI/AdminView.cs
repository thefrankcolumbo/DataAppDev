using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AdminGUI
{
   public partial class AdminView : Form
   {
      public AdminView()
      {
         InitializeComponent();
         getOpenOrders();
         resetToStartPage();
         //using (SqlConnection conn = new SqlConnection("###"))
         //{

         //   conn.Open();
         //   SqlCommand cmd = new SqlCommand("GetAllProductsForSale", conn);
         //   cmd.CommandType = CommandType.StoredProcedure;
         //   using (SqlDataReader rdr = cmd.ExecuteReader())
         //   {
         //      // iterate through results, printing each to console
         //      while (rdr.Read())
         //      {
         //         Console.WriteLine("Product: {0,-35} Total: {1,2}", rdr["Name"], rdr["Id"]);
         //      }
         //   }
         //}
      }

      private void btnWithdrawAddProductForSale_Click(object sender, MouseEventArgs e)
      {
         //1. change button / panel visability to suit required admin function
         hideMenuButtons("Make a product for sale or not for sale");
         //2. open the search panel
         enableSearchPanel();
         //3. admin has used search panel to select a product from the DB
         MessageBox.Show("SEARCH PANEL FUNCTIONALITY REQUIRED WITH RETURN OBJECT");
         //4. display product results in text boxes
         setPnlViewingProductFieldsFromDatabase();
         //5. set required text boxes to non read only
         // not required
         //6. set action button text
         setPnlViewingProductActionBtnText("DEPENDS ON 0 or 1 ForSale");
         //7. if action button press DB updated
         MessageBox.Show("NEED TO CODE FOR BTN ACTION ON FOR SALE CHANGE");
      }

      private void btnViewOrEditProductDetails_Click(object sender, MouseEventArgs e)
      {
         //1. change button / panel visability to suit required admin function
         hideMenuButtons("view or edit product details");
         //2. open the search panel
         enableSearchPanel();
         //3. admin has used search panel to select a product from the DB
         MessageBox.Show("SEARCH PANEL FUNCTIONALITY REQUIRED WITH RETURN OBJECT");
         //4. display product results in text boxes
         setPnlViewingProductFieldsFromDatabase();
         //5. set action button text
         setPnlViewingProductActionBtnText("Save changes");
         //6. set required text boxes to non read only
         setPnlViewingProductFieldToNonReadOnlyForProductEdit();
         //7. if action button press DB updated
         MessageBox.Show("NEED TO CODE FOR BTN ACTION ON FOR SALE CHANGE");
      }

      private void btnAddNewProductForSale_Click(object sender, MouseEventArgs e)
      {
         //1. change button / panel visability to suit required admin function
         hideMenuButtons("add new product for sale");
         //2. set action button text
         setPnlViewingProductActionBtnText("Save changes");
         //3. set required text boxes to non read only
         setPnlViewingProductFieldToNonReadOnlyForProductEdit();
         //4. if action button press DB updated
         MessageBox.Show("NEED TO CODE FOR BTN ACTION ON FOR SALE CHANGE");
         //5. show edit product panel
         pnlViewingProduct.Visible = true;
      }

      private void btnViewStockLevels_Click(object sender, MouseEventArgs e)
      {
         //1. change button / panel visability to suit required admin function
         hideMenuButtons("view current stock levels");
         MessageBox.Show("MUST ADD CODE TO VIEW CURRENT STOCK LEVELS");
         getCurrentStockLevels();
         listVCurrentOpenOrders.Visible = true;
      }

      private void btnOrderStockReport_Click(object sender, MouseEventArgs e)
      {
         //1. change button / panel visability to suit required admin function
         hideMenuButtons("list of products currently below the minimum stock number");
         MessageBox.Show("MUST ADD CODE TO CHANGE VIEW IAW STORYBOARD");
         getCurrentStockUnderMinimumOrderAmount();
         listVCurrentOpenOrders.Visible = true;
      }

      private void btnViewStockForSale_Click(object sender, MouseEventArgs e)
      {
         //1. change button / panel visability to suit required admin function
         hideMenuButtons("view all products available for sale");
         MessageBox.Show("MUST ADD CODE TO CHANGE VIEW IAW STORYBOARD");
         getCurrentStockMarkedAsForSale();
         listVCurrentOpenOrders.Visible = true;
      }

      private void btnViewProductsNotForSale_Click(object sender, MouseEventArgs e)
      {
         //1. change button / panel visability to suit required admin function
         hideMenuButtons("view all products not available for sale");
         MessageBox.Show("MUST ADD CODE TO CHANGE VIEW IAW STORYBOARD");
         getCurrentStockMarkedAsNotForSale();
         listVCurrentOpenOrders.Visible = true;
      }

      private void btnStartPage_Click(object sender, MouseEventArgs e)
      {
         resetToStartPage();
      }
      private void enableSearchPanel()
      {
         pnlSearchPanel.Visible = true;
         lblSearchTitleLabel.Visible = true;
         MessageBox.Show("MUST ADD CODE ENABLE SEARCH AND FILL LIST BOX. ON USER " +
            "SELECTION PRODUCT DETAILS MUST APPEAR ON OTHER PANEL");
         populateListBox();
      }
      private void populateListBox()
      {
         // Shutdown the painting of the ListBox as items are added.
         listBoxSearchPanel.BeginUpdate();

         // Loop through and add 50 items to the ListBox.
         for (int x = 1; x <= 30; x++)
         {
            listBoxSearchPanel.Items.Add(("Item {0}", x));

         }
         listBoxSearchPanel.EndUpdate();
      }
      private void listBoxSearchPanek_DoubleClick(object sender, EventArgs e)
      {
         // Gets the selected item and then gets all the details from the DB
         String blah = listBoxSearchPanel.SelectedItem.ToString();
         // holder method
         setPnlViewingProductFieldsFromDatabase();
         // make panel visable
         pnlViewingProduct.Visible = true;
      }
      private void resetToStartPage()
      {
         btnStartPage.Visible = false;
         btnWithdrawAddProductForSale.Visible = true;
         btnViewOrEditProductDetails.Visible = true;
         btnAddNewProductForSale.Visible = true;
         btnViewStockForSale.Visible = true;
         btnOrderStockReport.Visible = true;
         btnViewStockForSale.Visible = true;
         btnViewProductsNotForSale.Visible = true;
         btnViewStockLevels.Visible = true;
         lblMainAdminView.Text = "Current Open Orders";
         pnlSearchPanel.Visible = false;
         pnlSearchPanel.Visible = false;
         listVCurrentOpenOrders.Visible = true;
         lblSearchTitleLabel.Visible = false;
         listVCurrentOpenOrders.Visible = true;
         pnlViewingProduct.Visible = false;
         setPnlViewingProductAllFieldsToReadOnly();
      }
      private void hideMenuButtons(String mainAdminViewlbl)
      {
         btnStartPage.Visible = true;
         btnWithdrawAddProductForSale.Visible = false;
         btnViewOrEditProductDetails.Visible = false;
         btnAddNewProductForSale.Visible = false;
         btnViewStockForSale.Visible = false;
         btnOrderStockReport.Visible = false;
         btnViewStockForSale.Visible = false;
         btnViewProductsNotForSale.Visible = false;
         btnViewStockLevels.Visible = false;
         lblMainAdminView.Text = mainAdminViewlbl;
         listVCurrentOpenOrders.Visible = false;
      }
      private void setPnlViewingProductAllFieldsToReadOnly()
      {
         txtViewingProductDescription.ReadOnly = true;
         txtViewingProductForSale.ReadOnly = true;
         txtViewingProductProductCategory.ReadOnly = true;
         txtViewingProductProductMinStock.ReadOnly = true;
         txtViewingProductProductName.ReadOnly = true;
         txtViewingProductProductPrice.ReadOnly = true;
         txtViewingProductProductStock.ReadOnly = true;
         txtViewingProductProductID.ReadOnly = true;
         txtViewingProductNumberSold.ReadOnly = true;
      }
      private void setPnlViewingProductActionBtnText(String btnText)
      {
         btnViewingProductActionButton.Text = btnText;
      }
      private void setPnlViewingProductFieldToNonReadOnlyForProductEdit()
      {
         txtViewingProductDescription.ReadOnly = false;
         txtViewingProductForSale.ReadOnly = false;
         txtViewingProductProductCategory.ReadOnly = false;
         txtViewingProductProductMinStock.ReadOnly = false;
         txtViewingProductProductName.ReadOnly = false;
         txtViewingProductProductPrice.ReadOnly = false;
         txtViewingProductProductStock.ReadOnly = false;
      }
      private void setPnlViewingProductFieldsFromDatabase()
      {
         txtViewingProductDescription.Text = "pulled from database";
         txtViewingProductForSale.Text = "pulled from database";
         txtViewingProductProductCategory.Text = "pulled from database";
         txtViewingProductProductMinStock.Text = "pulled from database";
         txtViewingProductProductName.Text = "pulled from database";
         txtViewingProductProductPrice.Text = "pulled from database";
         txtViewingProductProductStock.Text = "pulled from database";
         txtViewingProductProductID.Text = "pulled from database";
         txtViewingProductNumberSold.Text = "pulled from database";
      }
      private void txtSearchPanelProductID_TextChange(object sender, EventArgs e)
      {

      }

      private void txtSearchPanelProductName_TextChange(object sender, EventArgs e)
      {

      }
      private void getOpenOrders()
      {
         listVCurrentOpenOrders.Items.Clear();
         listVCurrentOpenOrders.Items.Add("OpenOrders");
         listVCurrentOpenOrders.Items.Add("OpenOrders");
         listVCurrentOpenOrders.Items.Add("OpenOrders");
         listVCurrentOpenOrders.Items.Add("OpenOrders");
         listVCurrentOpenOrders.Items.Add("OpenOrders");
         listVCurrentOpenOrders.Items.Add("OpenOrders");
         listVCurrentOpenOrders.Items.Add("OpenOrders");
         listVCurrentOpenOrders.Items.Add("OpenOrders");
      }
      private void getCurrentStockLevels()
      {
         listVCurrentOpenOrders.Items.Clear();
         listVCurrentOpenOrders.Items.Add("CurrentStockLevel");
         listVCurrentOpenOrders.Items.Add("CurrentStockLevel");
         listVCurrentOpenOrders.Items.Add("CurrentStockLevel");
         listVCurrentOpenOrders.Items.Add("CurrentStockLevel");
         listVCurrentOpenOrders.Items.Add("CurrentStockLevel");
         listVCurrentOpenOrders.Items.Add("CurrentStockLevel");
         listVCurrentOpenOrders.Items.Add("CurrentStockLevel");
         listVCurrentOpenOrders.Items.Add("CurrentStockLevel");
         listVCurrentOpenOrders.Items.Add("CurrentStockLevel");
         listVCurrentOpenOrders.Items.Add("CurrentStockLevel");
         listVCurrentOpenOrders.Items.Add("CurrentStockLevel");
      }
      private void getCurrentStockUnderMinimumOrderAmount()
      {
         listVCurrentOpenOrders.Items.Clear();
         listVCurrentOpenOrders.Items.Add("CurrentStockUnderMinimumOrderAmount");
         listVCurrentOpenOrders.Items.Add("CurrentStockUnderMinimumOrderAmount");
         listVCurrentOpenOrders.Items.Add("CurrentStockUnderMinimumOrderAmount");
         listVCurrentOpenOrders.Items.Add("CurrentStockUnderMinimumOrderAmount");
         listVCurrentOpenOrders.Items.Add("CurrentStockUnderMinimumOrderAmount");
         listVCurrentOpenOrders.Items.Add("CurrentStockUnderMinimumOrderAmount");
         listVCurrentOpenOrders.Items.Add("CurrentStockUnderMinimumOrderAmount");
         listVCurrentOpenOrders.Items.Add("CurrentStockUnderMinimumOrderAmount");
         listVCurrentOpenOrders.Items.Add("CurrentStockUnderMinimumOrderAmount");
         listVCurrentOpenOrders.Items.Add("CurrentStockUnderMinimumOrderAmount");
      }
      private void getCurrentStockMarkedAsForSale()
      {
         listVCurrentOpenOrders.Items.Clear();
         listVCurrentOpenOrders.Items.Add("CurrentStockMarkedAsForSale");
         listVCurrentOpenOrders.Items.Add("CurrentStockMarkedAsForSale");
         listVCurrentOpenOrders.Items.Add("CurrentStockMarkedAsForSale");
         listVCurrentOpenOrders.Items.Add("CurrentStockMarkedAsForSale");
         listVCurrentOpenOrders.Items.Add("CurrentStockMarkedAsForSale");
         listVCurrentOpenOrders.Items.Add("CurrentStockMarkedAsForSale");
         listVCurrentOpenOrders.Items.Add("CurrentStockMarkedAsForSale");
         listVCurrentOpenOrders.Items.Add("CurrentStockMarkedAsForSale");
         listVCurrentOpenOrders.Items.Add("CurrentStockMarkedAsForSale");
         listVCurrentOpenOrders.Items.Add("CurrentStockMarkedAsForSale");
         listVCurrentOpenOrders.Items.Add("CurrentStockMarkedAsForSale");
      }
      private void getCurrentStockMarkedAsNotForSale()
      {
         listVCurrentOpenOrders.Items.Clear();
         listVCurrentOpenOrders.Items.Add("CurrentStockMarkedAsNotForSale");
         listVCurrentOpenOrders.Items.Add("CurrentStockMarkedAsNotForSale");
         listVCurrentOpenOrders.Items.Add("CurrentStockMarkedAsNotForSale");
         listVCurrentOpenOrders.Items.Add("CurrentStockMarkedAsNotForSale");
         listVCurrentOpenOrders.Items.Add("CurrentStockMarkedAsNotForSale");
         listVCurrentOpenOrders.Items.Add("CurrentStockMarkedAsNotForSale");
         listVCurrentOpenOrders.Items.Add("CurrentStockMarkedAsNotForSale");
         listVCurrentOpenOrders.Items.Add("CurrentStockMarkedAsNotForSale");
         listVCurrentOpenOrders.Items.Add("CurrentStockMarkedAsNotForSale");
         listVCurrentOpenOrders.Items.Add("CurrentStockMarkedAsNotForSale");
         listVCurrentOpenOrders.Items.Add("CurrentStockMarkedAsNotForSale");
         listVCurrentOpenOrders.Items.Add("CurrentStockMarkedAsNotForSale");
      }
      private void btnViewingProductActionButton_Click(object sender, EventArgs e)
      {
         resetToStartPage();
      }

      private void btnViewingProductCancelButton_Click(object sender, MouseEventArgs e)
      {
         resetToStartPage();
      }
      
     
   }
}
