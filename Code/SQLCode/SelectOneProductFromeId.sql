-- create stored procedure to get all the data from one product using
-- Id
CREATE PROCEDURE [dbo].[SelectOneProductFromId] (@id AS INT) AS
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
  WHERE [Id] = @id;
  END
  GO