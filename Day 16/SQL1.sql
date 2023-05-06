CREATE OR ALTER PROCEDURE ShowEmpwithId (@empid int) 
AS
begin 
select * from Department where EmpId=@empid;

end

exec ShowEmpwithId 2