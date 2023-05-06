create or alter procedure sp_Getsalary
@empid int,@salary money output
as
BEGIN
SELECT @salary=SALARY FROM Department
WHERE EmpId=@empid;
end
exec sp_Getsalary