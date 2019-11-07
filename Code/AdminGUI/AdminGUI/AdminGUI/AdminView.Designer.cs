namespace AdminGUI
{
   partial class AdminView
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.btnWithdrawAddProductForSale = new System.Windows.Forms.Button();
         this.btnViewOrEditProductDetails = new System.Windows.Forms.Button();
         this.btnAddNewProductForSale = new System.Windows.Forms.Button();
         this.btnViewStockLevels = new System.Windows.Forms.Button();
         this.btnOrderStockReport = new System.Windows.Forms.Button();
         this.btnViewStockForSale = new System.Windows.Forms.Button();
         this.btnViewProductsNotForSale = new System.Windows.Forms.Button();
         this.pnlMainAdminView = new System.Windows.Forms.Panel();
         this.lblMainAdminView = new System.Windows.Forms.Label();
         this.btnStartPage = new System.Windows.Forms.Button();
         this.pnlSearchPanel = new System.Windows.Forms.Panel();
         this.lblSearchTitleLabel = new System.Windows.Forms.Label();
         this.lblSearchPanelProductID = new System.Windows.Forms.Label();
         this.txtSearchPanelProductID = new System.Windows.Forms.TextBox();
         this.lblSearchPanelProductName = new System.Windows.Forms.Label();
         this.txtSearchPanelProductName = new System.Windows.Forms.TextBox();
         this.listBoxSearchPanel = new System.Windows.Forms.ListBox();
         this.listVCurrentOpenOrders = new System.Windows.Forms.ListView();
         this.pnlMainAdminView.SuspendLayout();
         this.pnlSearchPanel.SuspendLayout();
         this.SuspendLayout();
         // 
         // btnWithdrawAddProductForSale
         // 
         this.btnWithdrawAddProductForSale.Location = new System.Drawing.Point(12, 222);
         this.btnWithdrawAddProductForSale.Name = "btnWithdrawAddProductForSale";
         this.btnWithdrawAddProductForSale.Size = new System.Drawing.Size(187, 23);
         this.btnWithdrawAddProductForSale.TabIndex = 0;
         this.btnWithdrawAddProductForSale.Text = "Withdraw or Add Product or Sale";
         this.btnWithdrawAddProductForSale.UseVisualStyleBackColor = true;
         this.btnWithdrawAddProductForSale.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnWithdrawAddProductForSale_Click);
         // 
         // btnViewOrEditProductDetails
         // 
         this.btnViewOrEditProductDetails.Location = new System.Drawing.Point(13, 43);
         this.btnViewOrEditProductDetails.Name = "btnViewOrEditProductDetails";
         this.btnViewOrEditProductDetails.Size = new System.Drawing.Size(187, 23);
         this.btnViewOrEditProductDetails.TabIndex = 1;
         this.btnViewOrEditProductDetails.Text = "View or Edit Product Details";
         this.btnViewOrEditProductDetails.UseVisualStyleBackColor = true;
         this.btnViewOrEditProductDetails.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnViewOrEditProductDetails_Click);
         // 
         // btnAddNewProductForSale
         // 
         this.btnAddNewProductForSale.Location = new System.Drawing.Point(13, 73);
         this.btnAddNewProductForSale.Name = "btnAddNewProductForSale";
         this.btnAddNewProductForSale.Size = new System.Drawing.Size(187, 23);
         this.btnAddNewProductForSale.TabIndex = 2;
         this.btnAddNewProductForSale.Text = "Add New Product For Sale";
         this.btnAddNewProductForSale.UseVisualStyleBackColor = true;
         this.btnAddNewProductForSale.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAddNewProductForSale_Click);
         // 
         // btnViewStockLevels
         // 
         this.btnViewStockLevels.Location = new System.Drawing.Point(13, 103);
         this.btnViewStockLevels.Name = "btnViewStockLevels";
         this.btnViewStockLevels.Size = new System.Drawing.Size(187, 23);
         this.btnViewStockLevels.TabIndex = 3;
         this.btnViewStockLevels.Text = "View Stock Levels";
         this.btnViewStockLevels.UseVisualStyleBackColor = true;
         this.btnViewStockLevels.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnViewStockLevels_Click);
         // 
         // btnOrderStockReport
         // 
         this.btnOrderStockReport.Location = new System.Drawing.Point(13, 133);
         this.btnOrderStockReport.Name = "btnOrderStockReport";
         this.btnOrderStockReport.Size = new System.Drawing.Size(187, 23);
         this.btnOrderStockReport.TabIndex = 4;
         this.btnOrderStockReport.Text = "Order Stock Report";
         this.btnOrderStockReport.UseVisualStyleBackColor = true;
         this.btnOrderStockReport.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnOrderStockReport_Click);
         // 
         // btnViewStockForSale
         // 
         this.btnViewStockForSale.Location = new System.Drawing.Point(13, 163);
         this.btnViewStockForSale.Name = "btnViewStockForSale";
         this.btnViewStockForSale.Size = new System.Drawing.Size(187, 23);
         this.btnViewStockForSale.TabIndex = 5;
         this.btnViewStockForSale.Text = "View Stock For Sale";
         this.btnViewStockForSale.UseVisualStyleBackColor = true;
         this.btnViewStockForSale.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnViewStockForSale_Click);
         // 
         // btnViewProductsNotForSale
         // 
         this.btnViewProductsNotForSale.Location = new System.Drawing.Point(13, 193);
         this.btnViewProductsNotForSale.Name = "btnViewProductsNotForSale";
         this.btnViewProductsNotForSale.Size = new System.Drawing.Size(187, 23);
         this.btnViewProductsNotForSale.TabIndex = 6;
         this.btnViewProductsNotForSale.Text = "View Products Not For Sale";
         this.btnViewProductsNotForSale.UseVisualStyleBackColor = true;
         this.btnViewProductsNotForSale.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnViewProductsNotForSale_Click);
         // 
         // pnlMainAdminView
         // 
         this.pnlMainAdminView.BackColor = System.Drawing.SystemColors.ActiveBorder;
         this.pnlMainAdminView.Controls.Add(this.listVCurrentOpenOrders);
         this.pnlMainAdminView.Location = new System.Drawing.Point(231, 43);
         this.pnlMainAdminView.Name = "pnlMainAdminView";
         this.pnlMainAdminView.Size = new System.Drawing.Size(264, 473);
         this.pnlMainAdminView.TabIndex = 7;
         // 
         // lblMainAdminView
         // 
         this.lblMainAdminView.AutoSize = true;
         this.lblMainAdminView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.lblMainAdminView.Location = new System.Drawing.Point(231, 13);
         this.lblMainAdminView.Name = "lblMainAdminView";
         this.lblMainAdminView.Size = new System.Drawing.Size(106, 15);
         this.lblMainAdminView.TabIndex = 8;
         this.lblMainAdminView.Text = "Current Open Orders";
         // 
         // btnStartPage
         // 
         this.btnStartPage.Location = new System.Drawing.Point(13, 13);
         this.btnStartPage.Name = "btnStartPage";
         this.btnStartPage.Size = new System.Drawing.Size(187, 23);
         this.btnStartPage.TabIndex = 9;
         this.btnStartPage.Text = "Start Page";
         this.btnStartPage.UseVisualStyleBackColor = true;
         this.btnStartPage.Visible = false;
         this.btnStartPage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnStartPage_Click);
         // 
         // pnlSearchPanel
         // 
         this.pnlSearchPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
         this.pnlSearchPanel.Controls.Add(this.listBoxSearchPanel);
         this.pnlSearchPanel.Controls.Add(this.txtSearchPanelProductName);
         this.pnlSearchPanel.Controls.Add(this.lblSearchPanelProductName);
         this.pnlSearchPanel.Controls.Add(this.txtSearchPanelProductID);
         this.pnlSearchPanel.Controls.Add(this.lblSearchPanelProductID);
         this.pnlSearchPanel.Location = new System.Drawing.Point(529, 43);
         this.pnlSearchPanel.Name = "pnlSearchPanel";
         this.pnlSearchPanel.Size = new System.Drawing.Size(270, 470);
         this.pnlSearchPanel.TabIndex = 10;
         this.pnlSearchPanel.Visible = false;
         // 
         // lblSearchTitleLabel
         // 
         this.lblSearchTitleLabel.AutoSize = true;
         this.lblSearchTitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.lblSearchTitleLabel.Location = new System.Drawing.Point(530, 15);
         this.lblSearchTitleLabel.Name = "lblSearchTitleLabel";
         this.lblSearchTitleLabel.Size = new System.Drawing.Size(64, 15);
         this.lblSearchTitleLabel.TabIndex = 0;
         this.lblSearchTitleLabel.Text = "Search Box";
         // 
         // lblSearchPanelProductID
         // 
         this.lblSearchPanelProductID.AutoSize = true;
         this.lblSearchPanelProductID.Location = new System.Drawing.Point(7, 21);
         this.lblSearchPanelProductID.Name = "lblSearchPanelProductID";
         this.lblSearchPanelProductID.Size = new System.Drawing.Size(58, 13);
         this.lblSearchPanelProductID.TabIndex = 1;
         this.lblSearchPanelProductID.Text = "Product ID";
         // 
         // txtSearchPanelProductID
         // 
         this.txtSearchPanelProductID.Location = new System.Drawing.Point(4, 38);
         this.txtSearchPanelProductID.Name = "txtSearchPanelProductID";
         this.txtSearchPanelProductID.Size = new System.Drawing.Size(179, 20);
         this.txtSearchPanelProductID.TabIndex = 2;
         this.txtSearchPanelProductID.TextChanged += new System.EventHandler(this.txtSearchPanelProductID_TextChange);
         // 
         // lblSearchPanelProductName
         // 
         this.lblSearchPanelProductName.AutoSize = true;
         this.lblSearchPanelProductName.Location = new System.Drawing.Point(4, 65);
         this.lblSearchPanelProductName.Name = "lblSearchPanelProductName";
         this.lblSearchPanelProductName.Size = new System.Drawing.Size(75, 13);
         this.lblSearchPanelProductName.TabIndex = 3;
         this.lblSearchPanelProductName.Text = "Product Name";
         // 
         // txtSearchPanelProductName
         // 
         this.txtSearchPanelProductName.Location = new System.Drawing.Point(4, 82);
         this.txtSearchPanelProductName.Name = "txtSearchPanelProductName";
         this.txtSearchPanelProductName.Size = new System.Drawing.Size(179, 20);
         this.txtSearchPanelProductName.TabIndex = 4;
         this.txtSearchPanelProductName.TextChanged += new System.EventHandler(this.txtSearchPanelProductName_TextChange);
         // 
         // listBoxSearchPanel
         // 
         this.listBoxSearchPanel.FormattingEnabled = true;
         this.listBoxSearchPanel.Location = new System.Drawing.Point(4, 109);
         this.listBoxSearchPanel.Name = "listBoxSearchPanel";
         this.listBoxSearchPanel.Size = new System.Drawing.Size(263, 355);
         this.listBoxSearchPanel.TabIndex = 5;
         // 
         // listVCurrentOpenOrders
         // 
         this.listVCurrentOpenOrders.HideSelection = false;
         this.listVCurrentOpenOrders.Location = new System.Drawing.Point(3, 3);
         this.listVCurrentOpenOrders.Name = "listVCurrentOpenOrders";
         this.listVCurrentOpenOrders.Size = new System.Drawing.Size(258, 467);
         this.listVCurrentOpenOrders.TabIndex = 0;
         this.listVCurrentOpenOrders.UseCompatibleStateImageBehavior = false;
         // 
         // AdminView
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(898, 528);
         this.Controls.Add(this.pnlSearchPanel);
         this.Controls.Add(this.btnStartPage);
         this.Controls.Add(this.lblMainAdminView);
         this.Controls.Add(this.pnlMainAdminView);
         this.Controls.Add(this.btnViewProductsNotForSale);
         this.Controls.Add(this.lblSearchTitleLabel);
         this.Controls.Add(this.btnViewStockForSale);
         this.Controls.Add(this.btnOrderStockReport);
         this.Controls.Add(this.btnViewStockLevels);
         this.Controls.Add(this.btnAddNewProductForSale);
         this.Controls.Add(this.btnViewOrEditProductDetails);
         this.Controls.Add(this.btnWithdrawAddProductForSale);
         this.Name = "AdminView";
         this.Text = "AdminView";
         this.pnlMainAdminView.ResumeLayout(false);
         this.pnlSearchPanel.ResumeLayout(false);
         this.pnlSearchPanel.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnWithdrawAddProductForSale;
      private System.Windows.Forms.Button btnViewOrEditProductDetails;
      private System.Windows.Forms.Button btnAddNewProductForSale;
      private System.Windows.Forms.Button btnViewStockLevels;
      private System.Windows.Forms.Button btnOrderStockReport;
      private System.Windows.Forms.Button btnViewStockForSale;
      private System.Windows.Forms.Button btnViewProductsNotForSale;
      private System.Windows.Forms.Panel pnlMainAdminView;
      private System.Windows.Forms.Label lblMainAdminView;
      private System.Windows.Forms.Button btnStartPage;
      private System.Windows.Forms.Panel pnlSearchPanel;
      private System.Windows.Forms.Label lblSearchTitleLabel;
      private System.Windows.Forms.ListBox listBoxSearchPanel;
      private System.Windows.Forms.TextBox txtSearchPanelProductName;
      private System.Windows.Forms.Label lblSearchPanelProductName;
      private System.Windows.Forms.TextBox txtSearchPanelProductID;
      private System.Windows.Forms.Label lblSearchPanelProductID;
      private System.Windows.Forms.ListView listVCurrentOpenOrders;
   }
}