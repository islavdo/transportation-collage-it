
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Отображение студентов по возрасту]
	@Age int = 0
AS
BEGIN
	
	SET NOCOUNT ON;
	SELECT ФИО,
	[Запрос Студенты+Специальности] . [Дата рождения],
	'Возраст'=DATEDIFF(yy[Запрос Студенты+Специальности].[Дата рождения],GETDATE())
	FROM[Запрос Студенты+Специальности]
	WHERE DATEDIFF([Запрос Студенты+Специальности].[Дата рождения],GETDATE())>@Age
    
END
GO
