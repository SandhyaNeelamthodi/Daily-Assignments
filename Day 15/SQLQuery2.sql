create table BANKTB(ACNO int,Acccount_Holder_Name varchar(20),Balance int,RefAccNo int,);

select * FROM BANKTB;
select s.ACNO, s.Acccount_Holder_Name, s.Balance, s.RefAccNo as[Ref AcNo],
r.Acccount_Holder_Name as [Name of Referer]
from BANKTB s join BANKTB r
on s.RefAccNo = r. ACNO;
