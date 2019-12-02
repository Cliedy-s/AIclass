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
-- Description:	자재와 자재타입을 합친 테이블을 가져오는 프로시저
-- =============================================
-- EXEC dbo.GetAllMaterials
CREATE PROCEDURE GetAllMaterials
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 
	m.mat_No, m.mtt_No, m.off_No, m.mat_Name, m.mat_Cost, m.mat_Each, m.mat_MinSize, mt.mtt_No, mt.mtt_Name
	FROM Materials m INNER JOIN Materials_Type mt ON m.mtt_No = mt.mtt_No
END
GO
