using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
      }

      private void btnWithdrawAddProductForSale_Click(object sender, MouseEventArgs e)
      {
         hideMenuButtons("withdraw a product from sale or make a product available for sale");
         MessageBox.Show("MUST ADD CODE TO CHANGE VIEW IAW STORYBOARD");
      }

      private void btnViewOrEditProductDetails_Click(object sender, MouseEventArgs e)
      {
         hideMenuButtons("view or edit product details");
         MessageBox.Show("MUST ADD CODE TO CHANGE VIEW IAW STORYBOARD");
      }

      private void btnAddNewProductForSale_Click(object sender, MouseEventArgs e)
      {
         hideMenuButtons("add new product for sale");
         MessageBox.Show("MUST ADD CODE TO CHANGE VIEW IAW STORYBOARD");
      }

      private void btnViewStockLevels_Click(object sender, MouseEventArgs e)
      {
         hideMenuButtons("view currect stock levels");
         MessageBox.Show("MUST ADD CODE TO VIEW CURRENT STOCK LEVELS");
      }

      private void btnOrderStockReport_Click(object sender, MouseEventArgs e)
      {
         hideMenuButtons("list of products currently below the minimum stock number");
         MessageBox.Show("MUST ADD CODE TO CHANGE VIEW IAW STORYBOARD");
      }

      private void btnViewStockForSale_Click(object sender, MouseEventArgs e)
      {
         hideMenuButtons("view all products available for sale");
         MessageBox.Show("MUST ADD CODE TO CHANGE VIEW IAW STORYBOARD");
      }

      private void btnViewProductsNotForSale_Click(object sender, MouseEventArgs e)
      {
         hideMenuButtons("view all products not available for sale");
         MessageBox.Show("MUST ADD CODE TO CHANGE VIEW IAW STORYBOARD");
      }

      private void btnStartPage_Click(object sender, MouseEventArgs e)
      {
         resetToStartPage();
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
         lblMainAdminView.Text = "Current Stock Levels";
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
      }
   }
}
