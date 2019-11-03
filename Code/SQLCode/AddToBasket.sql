-- procedure thats add a product and the quantity to the basket
CREATE PROCEDURE [dbo].[AddToBasket] (@quantity AS INT, @timeOrdered AS DATETIME2, @product AS INT, @orderId AS INT)
AS
BEGIN
INSERT INTO [dbo].[Basket]
([Quantity], [TimeOrdered],[Product_Id],[Order_Id])
VALUES
(@quantity, @timeOrdered, @product, @orderId)
END
GO