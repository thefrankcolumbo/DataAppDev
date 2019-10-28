ALTER TABLE Product
ADD [Category_Name] VARCHAR(50) NOT NULL
CONSTRAINT FK_Category_Name FOREIGN KEY (Category_Name)
REFERENCES [dbo].[Category] (Name);

ALTER TABLE Basket
ADD [Order_Id] INT NOT NULL
CONSTRAINT FK_Order_Id FOREIGN KEY (Order_Id)
REFERENCES [dbo].[Order] (Id);
ALTER TABLE Basket
ADD [Product_Id] INT
CONSTRAINT FK_Product_Id FOREIGN KEY (Product_Id)
REFERENCES [dbo].[Product] (Id);