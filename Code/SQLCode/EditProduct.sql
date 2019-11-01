-- Edits an already existing product
-- cannot edit Id
-- cannot edit numberSold
CREATE PROCEDURE [dbo].[EditProduct] 
(@id AS INT, @CatName AS VARCHAR(50), @ProdName AS VARCHAR(50), @OnSale As TINYINT, @ProdDescription AS VARCHAR(255),
@MinStock AS INT, @PictFilePath AS VARCHAR(50), @RetPrice AS SMALLMONEY) AS
BEGIN
UPDATE [Product] 
SET 
[Name] = @ProdName, 
[ForSale] = @OnSale, 
[Description] = @ProdDescription, 
[MinimumStock] = @MinStock, 
[PictureFilePath] = @PictFilePath, 
[RetailPrice] = @RetPrice, 
[Category_Name] = @CatName
WHERE [Id] = @id;
END
GO