-- create view of all products which are below the minimum stock requirements
CREATE VIEW [dbo].[ViewAllProductsBelowMinimumStockLevels]
AS
SELECT [Name], [Quantity], [MinimumStock]
FROM [dbo].[Product]
WHERE [Quantity] < [MinimumStock]
GO