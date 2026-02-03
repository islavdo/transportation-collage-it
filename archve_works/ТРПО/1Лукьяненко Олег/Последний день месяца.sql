-- ================================================
-- Template generated from Template Explorer using:
-- Create Scalar Function (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the function.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION [Последний день месяца] 
(
	-- Add the parameters for the function here
	@Mydate DAteTime
)
RETURNS DAtetime
AS
BEGIN
	-- Declare the return variable here
	DECLARE @year int
	declare @month int
	declare @day int
	declare @Tmpdate Varchar(10)
	declare @result Datetime

	Set @year=DATEPART(yy, @mydate)
	set @month=DATEPART(mm, @mydate)
	set @day=DATEPART(dd, @mydate)

	IF @month=12
		begin
			set @month=1
			set @year=@year+1
		end
	Else
		begin
			Set @month=@month+1
		end
	-- Add the T-SQL statements to compute the return value here
	Set @Tmpdate=CONVERT(varchar, @month)+'/01/'+CONVERT(varchar, @year)
	set @result=CONVERT(datetime, @TMPdate)
	set @result=DateAdd(dd, -1, @result)
	-- Return the result of the function
	RETURN @result
END
GO

