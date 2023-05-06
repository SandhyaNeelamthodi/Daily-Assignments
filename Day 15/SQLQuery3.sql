create table Client_Master(CLIENTNO VARCHAR(6) PRIMARY KEY,NAME VARCHAR(20) NOT NULL,ADDRESS1 VARCHAR(30),
ADDRESS2 VARCHAR(30),CITY VARCHAR(15),PINCODE NUMERIC(8),STATE VARCHAR(15),BALDUE NUMERIC(10,2));
insert into Client_Master(CLIENTNO,NAME ,CITY,PINCODE,STATE,BALDUE) VALUES('C00001','Ivan Bayross','Mumbai',
400054,'Maharashtra',15000);
 INSERT INTO Client_Master VALUES('C00002','ANJU','B/11','CBT','PATTAMBI',679337,'KERALA',30000);
select * from Client_Master;

create table Product_Master(PRODUCTNO VARCHAR(6) PRIMARY KEY,DESCRIPTION VARCHAR(15)NOT NULL,PROFITPERC NUMERIC(4,2) NOT NULL,
UNITMEASURE VARCHAR(10)NOT NULL,QTYONHAND NUMERIC(8) NOT NULL,REORDERLEVEL NUMERIC(8) NOT NULL,
SELLPRICE NUMERIC(8,2)check(SELLPRICE !=0) NOT NULL,COSTPRICE NUMERIC(8,2) check(COSTPRICE !=0)NOT NULL);
INSERT INTO Product_Master VALUES('P00001','T-Shirts',5,'Piece',200,50,350,250);
INSERT INTO Product_Master VALUES('P00002','TOP',6,'Piece',200,30,3500,2000);
SELECT * FROM Product_Master;

create table SALESMAN_MASTER(SALESMANNO VARCHAR(6) PRIMARY KEY,SALESMAN_NAME VARCHAR(20) NOT NULL,
ADDRESS1 VARCHAR(30) NOT NULL,ADDRESS2 VARCHAR(30),CITY VARCHAR(20),PINCODE NUMERIC(8), State varchar(20),
SALAMT NUMERIC(8,2) check(SALAMT!=0) NOT NULL,TGTTOGET NUMERIC(8,2) NOT NULL ,YTDSALES NUMERIC(8,2) NOT NULL,
REMARKS VARCHAR(60));
INSERT INTO SALESMAN_MASTER VALUES('S00001','Aman','A/14','Worli','Mumbai','400002','Maharashtra',
3000,100,50,'Good');

create table SALES_ORDER(ORDERNO VARCHAR(6) PRIMARY KEY,CLIENTNO VARCHAR(6),ORDERDATE DATE,
DELYADDR VARCHAR(25),SALESMANNO VARCHAR(6),DELYTYPE  CHAR(1)  CHECK(DELYTYPE LIKE' %P%' OR DELYTYPE LIKE '%F%'),
BILLEDYN CHAR(1)CHECK(BILLEDYN LIKE '%Y%' OR BILLEDYN LIKE '%N%' ),DELYDATE DATE,
ORDERSTATUS VARCHAR(10) CHECK(ORDERSTATUS ='IN PROCESS' OR ORDERSTATUS ='Fulfilled' OR ORDERSTATUS ='Backorder' OR ORDERSTATUS = 'Cancelled'),
foreign key (CLIENTNO)REFERENCES Client_Master(CLIENTNO),foreign key (SALESMANNO)REFERENCES SALESMAN_MASTER(SALESMANNO));
INSERT INTO SALES_ORDER(ORDERNO,ORDERDATE,CLIENTNO,DELYTYPE,BILLEDYN,SALESMANNO,DELYDATE,ORDERSTATUS)
values('O19001','12-june-12','C00001','F','N','S00001','20-july-02','In process');
SELECT * FROM SALES_ORDER;

create table SALES_ORDER_DETAILS(ORDERNO VARCHAR(6),PRODUCTNO VARCHAR(6),QTYORDERED NUMERIC(8),
QTYDISP NUMERIC(8),PRODUCTRATE NUMERIC(10,2),FOREIGN KEY(ORDERNO)REFERENCES SALES_ORDER(ORDERNO),
FOREIGN KEY(PRODUCTNO)REFERENCES PRODUCT_MASTER(PRODUCTNO));
insert into SALES_ORDER_DETAILS(ORDERNO,PRODUCTNO,QTYORDERED,QTYDISP,PRODUCTRATE)values('O19001','P00001',4,4,525); 

SELECT NAME FROM Client_Master;
SELECT NAME FROM Client_Master WHERE CITY='MUMBAI';
SELECT PRODUCTNO FROM PRODUCT_MASTER WHERE SELLPRICE BETWEEN 2000 AND 5000;
select NAME,CITY,STATE from Client_Master where STATE != 'MAHARASHTRA';
SELECT * FROM Client_Master WHERE CLIENTNO = 'C00001' OR CLIENTNO = 'C00002';
UPDATE Product_Master SET SELLPRICE='1150.50'where SELLPRICE='350';
DELETE FROM Client_Master WHERE CLIENTNO='C00002';
SELECT * FROM Client_Master WHERE CITY LIKE '_U%';
SELECT COUNT(*) AS NUMBER FROM Product_Master  WHERE SELLPRICE>=1500;
