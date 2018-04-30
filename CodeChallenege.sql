Create Database CustomersDB

Create Table Products(
	Id int primary key identity Not Null,
	[name] nvarchar(50) not null,
	Price float not null
);

Create Table Customers(
Id int primary key identity Not Null,
[Firstname] nvarchar(50) not null,
[Lastname] nvarchar(50) not null,
CardNumber int not null
);
Create Table Orders(
	Id int primary key identity Not Null,
	[ProductId] int not null,
	[CustomerId] int not null,
	Foreign Key (ProductId) References Products(Id),
	Foreign Key (CustomerId) References Customers(Id)
);
alter table Customers
alter column CardNumber nvarchar(255)
Insert Into Customers(Firstname,Lastname,CardNumber)
values('Ethan', 'Misale' , '1111 1111 1111 1111'),
('John', 'Doe' , '1111 1111 1111 1112'),
('Joe', 'Peters' , '1111 1111 1111 1113')

Insert Into Products(name, Price)
values ('iPhone', 200),
('Samsung Galaxy', 150)

Insert Into Customers(Firstname,Lastname,CardNumber)
values('Tina', 'Smith', '1111 1111 1111 1113')

Insert Into Orders(ProductId,CustomerId)
values(1,4)

Select * From Orders
where CustomerId = 4

Update Products
Set Price  = 250
where Id = 1
