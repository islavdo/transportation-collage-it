
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
CREATE PROCEDURE [Отображение студентов по ФИО] 
	-- Add the parameters for the stored procedure here
	@FIO Varchar(50)=' '
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * 
	FROM dbo.Студенты 
	WHERE ФИО=@FIO
END
