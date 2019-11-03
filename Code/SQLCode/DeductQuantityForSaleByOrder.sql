-- creates procedure to reduct the quantity of stock by the number in an order
CREATE PROCEDURE [dbo].[DeductQuantityForSaleByOrder] (@product AS INT, @quantity AS INT)
AS
BEGIN
UPDATE [dbo].[Product]
SET [Quantity] = ([Quantity] - @quantity)
WHERE [Id] = @product
END
GO
