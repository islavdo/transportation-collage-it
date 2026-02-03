-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [Функция средних трех величин]
(
	-- Add the parameters for the stored procedure here
	@Value1 int, @Value2 int, @Value3 int
)
RETURNS Real
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	DECLARE @Result Real
	-- interfering with SELECT statements.
	SELECT @Result = (@Value1+@Value2+@Value3)/3
    -- Insert statements for procedure here
	RETURN @Result
END
GO
