-- create stored procedure to get all the data from one product using
-- Name
CREATE PROCEDURE [dbo].[SelectOneProductFromName] (@name AS VARCHAR(50)) AS
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
  WHERE [Name] = @name;
  END
  GO