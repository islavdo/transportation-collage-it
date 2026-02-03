-- ================================================
-- Template generated from Template Explorer using:
-- Create Trigger (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- See additional Create Trigger templates for more
-- examples of different Trigger statements.
--
-- This block of comments will not be included in
-- the definition of the function.
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
CREATE TRIGGER [удаление студента]
   ON dbo.Table_студенты
  INSTEAD OF DELETE 
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	
	SET NOCOUNT ON;

    -- Insert statements for trigger here
	DELETE dbo.Table_Оценки
FROM Deleted
WHERE Deleted.[Код студента] = dbo.Table_оценки.[Код студента]
DELETE dbo.Table_студенты 
FROM Deleted
WHERE Deleted.[Код студента] =  dbo.Table_студенты.[Код студента]
END
GO
