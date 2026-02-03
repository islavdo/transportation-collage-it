SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [Удаление Студента]
ON dbo.Студенты
INSTEAD OF DELETE
AS 

BEGIN
  SET NOCOUNT ON;
  DELETE dbo.Оценки
  FROM Deleted
  WHERE Deleted.[Код Студента]=Оценки.[Код Студента]
  DELETE dbo.Студенты
  FROM Deleted
  WHERE Deleted.[Код Студента]=Студенты.[Код Студента]
END
GO


