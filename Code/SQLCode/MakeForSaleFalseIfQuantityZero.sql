-- create a trigger. on update if quantity 0 make forsale 0
CREATE TRIGGER [dbo].[MakeForSaleFalseIfQuantityZero] ON [dbo].[Product]
AFTER UPDATE
AS
BEGIN
    UPDATE [Product]
    SET [ForSale] = 0
    FROM [dbo].[Product]
    WHERE [Quantity] = 0
END