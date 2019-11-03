-- create view that gets all Teas and Biscuits not for sale
CREATE VIEW [dbo].[ViewAllProductsNotForSale] AS
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
  GO