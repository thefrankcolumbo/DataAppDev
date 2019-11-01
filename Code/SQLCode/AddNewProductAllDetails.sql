--Creates a product on the DB using all fields EXCEPT
-- Id (that is automatically created) AND
-- NumberSold (If it has been created then it has never been sold, so the amount must be 0)
CREATE PROCEDURE [dbo].[AddNewProductAllDetails] 
(@CatName AS VARCHAR(50), @ProdName AS VARCHAR(50), @OnSale As TINYINT, @ProdDescription AS VARCHAR(255),
@ProdQuantity AS INT, @MinStock AS INT, @PictFilePath AS VARCHAR(50), @RetPrice AS SMALLMONEY) AS
BEGIN
INSERT INTO [Product] 
([Name], [ForSale], [Description], [Quantity], [MinimumStock], [PictureFilePath], [RetailPrice], [Category_Name])
VALUES (@ProdName, @OnSale, @ProdDescription, @ProdQuantity, @MinStock, @PictFilePath, @RetPrice, @CatName);
END
GO
