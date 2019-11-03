-- create stored procedure to reduce the number of products in a basket (to a number above zero)
CREATE PROCEDURE [dbo].[ReduceProductQuantityInBasket] (@orderID AS INT, @productID AS INT, @quantityChange AS INT)
AS
BEGIN
UPDATE [dbo].[Basket]
SET [Quantity] = [Quantity] - @quantityChange
WHERE [Order_Id] = @orderID AND [Product_Id] = @productID
END
GO