SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
CREATE PROCEDURE [Отображение студентов по возрасту] 
	-- Add the parameters for the stored procedure here
	@Age int = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT ФИО, 
		   [Запрос Студенты + Специальности].[дата рождения],
		   'Возраст'=DATEDIFF(yy,[Запрос Студенты + Специальности].[Дата рождения], GETDATE())
	FROM [Запрос Студенты + Специальности]
    WHERE DATEDIFF(yy,[Запрос Студенты + Специальности].[Дата рождения], GETDATE ())> @Age
END
