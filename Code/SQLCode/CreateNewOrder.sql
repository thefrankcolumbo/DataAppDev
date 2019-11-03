-- create procedure that creates a new order and returns that order number
CREATE PROCEDURE [dbo].[CreateNewOrder] 

AS
BEGIN

DECLARE @id AS INT;
INSERT INTO [dbo].[Order]
([Complete])
VALUES
(0);

SELECT SCOPE_IDENTITY() AS [SCOPE_IDENTITY];

END