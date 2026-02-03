CREATE FUNCTION [Последний день месяца]
(
	@MyDate DateTime
)
RETURNS DateTime
AS
BEGIN
	DECLARE @Year Int
	DECLARE @Month Int
	DECLARE @Day Int
	DECLARE @TmpDate Varchar(10)
	DECLARE @Result DateTime

	SET @Year=DatePart(yy, @MyDate)
	SET @Month=Datepart(mm, @MyDate)
	SET @Day=DatePart(dd, @MyDate)

	IF @Month=12
		BEGIN
			SET @Month=1
			SET @Year=@Year+1
		END
	ELSE
		BEGIN
			SET @Month=@Month+1
		END
	SET @TmpDate=Convert(Varchar, @Month)+'/01/'+Convert(Varchar, @Year)
	SET @Result=Convert(DateTime, @TmpDate)
	SET @Result=DateAdd(dd, -1, @Result)
	
	RETURN @Result
END
GO