-- create stored procedure to remove a row from Basket table
CREATE PROCEDURE [dbo].[DeleteRowFromBasketTable] (@orderId AS INT, @productId AS INT)
AS
BEGIN
DELETE
FROM [dbo].[Basket]
WHERE [Order_Id] = @orderId AND [Product_Id] = @productId
END
GO