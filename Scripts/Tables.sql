create database Brutus;
go

use Brutus
go

create table [dbo].[customer]
(
	Id int identity(1,1) primary key,
	Name varchar(256) not null,
	CPF varchar(11),
	Cell_Phone varchar(11),
	Address varchar (256),
	Address_Number varchar(256),
	Observation varchar (256)
);
go

create table [dbo].[note]
(
	Id int identity(1,1) primary key,
	Customer_Id  int,
	foreign key (Customer_Id) REFERENCES customer(Id),
	Date date,
	StartSchedule datetime,
	FinalSchedule datetime,
	Address varchar (256)
);
go

create table [dbo].[product]
(
	Id int identity(1,1) primary key,
	Name varchar (256) not null,
	Quantity int not null,
	Price int,	
);
go