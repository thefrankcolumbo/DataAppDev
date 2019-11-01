-- create stored procedure that gets all for sale by category
CREATE PROCEDURE [dbo].[getAllProductsForSaleByCategory] (@category AS VARCHAR(50)) AS
BEGIN
SELECT [Id]
      ,[Name]
      ,[ForSale]
      ,[Description]
      ,[Quantity]
      ,[MinimumStock]
      ,[NumberSold]
      ,[PictureFilePath]
      ,[RetailPrice]
      ,[Category_Name]
  FROM [MirrorAssignment].[dbo].[Product]
  WHERE [ForSale] = 1 AND [Category_Name] = @category
  END
GO