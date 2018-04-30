CREATE DATABASE Challenge

USE Challenge

Create table Products
(
Id int Primary Key not null,
[Name] varchar(50) not null,
Price decimal not null,

);

Create table Orders
(
Id int not null,
ProductId int foreign key references Products(Id),
CustomerId int foreign key references Customers(Id)
);

Create table Customers
(
Id int primary key not null,
FirstName varchar(50) not null,
LastName varchar(50) not null,
CardNumber int not null
);

--Insert into Products (Id, [Name], Price)
--values( 1, 'iPhone', 200)
--values( 2, 'Laptop', 800)
--values( 3, 'TV', 500)

Insert into Customers(Id, FirstName, LastName, CardNumber)
--values( 1, 'Tina', 'Smith', 1284957236)
--values( 2, 'Tom', 'Jones', 1234598494)
--values( 3, 'John', 'Doe', 1730028743)

Insert into Orders(Id, ProductId, CustomerId)
values (1, 1, 1)

SELECT * FROM Orders WHERE CustomerID = 1;

SELECT * FROM 