CREATE PROCEDURE [dbo].[SearchForProductByIdLikness] 
(@id AS INT)
AS
SELECT @id = RTRIM(@id) + '%'
BEGIN
SELECT
[Name],
[Id]
FROM [dbo].[Product]
WHERE [dbo].[Product].[Id] LIKE @id
END
GO