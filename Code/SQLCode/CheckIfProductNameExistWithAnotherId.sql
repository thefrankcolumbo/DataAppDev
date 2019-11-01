-- create function to check if a product name already exists with another ProductId
-- Returns 1 if true
-- Returns 0 if false
CREATE FUNCTION [dbo].[CheckIfProductNameExistWithAnotherId] (@ProdName AS VARCHAR(50), @ProductId AS INT) 
RETURNS TINYINT
AS
BEGIN
DECLARE @Bool AS TINYINT;
DECLARE @Total AS INT;
SET @Total = 
(
    SELECT COUNT (*)
    FROM [dbo].[Product]
    WHERE [Name] = @ProdName AND [Id] != @ProductId
)
IF @Total = 1
    SET @Bool = 1
ELSE
    SET @Bool = 0
RETURN @Bool;
END
GO
