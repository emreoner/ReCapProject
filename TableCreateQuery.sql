create table Colors(
Id int identity(1,1) primary key not null,
Name nvarchar(255) not null
);

create table Brands(
Id int identity(1,1) primary key not null,
Name nvarchar(255) not null
);

create table Cars(
 Id int identity(1,1) primary key not null,
 BrandId int FOREIGN KEY REFERENCES Brands(Id) not null,
 ColorId int FOREIGN KEY REFERENCES Colors(Id) not null,
 ModelYear int not null,
 DailyPrice money,
 Description ntext

);