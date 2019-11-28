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
-- Author:		신소연
-- Create date: 11/27
-- Description:	BOM과 Materials를 연결함 // 수정해야함
-- =============================================
-- EXEC dbo.GetAllMaterials
CREATE PROCEDURE GetConnectedBOMMaterials
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 
	m.mat_No, m.mat_Name, mt.mtt_Name 
	FROM Materials m
		INNER JOIN Materials_Type mt ON m.mtt_No = mt.mtt_No
		LEFT OUTER JOIN BOM b ON m.mat_No = b.mat_ChildNo
END
GO
