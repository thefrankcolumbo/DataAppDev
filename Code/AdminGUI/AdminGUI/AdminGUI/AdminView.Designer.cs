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
         this.pnlViewingProduct = new System.Windows.Forms.Panel();
         this.btnViewingProductCancelButton = new System.Windows.Forms.Button();
         this.btnViewingProductActionButton = new System.Windows.Forms.Button();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.lblViewingProductPicture = new System.Windows.Forms.Label();
         this.txtViewingProductDescription = new System.Windows.Forms.TextBox();
         this.lblViewingProductDescription = new System.Windows.Forms.Label();
         this.txtViewingProductNumberSold = new System.Windows.Forms.TextBox();
         this.lblViewingProductNumberSold = new System.Windows.Forms.Label();
         this.txtViewingProductForSale = new System.Windows.Forms.TextBox();
         this.lblViewingProductForSale = new System.Windows.Forms.Label();
         this.txtViewingProductProductStock = new System.Windows.Forms.TextBox();
         this.lblViewingProductProductStock = new System.Windows.Forms.Label();
         this.txtViewingProductProductCategory = new System.Windows.Forms.TextBox();
         this.lblViewingProductProductCategory = new System.Windows.Forms.Label();
         this.txtViewingProductProductMinStock = new System.Windows.Forms.TextBox();
         this.lblViewingProductProductMinStock = new System.Windows.Forms.Label();
         this.txtViewingProductProductPrice = new System.Windows.Forms.TextBox();
         this.lblViewingProductProductPrice = new System.Windows.Forms.Label();
         this.txtViewingProductProductID = new System.Windows.Forms.TextBox();
         this.lblViewingProductProductID = new System.Windows.Forms.Label();
         this.txtViewingProductProductName = new System.Windows.Forms.TextBox();
         this.lblViewingProductProductName = new System.Windows.Forms.Label();
         this.listVCurrentOpenOrders = new System.Windows.Forms.ListView();
         this.lblMainAdminView = new System.Windows.Forms.Label();
         this.btnStartPage = new System.Windows.Forms.Button();
         this.pnlSearchPanel = new System.Windows.Forms.Panel();
         this.listBoxSearchPanel = new System.Windows.Forms.ListBox();
         this.txtSearchPanelProductName = new System.Windows.Forms.TextBox();
         this.lblSearchPanelProductName = new System.Windows.Forms.Label();
         this.txtSearchPanelProductID = new System.Windows.Forms.TextBox();
         this.lblSearchPanelProductID = new System.Windows.Forms.Label();
         this.lblSearchTitleLabel = new System.Windows.Forms.Label();
         this.pnlMainAdminView.SuspendLayout();
         this.pnlViewingProduct.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
         this.pnlMainAdminView.Controls.Add(this.pnlViewingProduct);
         this.pnlMainAdminView.Controls.Add(this.listVCurrentOpenOrders);
         this.pnlMainAdminView.Location = new System.Drawing.Point(231, 43);
         this.pnlMainAdminView.Name = "pnlMainAdminView";
         this.pnlMainAdminView.Size = new System.Drawing.Size(264, 473);
         this.pnlMainAdminView.TabIndex = 7;
         // 
         // pnlViewingProduct
         // 
         this.pnlViewingProduct.Controls.Add(this.btnViewingProductCancelButton);
         this.pnlViewingProduct.Controls.Add(this.btnViewingProductActionButton);
         this.pnlViewingProduct.Controls.Add(this.pictureBox1);
         this.pnlViewingProduct.Controls.Add(this.lblViewingProductPicture);
         this.pnlViewingProduct.Controls.Add(this.txtViewingProductDescription);
         this.pnlViewingProduct.Controls.Add(this.lblViewingProductDescription);
         this.pnlViewingProduct.Controls.Add(this.txtViewingProductNumberSold);
         this.pnlViewingProduct.Controls.Add(this.lblViewingProductNumberSold);
         this.pnlViewingProduct.Controls.Add(this.txtViewingProductForSale);
         this.pnlViewingProduct.Controls.Add(this.lblViewingProductForSale);
         this.pnlViewingProduct.Controls.Add(this.txtViewingProductProductStock);
         this.pnlViewingProduct.Controls.Add(this.lblViewingProductProductStock);
         this.pnlViewingProduct.Controls.Add(this.txtViewingProductProductCategory);
         this.pnlViewingProduct.Controls.Add(this.lblViewingProductProductCategory);
         this.pnlViewingProduct.Controls.Add(this.txtViewingProductProductMinStock);
         this.pnlViewingProduct.Controls.Add(this.lblViewingProductProductMinStock);
         this.pnlViewingProduct.Controls.Add(this.txtViewingProductProductPrice);
         this.pnlViewingProduct.Controls.Add(this.lblViewingProductProductPrice);
         this.pnlViewingProduct.Controls.Add(this.txtViewingProductProductID);
         this.pnlViewingProduct.Controls.Add(this.lblViewingProductProductID);
         this.pnlViewingProduct.Controls.Add(this.txtViewingProductProductName);
         this.pnlViewingProduct.Controls.Add(this.lblViewingProductProductName);
         this.pnlViewingProduct.Location = new System.Drawing.Point(4, 3);
         this.pnlViewingProduct.Name = "pnlViewingProduct";
         this.pnlViewingProduct.Size = new System.Drawing.Size(257, 466);
         this.pnlViewingProduct.TabIndex = 1;
         // 
         // btnViewingProductCancelButton
         // 
         this.btnViewingProductCancelButton.Location = new System.Drawing.Point(12, 375);
         this.btnViewingProductCancelButton.Name = "btnViewingProductCancelButton";
         this.btnViewingProductCancelButton.Size = new System.Drawing.Size(231, 55);
         this.btnViewingProductCancelButton.TabIndex = 21;
         this.btnViewingProductCancelButton.Text = "Cancel";
         this.btnViewingProductCancelButton.UseVisualStyleBackColor = true;
         this.btnViewingProductCancelButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnViewingProductCancelButton_Click);
         // 
         // btnViewingProductActionButton
         // 
         this.btnViewingProductActionButton.Location = new System.Drawing.Point(12, 317);
         this.btnViewingProductActionButton.Name = "btnViewingProductActionButton";
         this.btnViewingProductActionButton.Size = new System.Drawing.Size(231, 51);
         this.btnViewingProductActionButton.TabIndex = 20;
         this.btnViewingProductActionButton.Text = "default";
         this.btnViewingProductActionButton.UseVisualStyleBackColor = true;
         this.btnViewingProductActionButton.Click += new System.EventHandler(this.btnViewingProductActionButton_Click);
         // 
         // pictureBox1
         // 
         this.pictureBox1.Location = new System.Drawing.Point(125, 242);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(129, 59);
         this.pictureBox1.TabIndex = 19;
         this.pictureBox1.TabStop = false;
         // 
         // lblViewingProductPicture
         // 
         this.lblViewingProductPicture.AutoSize = true;
         this.lblViewingProductPicture.Location = new System.Drawing.Point(9, 242);
         this.lblViewingProductPicture.Name = "lblViewingProductPicture";
         this.lblViewingProductPicture.Size = new System.Drawing.Size(39, 13);
         this.lblViewingProductPicture.TabIndex = 18;
         this.lblViewingProductPicture.Text = "picture";
         // 
         // txtViewingProductDescription
         // 
         this.txtViewingProductDescription.Location = new System.Drawing.Point(125, 215);
         this.txtViewingProductDescription.MaxLength = 254;
         this.txtViewingProductDescription.Name = "txtViewingProductDescription";
         this.txtViewingProductDescription.Size = new System.Drawing.Size(129, 20);
         this.txtViewingProductDescription.TabIndex = 17;
         // 
         // lblViewingProductDescription
         // 
         this.lblViewingProductDescription.AutoSize = true;
         this.lblViewingProductDescription.Location = new System.Drawing.Point(9, 218);
         this.lblViewingProductDescription.Name = "lblViewingProductDescription";
         this.lblViewingProductDescription.Size = new System.Drawing.Size(60, 13);
         this.lblViewingProductDescription.TabIndex = 16;
         this.lblViewingProductDescription.Text = "Description";
         // 
         // txtViewingProductNumberSold
         // 
         this.txtViewingProductNumberSold.Location = new System.Drawing.Point(125, 188);
         this.txtViewingProductNumberSold.Name = "txtViewingProductNumberSold";
         this.txtViewingProductNumberSold.ReadOnly = true;
         this.txtViewingProductNumberSold.Size = new System.Drawing.Size(129, 20);
         this.txtViewingProductNumberSold.TabIndex = 15;
         // 
         // lblViewingProductNumberSold
         // 
         this.lblViewingProductNumberSold.AutoSize = true;
         this.lblViewingProductNumberSold.Location = new System.Drawing.Point(9, 191);
         this.lblViewingProductNumberSold.Name = "lblViewingProductNumberSold";
         this.lblViewingProductNumberSold.Size = new System.Drawing.Size(68, 13);
         this.lblViewingProductNumberSold.TabIndex = 14;
         this.lblViewingProductNumberSold.Text = "Number Sold";
         // 
         // txtViewingProductForSale
         // 
         this.txtViewingProductForSale.Location = new System.Drawing.Point(125, 161);
         this.txtViewingProductForSale.Name = "txtViewingProductForSale";
         this.txtViewingProductForSale.Size = new System.Drawing.Size(129, 20);
         this.txtViewingProductForSale.TabIndex = 13;
         // 
         // lblViewingProductForSale
         // 
         this.lblViewingProductForSale.AutoSize = true;
         this.lblViewingProductForSale.Location = new System.Drawing.Point(9, 164);
         this.lblViewingProductForSale.Name = "lblViewingProductForSale";
         this.lblViewingProductForSale.Size = new System.Drawing.Size(85, 13);
         this.lblViewingProductForSale.TabIndex = 12;
         this.lblViewingProductForSale.Text = "Currently for sale";
         // 
         // txtViewingProductProductStock
         // 
         this.txtViewingProductProductStock.Location = new System.Drawing.Point(125, 134);
         this.txtViewingProductProductStock.Name = "txtViewingProductProductStock";
         this.txtViewingProductProductStock.ReadOnly = true;
         this.txtViewingProductProductStock.Size = new System.Drawing.Size(129, 20);
         this.txtViewingProductProductStock.TabIndex = 11;
         // 
         // lblViewingProductProductStock
         // 
         this.lblViewingProductProductStock.AutoSize = true;
         this.lblViewingProductProductStock.Location = new System.Drawing.Point(9, 137);
         this.lblViewingProductProductStock.Name = "lblViewingProductProductStock";
         this.lblViewingProductProductStock.Size = new System.Drawing.Size(87, 13);
         this.lblViewingProductProductStock.TabIndex = 10;
         this.lblViewingProductProductStock.Text = "Number of Stock";
         // 
         // txtViewingProductProductCategory
         // 
         this.txtViewingProductProductCategory.Location = new System.Drawing.Point(125, 108);
         this.txtViewingProductProductCategory.Name = "txtViewingProductProductCategory";
         this.txtViewingProductProductCategory.Size = new System.Drawing.Size(129, 20);
         this.txtViewingProductProductCategory.TabIndex = 9;
         // 
         // lblViewingProductProductCategory
         // 
         this.lblViewingProductProductCategory.AutoSize = true;
         this.lblViewingProductProductCategory.Location = new System.Drawing.Point(9, 111);
         this.lblViewingProductProductCategory.Name = "lblViewingProductProductCategory";
         this.lblViewingProductProductCategory.Size = new System.Drawing.Size(89, 13);
         this.lblViewingProductProductCategory.TabIndex = 8;
         this.lblViewingProductProductCategory.Text = "Product Category";
         // 
         // txtViewingProductProductMinStock
         // 
         this.txtViewingProductProductMinStock.Location = new System.Drawing.Point(125, 82);
         this.txtViewingProductProductMinStock.Name = "txtViewingProductProductMinStock";
         this.txtViewingProductProductMinStock.Size = new System.Drawing.Size(129, 20);
         this.txtViewingProductProductMinStock.TabIndex = 7;
         // 
         // lblViewingProductProductMinStock
         // 
         this.lblViewingProductProductMinStock.AutoSize = true;
         this.lblViewingProductProductMinStock.Location = new System.Drawing.Point(9, 85);
         this.lblViewingProductProductMinStock.Name = "lblViewingProductProductMinStock";
         this.lblViewingProductProductMinStock.Size = new System.Drawing.Size(108, 13);
         this.lblViewingProductProductMinStock.TabIndex = 6;
         this.lblViewingProductProductMinStock.Text = "Minimum Stock Level";
         // 
         // txtViewingProductProductPrice
         // 
         this.txtViewingProductProductPrice.Location = new System.Drawing.Point(125, 56);
         this.txtViewingProductProductPrice.Name = "txtViewingProductProductPrice";
         this.txtViewingProductProductPrice.Size = new System.Drawing.Size(129, 20);
         this.txtViewingProductProductPrice.TabIndex = 5;
         // 
         // lblViewingProductProductPrice
         // 
         this.lblViewingProductProductPrice.AutoSize = true;
         this.lblViewingProductProductPrice.Location = new System.Drawing.Point(9, 61);
         this.lblViewingProductProductPrice.Name = "lblViewingProductProductPrice";
         this.lblViewingProductProductPrice.Size = new System.Drawing.Size(71, 13);
         this.lblViewingProductProductPrice.TabIndex = 4;
         this.lblViewingProductProductPrice.Text = "Product Price";
         // 
         // txtViewingProductProductID
         // 
         this.txtViewingProductProductID.Location = new System.Drawing.Point(125, 30);
         this.txtViewingProductProductID.Name = "txtViewingProductProductID";
         this.txtViewingProductProductID.ReadOnly = true;
         this.txtViewingProductProductID.Size = new System.Drawing.Size(129, 20);
         this.txtViewingProductProductID.TabIndex = 3;
         // 
         // lblViewingProductProductID
         // 
         this.lblViewingProductProductID.AutoSize = true;
         this.lblViewingProductProductID.Location = new System.Drawing.Point(9, 33);
         this.lblViewingProductProductID.Name = "lblViewingProductProductID";
         this.lblViewingProductProductID.Size = new System.Drawing.Size(58, 13);
         this.lblViewingProductProductID.TabIndex = 2;
         this.lblViewingProductProductID.Text = "Product ID";
         // 
         // txtViewingProductProductName
         // 
         this.txtViewingProductProductName.Location = new System.Drawing.Point(125, 4);
         this.txtViewingProductProductName.Name = "txtViewingProductProductName";
         this.txtViewingProductProductName.Size = new System.Drawing.Size(129, 20);
         this.txtViewingProductProductName.TabIndex = 1;
         // 
         // lblViewingProductProductName
         // 
         this.lblViewingProductProductName.AutoSize = true;
         this.lblViewingProductProductName.Location = new System.Drawing.Point(9, 7);
         this.lblViewingProductProductName.Name = "lblViewingProductProductName";
         this.lblViewingProductProductName.Size = new System.Drawing.Size(75, 13);
         this.lblViewingProductProductName.TabIndex = 0;
         this.lblViewingProductProductName.Text = "Product Name";
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
         // listBoxSearchPanel
         // 
         this.listBoxSearchPanel.FormattingEnabled = true;
         this.listBoxSearchPanel.Location = new System.Drawing.Point(4, 109);
         this.listBoxSearchPanel.Name = "listBoxSearchPanel";
         this.listBoxSearchPanel.Size = new System.Drawing.Size(263, 355);
         this.listBoxSearchPanel.TabIndex = 5;
         this.listBoxSearchPanel.DoubleClick += new System.EventHandler(this.listBoxSearchPanek_DoubleClick);
         // 
         // txtSearchPanelProductName
         // 
         this.txtSearchPanelProductName.Location = new System.Drawing.Point(4, 82);
         this.txtSearchPanelProductName.Name = "txtSearchPanelProductName";
         this.txtSearchPanelProductName.Size = new System.Drawing.Size(179, 20);
         this.txtSearchPanelProductName.TabIndex = 4;
         this.txtSearchPanelProductName.TextChanged += new System.EventHandler(this.txtSearchPanelProductName_TextChange);
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
         // txtSearchPanelProductID
         // 
         this.txtSearchPanelProductID.Location = new System.Drawing.Point(4, 38);
         this.txtSearchPanelProductID.Name = "txtSearchPanelProductID";
         this.txtSearchPanelProductID.Size = new System.Drawing.Size(179, 20);
         this.txtSearchPanelProductID.TabIndex = 2;
         this.txtSearchPanelProductID.TextChanged += new System.EventHandler(this.txtSearchPanelProductID_TextChange);
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
         this.pnlViewingProduct.ResumeLayout(false);
         this.pnlViewingProduct.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
      private System.Windows.Forms.Panel pnlViewingProduct;
      private System.Windows.Forms.Label lblViewingProductProductName;
      private System.Windows.Forms.TextBox txtViewingProductProductMinStock;
      private System.Windows.Forms.Label lblViewingProductProductMinStock;
      private System.Windows.Forms.TextBox txtViewingProductProductPrice;
      private System.Windows.Forms.Label lblViewingProductProductPrice;
      private System.Windows.Forms.TextBox txtViewingProductProductID;
      private System.Windows.Forms.Label lblViewingProductProductID;
      private System.Windows.Forms.TextBox txtViewingProductProductName;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.Label lblViewingProductPicture;
      private System.Windows.Forms.TextBox txtViewingProductDescription;
      private System.Windows.Forms.Label lblViewingProductDescription;
      private System.Windows.Forms.TextBox txtViewingProductNumberSold;
      private System.Windows.Forms.Label lblViewingProductNumberSold;
      private System.Windows.Forms.TextBox txtViewingProductForSale;
      private System.Windows.Forms.Label lblViewingProductForSale;
      private System.Windows.Forms.TextBox txtViewingProductProductStock;
      private System.Windows.Forms.Label lblViewingProductProductStock;
      private System.Windows.Forms.TextBox txtViewingProductProductCategory;
      private System.Windows.Forms.Label lblViewingProductProductCategory;
      private System.Windows.Forms.Button btnViewingProductActionButton;
      private System.Windows.Forms.Button btnViewingProductCancelButton;
   }
}