-- function to check if there is enough stock
-- returns 1 if the quantity requested is equal to or greater than the quantity available
-- returns 0 if the quantity requested is less than the quantity available
CREATE FUNCTION [dbo].[CheckIfProductCanBeSold] (@productID AS INT, @quantity AS INT)
RETURNS TINYINT
AS
BEGIN
DECLARE @bool AS TINYINT;
DECLARE @productStock AS INT;

SET @productStock = (
    SELECT [Quantity]
    FROM [dbo].[Product]
    WHERE [Id] = @productID --AND [ForSale] = 1
)
IF @productStock >= @quantity
    SET @bool = 1 
ELSE
    SET @bool = 0
RETURN @bool;
END
GO