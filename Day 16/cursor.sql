DECLARE @empid INT;
DECLARE Emp_cursor CURSOR
FOR
SELECT empid from Department ORDER BY empid;
open Emp_cursor;
fetch next from Emp_cursor into @empid;
CLOSE Emp_cursor;