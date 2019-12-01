USE [anyform]
GO
/****** Object:  StoredProcedure [dbo].[anyBOM]    Script Date: 2019-11-26 오후 10:39:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[anyBOM]
(          
  @P_ITEM           VARCHAR(10)
)          
AS          
BEGIN          
           
/****************************************************************************************          
Description : anyBOM BOM 상세목록

Paramters (프로시저 파라미터에 대한 설명)    
@P_ITEM           품목명
           
사용 예: 
EXEC [dbo].[anyBOM] 'P0001'

History          
2016.01.10. 최초생성 written by http://www.anyform.o.kr      
****************************************************************************************/          
           
Set NoCount On          
           
--1.변수선언 및 초기화 (Variables)  
--1.1.Parameter variables
DECLARE @V_ITEM           VARCHAR(10);

--1.2.Variable Initialize
SET @V_ITEM  = IsNull(LTrim(RTrim(@P_ITEM)),'');

WITH BOM (ITEM, BOMITEM, BOM_QTY, LEVEL, handle)
AS (
SELECT A.ITEM
     , A.BOMITEM
	 , A.BOM_QTY
	 , 0 as LEVEL
	 , CONVERT(INTEGER,NULL) handle
  FROM ANY030 A
 WHERE A.BOMITEM = '*'
   AND A.ITEM    = @V_ITEM
UNION ALL
SELECT A.ITEM
     , A.BOMITEM
	 , A.BOM_QTY as BOM_QTY
	 , LEVEL + 1 as LEVEL
	 , CONVERT(INTEGER,NULL) handle
  FROM ANY030 A
       INNER JOIN BOM as B ON A.BOMITEM = B.ITEM
)
SELECT P.ITEM
     , P.BOMITEM
     , Q.NAME ITEM_NAME
	 , P.BOM_QTY
	 , P.LEVEL
	 , ISNULL(P.ITEM,'****') + ' ' + ISNULL(Q.NAME,'****') + ' [ ' +  + LTRIM(RTRIM(STR(ISNULL(P.BOM_QTY,0)))) + ' ]' as ITEM_DISP
	 , P.handle
  FROM BOM as P
       LEFT OUTER JOIN ANY020 Q ON P.ITEM = Q.ITEM;
           
END

