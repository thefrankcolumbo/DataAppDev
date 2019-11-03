-- gets the basket for a specific order
CREATE PROCEDURE [dbo].[GetBasket] (@orderId AS INT)
AS
BEGIN
SELECT *
FROM [dbo].[Basket]
WHERE [Order_Id] = @orderId
END
GO