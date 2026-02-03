SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [Индикатор изменения]
    ON dbo.Студенты         
	AFTER UPDATE
AS 
BEGIN
     SET NOCOUNT ON;
	 PRINT 'Запись изменена'
END
GO


