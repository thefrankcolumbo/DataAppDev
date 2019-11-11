-- procedure to search for a product by name likness
CREATE PROCEDURE [dbo].[SearchForProductByNameLikness] 
(@name AS VARCHAR(50))
AS
SELECT @name = RTRIM(@name) + '%'
BEGIN
SELECT
[Name],
[Id]
FROM [dbo].[Product]
WHERE [dbo].[Product].[Name] LIKE @name
END
GO
