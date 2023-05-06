DECLARE @empid INT



DECLARE @salary DECIMAL

DECLARE @grandsalary DECIMAL = 0

DECLARE employee_cursor CURSOR FOR

SELECT empid, salary

FROM Department

OPEN employee_cursor

FETCH NEXT FROM employee_cursor INTO @empid, @salary

WHILE @@FETCH_STATUS = 0

BEGIN

 SET @grandsalary = @grandsalary + @salary

 FETCH NEXT FROM employee_cursor INTO @empid, @salary

END

CLOSE employee_cursor

DEALLOCATE employee_cursor

SELECT @grandsalary AS Grandsalary