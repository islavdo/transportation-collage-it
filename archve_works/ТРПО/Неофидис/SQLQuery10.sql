
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Отображение студентов по ФИО]
	
	@FIO Varchar(50)=''
	
AS
BEGIN
	
	SET NOCOUNT ON;
 
	SELECT*
FROM dbo.Студенты
WHERE ФИО=@FIO 
END
GO
