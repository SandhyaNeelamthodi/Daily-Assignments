create table customers(CustomerID int primary key, CustomerName varchar(200),
ContactName varchar(200), Address varchar(200), City varchar(200), PostalCode int,
Country  varchar(200));
insert into customers(CustomerID,CustomerName,ContactName,Address,City,PostalCode,Country)
values(1,'Sandhya','Sandya','Chundambatta','Pattambi',679337,'India');
select * from customers;
select 10+10;

select DATEPART(weekday,GetDate());