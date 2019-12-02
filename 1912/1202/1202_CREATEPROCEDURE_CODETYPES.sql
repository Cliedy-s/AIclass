USE [Northwind]
GO
/****** Object:  StoredProcedure [dbo].[GetCodeInfoByCodeTypes]    Script Date: 2019-11-30 오후 3:31:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>

-- EXEC GetCodeInfoByCodeTypes 'Categories@Customers@Employees@Products@Shippers', '@'
-- =============================================
CREATE PROCEDURE [dbo].[GetCodeInfoByCodeTypes_04] 
	-- Add the parameters for the stored procedure here
	@P_CodeTypes NVARCHAR(100), -- ORACLE만 배열타입이 존재
	@P_Separator NVARCHAR(1)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

  --   select Code, CodeNm, PCode, CodeType 
	 -- from VW_NorthWindCode_04
	 --where CodeType in ('Categories','Customers','Employees','Products','Shippers')

	 --select Code, CodeNm, PCode, CodeType 
	 -- from VW_NorthWindCode_04
	 --where CodeType in ( Select Value from STRING_SPLIT('Categories@Customers@Employees@Products@Shippers', '@')) --2016 부터 있는 함수 STRING_SPLIT

	--select Code, CodeNm, PCode, CodeType 
	--  from VW_NorthWindCode_04
	-- where CodeType in (select Item from dbo.SplitString('Categories@Customers@Employees@Products@Shippers', '@'))

	select Code, CodeNm, PCode, CodeType 
	  from VW_NorthWindCode_04
	 where CodeType in (select Item from dbo.SplitString(@P_CodeTypes, @P_Separator))

END
