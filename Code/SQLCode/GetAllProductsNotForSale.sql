-- create stored procedure that gets all Teas and Biscuits not for sale
CREATE PROCEDURE [dbo].[getAllProductsNotForSale] AS
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
  WHERE [ForSale] = 0
  END
  GO