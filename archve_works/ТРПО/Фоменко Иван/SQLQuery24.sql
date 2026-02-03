-- ================================================
-- Template generated from Template Explorer using:
-- Create Scalar Function (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
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
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION [Функция отбора по возрасту] 
(
	-- Add the parameters for the function here
)
RETURNS TABLE
AS
RETURN
(
	SELECT ФИО,[Дата рождения], Возраст = DateDiff (yy, [дата рождения], GetDate())
	FROM Студенты

)
GO

