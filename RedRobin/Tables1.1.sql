CREATE SCHEMA RR

CREATE TABLE RR.Restaurant (
    RestaurantID int IDENTITY(1,1) NOT NULL,
    RestLocation nvarchar(100) UNIQUE NOT NULL,
	RestPhone nvarchar(100) UNIQUE NOT NULL,
	PRIMARY KEY (RestaurantID)
);

CREATE TABLE RR.Customer (
    CustomerID int IDENTITY(1,1) NOT NULL,
    CustName nvarchar(100) NOT NULL,
	CustPhone nvarchar(100) UNIQUE NOT NULL,
	PRIMARY KEY (CustomerID)
);

CREATE TABLE RR.Ingredients (
    IngredientID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
    IngName nvarchar(100) NOT NULL,
	IngCost decimal(7,2) NOT NULL,
);


CREATE TABLE RR.Product (
    ProductID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	ProType nvarchar(50) NOT NULL,
    ProName nvarchar(100) UNIQUE NOT NULL,
	ProCost decimal(7,2) NOT NULL,
);


CREATE TABLE RR.Orders (
    OrderID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
    OrdDate datetime2 NOT NULL,
	OrdCost decimal(7,2) NOT NULL,
	CustomerID int NOT NULL,
	RestaurantID int NOT NULL,
	constraint fk_Customer foreign key (CustomerID) references RR.Customer (CustomerID),
	constraint fk_Restaurant foreign key (RestaurantID) references RR.Restaurant (RestaurantID)
);


CREATE TABLE RR.OrderProduct (
    OrdProID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	OrderID int NOT NULL,
	ProductID int NOT NULL,
	constraint fk_OrdOrderProduct foreign key (ProductID) references RR.Product (ProductID),
	constraint fk_ProOrderProduct foreign key (OrderID) references RR.Orders (OrderID),
);

CREATE TABLE RR.ResIng (
    ResIngID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
    RestaurantID int NOT NULL,
	IngredientID int NOT NULL,
	Qty decimal(7,2) NOT NULL,
	constraint fk_ResResIngPro foreign key (RestaurantID) references RR.Restaurant (RestaurantID),
	constraint fk_IngResIngPro foreign key (IngredientID) references RR.Ingredients (IngredientID),
	CONSTRAINT UC_ResIng UNIQUE (RestaurantID,IngredientID),
);

CREATE TABLE RR.ResPro (
    ResProID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
    ProductID int NOT NULL,
	RestaurantID int NOT NULL,
	constraint fk_ResPro foreign key (ProductID) references RR.Product (ProductID),
	constraint fk_ProRes foreign key (RestaurantID) references RR.Restaurant (RestaurantID),
);

CREATE TABLE RR.IngPro (
    IngProID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	IngredientID int NOT NULL,
	ProductID int NOT NULL,
	Qty decimal(7,2) NOT NULL,
	constraint fk_IngPro foreign key (IngredientID) references RR.Ingredients (IngredientID),
	constraint fk_ProIng foreign key (ProductID) references RR.Product (ProductID),
);





select * from RR.Restaurant
select * from RR.Customer

select * from RR.ResIng
select * from RR.IngPro
select * from RR.Product
select * from RR.Ingredients

select * from RR.ResPro
select * from RR.Orders
select * from RR.OrderProduct

select Count(productID)
from RR.OrderProduct
where ProductID = 9



delete from RR.IngPro
delete from RR.Restaurant
delete from RR.Customer
delete from RR.Ingredients
delete from RR.Product
delete from RR.ResPro
delete from RR.Orders
delete from RR.OrderProduct

drop table RR.Product
drop table RR.Restaurant
drop table RR.Customer
drop table RR.Ingredients
drop table RR.ResIng
drop table RR.OrderProduct
drop table RR.IngPro
drop table RR.ResPro


select * from RR.ResIng as IR
join RR.Ingredients as I
on IR.IngredientID = I.IngredientID
where IR.RestaurantID = 11


