SQL Code README file

20191103 Uploaded SQL Stored Procedures / Functions to enable M.1.1.4	customer – cancel order. Below is psudo code for the whole process:
Customer cancels order
Client side - Message sent requesting cancelling order
Middleware - message recived from client
1. (C#) check to see if order is complete. Orders which are complete CANNOT be cancelled
Bool = (SQL) [dbo].[CheckIfOrderComplete]
2. IF bool = false GOTO 3. If bool = True GOTO 9.
3. (C#) call [dbo].[GetBasket]
4. (C#) using loop(?) for each product
5. (C#) call (SQL) [dbo].[AddToQuantityForSale]
6. (C#) call (SQL) [dbo].[DeleteRowFromBasketTable]
7. (C#) record success/failure
8. (C#) IF more products in basket GOTO 4. ELSE GOTO 9.
9. (C#) send message to client

20191103 Uploaded SQL Stored Procedures / Functions to enable M.1.1.1	customer – order drink and/or snack. Below is psudo code for the whole process:
Customer order drink and snacks
client side - message sent with drinks / snacks and quantities to be ordered
middleware - message recieved from client
1. (C#) function(s)/methods(s) sort into individual products.
2. (SQL) call create an order [dbo].[CreateNewOrder]
3. (C#) using loop(?) for each product
4. (C#) bool = (SQL) check there is enough stock [dbo].[CheckIfProductCanBeSold]
5. (C#) IF bool == True GOTO 6. IF bool == False GOTO 8.
6. (C#) call (SQL) deduct from stock [dbo].[DeductQuantityForSaleByOrder].
7. (C#) call (SQL) add to basket [dbo].[AddToBasket]
8. (C#) record success/failure
9. (C#) IF more products ordered GOTO 3. ELSE GOTO 10.
10. (C#) send message back to client ##UPDATED## (SQL) [dbo].[GetBasket]

20191031 Uploaded SQL Stored Procedures / Functions (Names are self explanitory):
	AddNewProductAllDetails.sql
	CheckIfProductNameExistsWithAnotherId.sql
	EditProduct.sql
	GetAllProductsForSale.sql
	GetAllProductsForSaleByCategory.sql
	GetAllProductsNotForSale.sql
	GetAllProductsNotForSaleByCategory.sql
	SelectOneProductFromId.sql
	SelectOneProductFromName.sql

20191028 Ulloaded SQL create FK and columns

20191028 uploaded SQL create tables code