
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [Среднее трёх величин] 
	-- Add the parameters for the stored procedure here
	@Value1 real=0,
	@Value2 Real=0,
	@Value3 Real=0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from...
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 'Среднее Значение'= (@Value1+@Value2+@Value3)/3
END
