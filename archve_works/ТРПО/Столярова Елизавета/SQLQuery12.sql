SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [Удаление студента]
    ON dbo.Студенты
	INSTEAD OF DELETE
AS 
BEGIN
    SET NOCOUNT ON;
	DELETE dbo.Оценки
	FROM deleted
	WHERE deleted.[Код студента]=Оценки.[Код студента]
	DELETE dbo.Студенты
	FROM deleted
	WHERE deleted.[Код студента]=Студенты.[Код студента]
   
END
GO


