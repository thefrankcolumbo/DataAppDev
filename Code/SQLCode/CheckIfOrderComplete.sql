-- function to check if an order is complete
-- returns 1 - true if order complete
-- returns 0 - flase if order not complete
CREATE FUNCTION [dbo].[CheckIfOrderComplete] (@orderId AS INT)
RETURNS TINYINT
AS
BEGIN
DECLARE @orderComplete AS TINYINT;

SET @orderComplete = (
    SELECT [Complete]
    FROM [dbo].[Order]
    WHERE [Id] = @orderID
)
RETURN @orderComplete
END 
GO