SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION [Функция средних трёх величин] 
(
	-- Add the parameters for the function here
	@Value1 Int, @Value2 Int, @Value3 Int
)
RETURNS Real
AS
BEGIN
	-- Declare the return variable here
	DECLARE @Result Real

	-- Add the T-SQL statements to compute the return value here
	SELECT @Result = (@Value1+@Value2+@Value3)/3

	-- Return the result of the function
	RETURN @Result

END
