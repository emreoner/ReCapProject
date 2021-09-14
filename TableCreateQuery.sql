create table Colors(
Id bigint identity(1,1) primary key not null,
Name nvarchar(255) not null
);

create table Brands(
Id bigint identity(1,1) primary key not null,
Name nvarchar(255) not null
);

create table Cars(
 Id bigint identity(1,1) primary key not null,
 BrandId bigint FOREIGN KEY REFERENCES Brands(Id) not null,
 ColorId bigint FOREIGN KEY REFERENCES Colors(Id) not null,
 ModelYear int not null,
 DailyPrice money,
 Description ntext

);

create table Users(
 Id bigint identity(1,1) primary key not null,
 FirstName nvarchar(100) not null,
 LastName nvarchar(100) not null,
 Email nvarchar(100) not null,
 Password nvarchar(255) not null
);

create table Customers(
 Id bigint identity(1,1) primary key not null,
 UserId bigint  FOREIGN KEY REFERENCES Users(Id) not null,
 CompanyName nvarchar(255) not null
);

create table Rentals(
 Id bigint identity(1,1) primary key not null,
 CarId bigint FOREIGN KEY REFERENCES Cars(Id) not null,
 CustomerId bigint  FOREIGN KEY REFERENCES Customers(Id) not null,
 RentDate datetime not null,
 ReturnDate datetime
);