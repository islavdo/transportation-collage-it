-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
CREATE PROCEDURE [Отображение студентов по среднему баллу] 
	-- Add the parameters for the stored procedure here
	@Grade Real = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
	FROM [Запрос Студенты+Оценки] 
	WHERE ([Оценка первого экзамена]+[Оценка второго экзамена]+[Оценка третьего экзамена])/3>@Grade
END
GO
