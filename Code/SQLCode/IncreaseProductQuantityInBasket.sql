-- create stored procedure to increase the number of products in a basket 
CREATE PROCEDURE [dbo].[IncreaseProductQuantityInBasket] (@orderID AS INT, @productID AS INT, @quantityChange AS INT)
AS
BEGIN
UPDATE [dbo].[Basket]
SET [Quantity] = [Quantity] + @quantityChange
WHERE [Order_Id] = @orderID AND [Product_Id] = @productID
END
GO