SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER [Удаление Студента]
	ON [dbo].[Студенты]
	INSTEAD OF DELETE
AS 

BEGIN
  SET NOCOUNT ON;
  DELETE dbo.Оценки
  FROM Deleted
  WHERE Deleted.[код студента]=Оценки.[код студента]
  DELETE dbo.Студенты
  FROM Deleted
  WHERE Deleted.[код студента]=Студенты.[код студента]
END
