-- create view that gets all Teas and Biscuits for sale
CREATE VIEW [dbo].[ViewAllProductsForSale] 
AS
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
  WHERE [ForSale] = 1
  GO