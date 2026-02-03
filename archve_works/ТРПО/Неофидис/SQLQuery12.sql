
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Отображение студентов по среднему баллу]
	
	@Grade Real = 0

AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT*
	FROM[Запрос Студенты+Оценки]
	WHERE([Оценка первого экзамена]+[Оценка второго экзамена]+[Оценка третьего экзамена])/3>@Grade
  
END
GO
