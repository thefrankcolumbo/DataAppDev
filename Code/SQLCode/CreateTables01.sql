
IF OBJECT_ID('[dbo].[Category]', 'U') IS NOT NULL
DROP TABLE [dbo].[Category]
GO

CREATE TABLE [dbo].[Category]
(
    [Name] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [PictureFilePath] NVARCHAR(50),
    UNIQUE (PictureFilePath) -- every category MUST have a unique picture
);
GO

IF OBJECT_ID('[dbo].[Product]', 'U') IS NOT NULL
DROP TABLE [dbo].[Product]
GO

CREATE TABLE [dbo].[Product]
(
    [Id] INT NOT NULL IDENTITY(1000, 1) PRIMARY KEY, 
    [Name] VARCHAR(50) NOT NULL, -- no product should have the same name
    [ForSale] TINYINT NOT NULL DEFAULT 0,
    [Description] VARCHAR(255) NOT NULL, -- no product should have the same description as another
    [Quantity] INT NOT NULL DEFAULT 0,
    [MinimumStock] INT NOT NULL DEFAULT 100,
    [NumberSold] INT NOT NULL DEFAULT 0,
    [PictureFilePath] NVARCHAR(50), -- no product should have the same picture
    [RetailPrice] SMALLMONEY, -- lower memory cost than MONEY
    UNIQUE (Description, Name, PictureFilePath) -- no product should have the same name or description or picture
);
GO

IF OBJECT_ID('[dbo].[Basket]', 'U') IS NOT NULL
DROP TABLE [dbo].[Basket]
GO

CREATE TABLE [dbo].[Basket]
(
    [Id] INT NOT NULL IDENTITY(1000, 1) PRIMARY KEY, 
    [Quantity] INT NOT NULL DEFAULT 1,
    [TimeOrdered] DATETIME2(0) NOT NULL -- lower memory cost than DATETIME
);
GO

IF OBJECT_ID('[dbo].[Order]', 'U') IS NOT NULL
DROP TABLE [dbo].[Order]
GO

CREATE TABLE [dbo].[Order]
(
    [Id] INT NOT NULL IDENTITY(1000, 1) PRIMARY KEY, 
    [Complete] INT NOT NULL DEFAULT 0,
    [TimeComplete] DATETIME2 -- lower memory cost than DATETIME
);
GO