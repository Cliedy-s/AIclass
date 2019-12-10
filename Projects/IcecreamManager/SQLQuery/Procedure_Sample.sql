-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
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
CREATE PROCEDURE RegisterEmployee_04 
	@LastName nvarchar(20), 
	@FirstName nvarchar(10), 
	@Title nvarchar(30), 
	@BirthDate nvarchar(10), 
	@HireDate nvarchar(10), 
	@HomePhone nvarchar(24), 
	@Photo image,
	@Notes ntext
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	-- SET NOCOUNT ON; -- select에서만 함

    -- Insert statements for procedure here
	insert into Employees(LastName, FirstName, Title, BirthDate, HireDate, HomePhone, Notes) 
	values(@LastName, @FirstName, @Title, @BirthDate, @HireDate, @HomePhone, @Notes)
END
GO
