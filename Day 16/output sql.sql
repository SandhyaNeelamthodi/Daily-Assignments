USE [Empdb]
GO

DECLARE	@return_value int,
		@salary money

SELECT	@salary = 5000

EXEC	@return_value = [dbo].[sp_Getsalary]
		@empid = 1,
		@salary = @salary OUTPUT

SELECT	@salary as N'@salary'

SELECT	'Return Value' = @return_value

GO
