USE [TEAM4]
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Product', @level2type=N'COLUMN',@level2name=N'pro_Img'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Product', @level2type=N'COLUMN',@level2name=N'pro_Price'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Product', @level2type=N'COLUMN',@level2name=N'mat_No'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Product', @level2type=N'COLUMN',@level2name=N'pro_Name'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Product', @level2type=N'COLUMN',@level2name=N'pro_No'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Offerer', @level2type=N'COLUMN',@level2name=N'off_Addr'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Offerer', @level2type=N'COLUMN',@level2name=N'off_ManagerMobile'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Offerer', @level2type=N'COLUMN',@level2name=N'off_Manager'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Offerer', @level2type=N'COLUMN',@level2name=N'off_OwnerMobile'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Offerer', @level2type=N'COLUMN',@level2name=N'off_OwnerName'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Offerer', @level2type=N'COLUMN',@level2name=N'off_Name'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Offerer', @level2type=N'COLUMN',@level2name=N'off_No'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Materials_Type', @level2type=N'COLUMN',@level2name=N'mtt_Name'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Materials_Type', @level2type=N'COLUMN',@level2name=N'mtt_No'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Materials', @level2type=N'COLUMN',@level2name=N'mat_Unit'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Materials', @level2type=N'COLUMN',@level2name=N'mat_MinSize'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Materials', @level2type=N'COLUMN',@level2name=N'mat_Each'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Materials', @level2type=N'COLUMN',@level2name=N'mat_Cost'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Materials', @level2type=N'COLUMN',@level2name=N'mat_Name'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Materials', @level2type=N'COLUMN',@level2name=N'off_No'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Materials', @level2type=N'COLUMN',@level2name=N'mtt_No'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Materials', @level2type=N'COLUMN',@level2name=N'mat_No'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer_Order_Detail', @level2type=N'COLUMN',@level2name=N'cod_Each'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer_Order_Detail', @level2type=N'COLUMN',@level2name=N'pro_No'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer_Order_Detail', @level2type=N'COLUMN',@level2name=N'cuo_No'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer_Order_Detail', @level2type=N'COLUMN',@level2name=N'cod_No'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer_Order', @level2type=N'COLUMN',@level2name=N'cuo_TotalPrice'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer_Order', @level2type=N'COLUMN',@level2name=N'cuo_Datetime'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer_Order', @level2type=N'COLUMN',@level2name=N'cus_No'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer_Order', @level2type=N'COLUMN',@level2name=N'cuo_No'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'IsManager'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'cus_Email'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'cus_Addr'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'cus_Phone'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'cus_Name'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'cus_Password'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'cus_Id'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'cus_No'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CompleteType', @level2type=N'COLUMN',@level2name=N'cmt_Type'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CompleteType', @level2type=N'COLUMN',@level2name=N'cmt_No'
GO
/****** Object:  StoredProcedure [dbo].[UpdateOfferer_Order]    Script Date: 2019-12-13 오전 10:33:02 ******/
DROP PROCEDURE [dbo].[UpdateOfferer_Order]
GO
/****** Object:  StoredProcedure [dbo].[UpdateBOM]    Script Date: 2019-12-13 오전 10:33:02 ******/
DROP PROCEDURE [dbo].[UpdateBOM]
GO
/****** Object:  StoredProcedure [dbo].[Update_Order]    Script Date: 2019-12-13 오전 10:33:02 ******/
DROP PROCEDURE [dbo].[Update_Order]
GO
/****** Object:  StoredProcedure [dbo].[TempProcedure]    Script Date: 2019-12-13 오전 10:33:02 ******/
DROP PROCEDURE [dbo].[TempProcedure]
GO
/****** Object:  StoredProcedure [dbo].[ProductsDelete]    Script Date: 2019-12-13 오전 10:33:02 ******/
DROP PROCEDURE [dbo].[ProductsDelete]
GO
/****** Object:  StoredProcedure [dbo].[MaterialsInsert_Update_GetID]    Script Date: 2019-12-13 오전 10:33:02 ******/
DROP PROCEDURE [dbo].[MaterialsInsert_Update_GetID]
GO
/****** Object:  StoredProcedure [dbo].[MaterialsInsert_Update]    Script Date: 2019-12-13 오전 10:33:02 ******/
DROP PROCEDURE [dbo].[MaterialsInsert_Update]
GO
/****** Object:  StoredProcedure [dbo].[MaterialsDelete]    Script Date: 2019-12-13 오전 10:33:02 ******/
DROP PROCEDURE [dbo].[MaterialsDelete]
GO
/****** Object:  StoredProcedure [dbo].[MaterialEachUpdate]    Script Date: 2019-12-13 오전 10:33:02 ******/
DROP PROCEDURE [dbo].[MaterialEachUpdate]
GO
/****** Object:  StoredProcedure [dbo].[IsProductNosValid]    Script Date: 2019-12-13 오전 10:33:02 ******/
DROP PROCEDURE [dbo].[IsProductNosValid]
GO
/****** Object:  StoredProcedure [dbo].[InsertOrder]    Script Date: 2019-12-13 오전 10:33:02 ******/
DROP PROCEDURE [dbo].[InsertOrder]
GO
/****** Object:  StoredProcedure [dbo].[InsertBOM]    Script Date: 2019-12-13 오전 10:33:02 ******/
DROP PROCEDURE [dbo].[InsertBOM]
GO
/****** Object:  StoredProcedure [dbo].[GetUser]    Script Date: 2019-12-13 오전 10:33:02 ******/
DROP PROCEDURE [dbo].[GetUser]
GO
/****** Object:  StoredProcedure [dbo].[GetAllSubOrder]    Script Date: 2019-12-13 오전 10:33:02 ******/
DROP PROCEDURE [dbo].[GetAllSubOrder]
GO
/****** Object:  StoredProcedure [dbo].[GetAllProductMaterialConnect]    Script Date: 2019-12-13 오전 10:33:02 ******/
DROP PROCEDURE [dbo].[GetAllProductMaterialConnect]
GO
/****** Object:  StoredProcedure [dbo].[GetAllProduct]    Script Date: 2019-12-13 오전 10:33:02 ******/
DROP PROCEDURE [dbo].[GetAllProduct]
GO
/****** Object:  StoredProcedure [dbo].[GetAllOrder]    Script Date: 2019-12-13 오전 10:33:02 ******/
DROP PROCEDURE [dbo].[GetAllOrder]
GO
/****** Object:  StoredProcedure [dbo].[GetAllOffereData]    Script Date: 2019-12-13 오전 10:33:02 ******/
DROP PROCEDURE [dbo].[GetAllOffereData]
GO
/****** Object:  StoredProcedure [dbo].[GetAllMaterialsType]    Script Date: 2019-12-13 오전 10:33:02 ******/
DROP PROCEDURE [dbo].[GetAllMaterialsType]
GO
/****** Object:  StoredProcedure [dbo].[GetAllMaterialsNotExistInProduct]    Script Date: 2019-12-13 오전 10:33:02 ******/
DROP PROCEDURE [dbo].[GetAllMaterialsNotExistInProduct]
GO
/****** Object:  StoredProcedure [dbo].[GetAllMaterials]    Script Date: 2019-12-13 오전 10:33:02 ******/
DROP PROCEDURE [dbo].[GetAllMaterials]
GO
/****** Object:  StoredProcedure [dbo].[GetAllByIDsList]    Script Date: 2019-12-13 오전 10:33:02 ******/
DROP PROCEDURE [dbo].[GetAllByIDsList]
GO
/****** Object:  StoredProcedure [dbo].[GetAllBOMMaterialsByParentNo]    Script Date: 2019-12-13 오전 10:33:02 ******/
DROP PROCEDURE [dbo].[GetAllBOMMaterialsByParentNo]
GO
/****** Object:  StoredProcedure [dbo].[GetAllBOMExistMaterialList]    Script Date: 2019-12-13 오전 10:33:02 ******/
DROP PROCEDURE [dbo].[GetAllBOMExistMaterialList]
GO
/****** Object:  StoredProcedure [dbo].[GetAllBOMExistChilds]    Script Date: 2019-12-13 오전 10:33:02 ******/
DROP PROCEDURE [dbo].[GetAllBOMExistChilds]
GO
/****** Object:  StoredProcedure [dbo].[GetAllBOM]    Script Date: 2019-12-13 오전 10:33:02 ******/
DROP PROCEDURE [dbo].[GetAllBOM]
GO
ALTER TABLE [dbo].[Product] DROP CONSTRAINT [fk_pro_matNo]
GO
ALTER TABLE [dbo].[Offerer_Order] DROP CONSTRAINT [fk_ofo_offNo]
GO
ALTER TABLE [dbo].[Offerer_Order] DROP CONSTRAINT [fk_ofo_matNo]
GO
ALTER TABLE [dbo].[Offerer_Order] DROP CONSTRAINT [fk_ofo_cmtNo]
GO
ALTER TABLE [dbo].[Materials] DROP CONSTRAINT [fk_mat_offName]
GO
ALTER TABLE [dbo].[Materials] DROP CONSTRAINT [fk_mat_mttType]
GO
ALTER TABLE [dbo].[Customer_Order_Detail] DROP CONSTRAINT [FK_Customer_Order_Detail_Product]
GO
ALTER TABLE [dbo].[Customer_Order_Detail] DROP CONSTRAINT [FK_Customer_Order_Detail_Customer_Order]
GO
ALTER TABLE [dbo].[Customer_Order] DROP CONSTRAINT [fk_cmo_cusNo]
GO
ALTER TABLE [dbo].[BOM] DROP CONSTRAINT [fk_bom_ParentNo]
GO
ALTER TABLE [dbo].[BOM] DROP CONSTRAINT [fk_bom_ChildNo]
GO
ALTER TABLE [dbo].[Materials] DROP CONSTRAINT [DF_Materials_mat_MinSize]
GO
ALTER TABLE [dbo].[Materials] DROP CONSTRAINT [DF__Materials__mat_E__498EEC8D]
GO
ALTER TABLE [dbo].[Customer_Order] DROP CONSTRAINT [DF__Customer___cus_o__531856C7]
GO
ALTER TABLE [dbo].[Customer] DROP CONSTRAINT [DF__Customer__aut_No__41EDCAC5]
GO
ALTER TABLE [dbo].[BOM] DROP CONSTRAINT [DF__BOM__bom_ChildEa__1B29035F]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 2019-12-13 오전 10:33:02 ******/
DROP TABLE [dbo].[Product]
GO
/****** Object:  Table [dbo].[Offerer_Order]    Script Date: 2019-12-13 오전 10:33:02 ******/
DROP TABLE [dbo].[Offerer_Order]
GO
/****** Object:  Table [dbo].[Offerer]    Script Date: 2019-12-13 오전 10:33:02 ******/
DROP TABLE [dbo].[Offerer]
GO
/****** Object:  Table [dbo].[Materials_Type]    Script Date: 2019-12-13 오전 10:33:02 ******/
DROP TABLE [dbo].[Materials_Type]
GO
/****** Object:  Table [dbo].[Customer_Order_Detail]    Script Date: 2019-12-13 오전 10:33:02 ******/
DROP TABLE [dbo].[Customer_Order_Detail]
GO
/****** Object:  Table [dbo].[Customer_Order]    Script Date: 2019-12-13 오전 10:33:02 ******/
DROP TABLE [dbo].[Customer_Order]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 2019-12-13 오전 10:33:02 ******/
DROP TABLE [dbo].[Customer]
GO
/****** Object:  Table [dbo].[CompleteType]    Script Date: 2019-12-13 오전 10:33:02 ******/
DROP TABLE [dbo].[CompleteType]
GO
/****** Object:  View [dbo].[vw_temp]    Script Date: 2019-12-13 오전 10:33:02 ******/
DROP VIEW [dbo].[vw_temp]
GO
/****** Object:  Table [dbo].[Materials]    Script Date: 2019-12-13 오전 10:33:02 ******/
DROP TABLE [dbo].[Materials]
GO
/****** Object:  Table [dbo].[BOM]    Script Date: 2019-12-13 오전 10:33:02 ******/
DROP TABLE [dbo].[BOM]
GO
/****** Object:  UserDefinedFunction [dbo].[SplitString]    Script Date: 2019-12-13 오전 10:33:02 ******/
DROP FUNCTION [dbo].[SplitString]
GO
/****** Object:  User [team4]    Script Date: 2019-12-13 오전 10:33:02 ******/
DROP USER [team4]
GO
USE [master]
GO
/****** Object:  Database [TEAM4]    Script Date: 2019-12-13 오전 10:33:02 ******/
DROP DATABASE [TEAM4]
GO
/****** Object:  Database [TEAM4]    Script Date: 2019-12-13 오전 10:33:02 ******/
CREATE DATABASE [TEAM4]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TEAM4', FILENAME = N'D:\sqlserver\MSSQL14.MSSQLSERVER\MSSQL\DATA\TEAM4.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TEAM4_log', FILENAME = N'D:\sqlserver\MSSQL14.MSSQLSERVER\MSSQL\DATA\TEAM4_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [TEAM4] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TEAM4].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TEAM4] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TEAM4] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TEAM4] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TEAM4] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TEAM4] SET ARITHABORT OFF 
GO
ALTER DATABASE [TEAM4] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TEAM4] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TEAM4] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TEAM4] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TEAM4] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TEAM4] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TEAM4] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TEAM4] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TEAM4] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TEAM4] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TEAM4] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TEAM4] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TEAM4] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TEAM4] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TEAM4] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TEAM4] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TEAM4] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TEAM4] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TEAM4] SET  MULTI_USER 
GO
ALTER DATABASE [TEAM4] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TEAM4] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TEAM4] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TEAM4] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TEAM4] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'TEAM4', N'ON'
GO
ALTER DATABASE [TEAM4] SET QUERY_STORE = OFF
GO
USE [TEAM4]
GO
/****** Object:  User [team4]    Script Date: 2019-12-13 오전 10:33:04 ******/
CREATE USER [team4] FOR LOGIN [team4] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [team4]
GO
/****** Object:  UserDefinedFunction [dbo].[SplitString]    Script Date: 2019-12-13 오전 10:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>

-- select Item from dbo.SplitString('Categories@Customers@Employees@Products@Shippers@Suppliers', '@')
-- =============================================
Create FUNCTION [dbo].[SplitString]
(    
      @Input NVARCHAR(MAX),
      @Character CHAR(1)
)
RETURNS @Output TABLE (
      Item NVARCHAR(1000)
)
AS
BEGIN
      DECLARE @StartIndex INT, @EndIndex INT

      SET @StartIndex = 1
      IF SUBSTRING(@Input, LEN(@Input) - 1, LEN(@Input)) <> @Character
      BEGIN
            SET @Input = @Input + @Character
      END

      WHILE CHARINDEX(@Character, @Input) > 0
      BEGIN
            SET @EndIndex = CHARINDEX(@Character, @Input)

            INSERT INTO @Output(Item)
            SELECT SUBSTRING(@Input, @StartIndex, @EndIndex - 1)

            SET @Input = SUBSTRING(@Input, @EndIndex + 1, LEN(@Input))
      END

      RETURN
END
GO
/****** Object:  Table [dbo].[BOM]    Script Date: 2019-12-13 오전 10:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BOM](
	[mat_ParentNo] [int] NOT NULL,
	[mat_ChildNo] [int] NOT NULL,
	[bom_ChildEach] [int] NOT NULL,
	[bom_ChildUnit] [nvarchar](4) NULL,
 CONSTRAINT [PK_BOM] PRIMARY KEY CLUSTERED 
(
	[mat_ParentNo] ASC,
	[mat_ChildNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Materials]    Script Date: 2019-12-13 오전 10:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Materials](
	[mat_No] [int] IDENTITY(2000,1) NOT NULL,
	[mtt_No] [int] NOT NULL,
	[off_No] [int] NULL,
	[mat_Name] [nvarchar](50) NOT NULL,
	[mat_Cost] [int] NULL,
	[mat_Each] [int] NOT NULL,
	[mat_MinSize] [int] NOT NULL,
	[mat_Unit] [nvarchar](4) NOT NULL,
 CONSTRAINT [PK__Material__FCB0C1BC7C4896B2] PRIMARY KEY CLUSTERED 
(
	[mat_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_temp]    Script Date: 2019-12-13 오전 10:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	CREATE VIEW [dbo].[vw_temp] AS 
	(SELECT m.mat_No, m.mat_Name, m.mat_Cost, m.mat_Each, m.mtt_No, m.off_No, m.mat_MinSize, mat_ParentNo, mat_ChildNo, bom_ChildEach
					FROM BOM b 
					RIGHT OUTER JOIN Materials m ON b.mat_ChildNo = m.mat_No)
GO
/****** Object:  Table [dbo].[CompleteType]    Script Date: 2019-12-13 오전 10:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompleteType](
	[cmt_No] [int] IDENTITY(1,1) NOT NULL,
	[cmt_Type] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cmt_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 2019-12-13 오전 10:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[cus_No] [int] IDENTITY(5000,1) NOT NULL,
	[cus_Id] [nvarchar](50) NOT NULL,
	[cus_Password] [nvarchar](50) NOT NULL,
	[cus_Name] [nvarchar](20) NOT NULL,
	[cus_Phone] [nvarchar](13) NULL,
	[cus_Addr] [nvarchar](100) NULL,
	[cus_Email] [nvarchar](100) NULL,
	[IsManager] [bit] NOT NULL,
 CONSTRAINT [PK__Customer__E8425A3F99843692] PRIMARY KEY CLUSTERED 
(
	[cus_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer_Order]    Script Date: 2019-12-13 오전 10:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer_Order](
	[cuo_No] [int] IDENTITY(6000,1) NOT NULL,
	[cus_No] [int] NOT NULL,
	[cuo_Datetime] [datetime] NOT NULL,
	[cuo_TotalPrice] [int] NOT NULL,
 CONSTRAINT [PK__Customer__9D57A5DE2BF8C30E] PRIMARY KEY CLUSTERED 
(
	[cuo_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer_Order_Detail]    Script Date: 2019-12-13 오전 10:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer_Order_Detail](
	[cod_No] [int] IDENTITY(7000,1) NOT NULL,
	[cuo_No] [int] NOT NULL,
	[pro_No] [int] NOT NULL,
	[cod_Each] [int] NOT NULL,
 CONSTRAINT [PK_Customer_Order_Detail] PRIMARY KEY CLUSTERED 
(
	[cod_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Materials_Type]    Script Date: 2019-12-13 오전 10:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Materials_Type](
	[mtt_No] [int] IDENTITY(1,1) NOT NULL,
	[mtt_Name] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK__Material__3EA8A68CA6CFEE84] PRIMARY KEY CLUSTERED 
(
	[mtt_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Offerer]    Script Date: 2019-12-13 오전 10:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Offerer](
	[off_No] [int] IDENTITY(3000,1) NOT NULL,
	[off_Name] [nvarchar](50) NOT NULL,
	[off_OwnerName] [nvarchar](20) NOT NULL,
	[off_OwnerMobile] [nvarchar](13) NOT NULL,
	[off_Manager] [nvarchar](20) NOT NULL,
	[off_ManagerMobile] [nvarchar](13) NOT NULL,
	[off_Addr] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK__Offerer__9E1B417983AB7322] PRIMARY KEY CLUSTERED 
(
	[off_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Offerer_Order]    Script Date: 2019-12-13 오전 10:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Offerer_Order](
	[ofo_No] [int] IDENTITY(1,1) NOT NULL,
	[ofo_Each] [int] NOT NULL,
	[mat_No] [int] NOT NULL,
	[off_No] [int] NOT NULL,
	[cmt_No] [int] NOT NULL,
	[ofo_Price] [int] NOT NULL,
	[ofo_Date] [datetime] NOT NULL,
 CONSTRAINT [PK__Offerer___DFF3D63904E72299] PRIMARY KEY CLUSTERED 
(
	[ofo_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 2019-12-13 오전 10:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[pro_No] [int] IDENTITY(1000,1) NOT NULL,
	[pro_Name] [nvarchar](50) NOT NULL,
	[mat_No] [int] NOT NULL,
	[pro_Price] [int] NULL,
	[pro_Img] [image] NULL,
 CONSTRAINT [PK__Product__335D2B351C383BB9] PRIMARY KEY CLUSTERED 
(
	[pro_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[BOM] ADD  DEFAULT ((0)) FOR [bom_ChildEach]
GO
ALTER TABLE [dbo].[Customer] ADD  CONSTRAINT [DF__Customer__aut_No__41EDCAC5]  DEFAULT ((0)) FOR [IsManager]
GO
ALTER TABLE [dbo].[Customer_Order] ADD  CONSTRAINT [DF__Customer___cus_o__531856C7]  DEFAULT (getdate()) FOR [cuo_Datetime]
GO
ALTER TABLE [dbo].[Materials] ADD  CONSTRAINT [DF__Materials__mat_E__498EEC8D]  DEFAULT ((0)) FOR [mat_Each]
GO
ALTER TABLE [dbo].[Materials] ADD  CONSTRAINT [DF_Materials_mat_MinSize]  DEFAULT ((10000)) FOR [mat_MinSize]
GO
ALTER TABLE [dbo].[BOM]  WITH CHECK ADD  CONSTRAINT [fk_bom_ChildNo] FOREIGN KEY([mat_ChildNo])
REFERENCES [dbo].[Materials] ([mat_No])
GO
ALTER TABLE [dbo].[BOM] CHECK CONSTRAINT [fk_bom_ChildNo]
GO
ALTER TABLE [dbo].[BOM]  WITH CHECK ADD  CONSTRAINT [fk_bom_ParentNo] FOREIGN KEY([mat_ParentNo])
REFERENCES [dbo].[Materials] ([mat_No])
GO
ALTER TABLE [dbo].[BOM] CHECK CONSTRAINT [fk_bom_ParentNo]
GO
ALTER TABLE [dbo].[Customer_Order]  WITH CHECK ADD  CONSTRAINT [fk_cmo_cusNo] FOREIGN KEY([cus_No])
REFERENCES [dbo].[Customer] ([cus_No])
GO
ALTER TABLE [dbo].[Customer_Order] CHECK CONSTRAINT [fk_cmo_cusNo]
GO
ALTER TABLE [dbo].[Customer_Order_Detail]  WITH CHECK ADD  CONSTRAINT [FK_Customer_Order_Detail_Customer_Order] FOREIGN KEY([cuo_No])
REFERENCES [dbo].[Customer_Order] ([cuo_No])
GO
ALTER TABLE [dbo].[Customer_Order_Detail] CHECK CONSTRAINT [FK_Customer_Order_Detail_Customer_Order]
GO
ALTER TABLE [dbo].[Customer_Order_Detail]  WITH CHECK ADD  CONSTRAINT [FK_Customer_Order_Detail_Product] FOREIGN KEY([pro_No])
REFERENCES [dbo].[Product] ([pro_No])
GO
ALTER TABLE [dbo].[Customer_Order_Detail] CHECK CONSTRAINT [FK_Customer_Order_Detail_Product]
GO
ALTER TABLE [dbo].[Materials]  WITH CHECK ADD  CONSTRAINT [fk_mat_mttType] FOREIGN KEY([mtt_No])
REFERENCES [dbo].[Materials_Type] ([mtt_No])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Materials] CHECK CONSTRAINT [fk_mat_mttType]
GO
ALTER TABLE [dbo].[Materials]  WITH CHECK ADD  CONSTRAINT [fk_mat_offName] FOREIGN KEY([off_No])
REFERENCES [dbo].[Offerer] ([off_No])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Materials] CHECK CONSTRAINT [fk_mat_offName]
GO
ALTER TABLE [dbo].[Offerer_Order]  WITH CHECK ADD  CONSTRAINT [fk_ofo_cmtNo] FOREIGN KEY([cmt_No])
REFERENCES [dbo].[CompleteType] ([cmt_No])
GO
ALTER TABLE [dbo].[Offerer_Order] CHECK CONSTRAINT [fk_ofo_cmtNo]
GO
ALTER TABLE [dbo].[Offerer_Order]  WITH CHECK ADD  CONSTRAINT [fk_ofo_matNo] FOREIGN KEY([mat_No])
REFERENCES [dbo].[Materials] ([mat_No])
GO
ALTER TABLE [dbo].[Offerer_Order] CHECK CONSTRAINT [fk_ofo_matNo]
GO
ALTER TABLE [dbo].[Offerer_Order]  WITH CHECK ADD  CONSTRAINT [fk_ofo_offNo] FOREIGN KEY([off_No])
REFERENCES [dbo].[Offerer] ([off_No])
GO
ALTER TABLE [dbo].[Offerer_Order] CHECK CONSTRAINT [fk_ofo_offNo]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [fk_pro_matNo] FOREIGN KEY([mat_No])
REFERENCES [dbo].[Materials] ([mat_No])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [fk_pro_matNo]
GO
/****** Object:  StoredProcedure [dbo].[GetAllBOM]    Script Date: 2019-12-13 오전 10:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetAllBOM]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT  mat_ParentNo, mat_ChildNo, bom_ChildEach, bom_ChildUnit from BOM
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllBOMExistChilds]    Script Date: 2019-12-13 오전 10:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetAllBOMExistChilds]
	@parentValues NVARCHAR(1000),
	@sep NVARCHAR(1)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT mat_ParentNo,mat_ChildNo, bom_ChildEach, mat_No, off_No ,mat_Name, mat_Cost, mat_Each, mat_MinSize, mt.mtt_No, mtt_Name, mat_Unit
	FROM Materials m
		INNER JOIN BOM b ON m.mat_No = b.mat_ChildNo
		INNER JOIN Materials_Type mt ON mt.mtt_No = m.mtt_No
	WHERE b.mat_ParentNo in (select CONVERT(INT,item) from [dbo].[SplitString](@parentValues, @sep));

END
GO
/****** Object:  StoredProcedure [dbo].[GetAllBOMExistMaterialList]    Script Date: 2019-12-13 오전 10:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		신소연
-- Create date: 2019-12-09
-- Description:	BOM에 존재하는 모든 완제품
-- =============================================
CREATE PROCEDURE [dbo].[GetAllBOMExistMaterialList]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT m.[mat_No], mt.[mtt_No], m.[off_No], m.[mat_Name], m.[mat_Cost], m.[mat_Each], m.[mat_MinSize], m.[mat_Unit], mt.mtt_Name
	FROM (SELECT [mat_No], [mtt_No], [off_No], [mat_Name], [mat_Cost], [mat_Each], [mat_MinSize], [mat_Unit] FROM Materials WHERE mtt_No = 1) m
		INNER JOIN Materials_Type mt ON m.mtt_No = mt.mtt_No
		INNER JOIN (SELECT DISTINCT mat_ParentNo FROM BOM) b ON m.mat_No = b.mat_ParentNo

END
GO
/****** Object:  StoredProcedure [dbo].[GetAllBOMMaterialsByParentNo]    Script Date: 2019-12-13 오전 10:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		신소연
-- Create date: 12/11
-- Description:	부모No로 자식 목록을 가져와 Materials와 합쳐 리턴하는 프로시져
-- =============================================
CREATE PROCEDURE [dbo].[GetAllBOMMaterialsByParentNo]
@mat_ParentNo int
AS
BEGIN
	SET NOCOUNT ON; 
		SELECT m.mat_No, m.mat_Name, m.mat_Cost, m.mat_Each,m.mat_Unit, m.mtt_No, m.off_No, m.mat_MinSize, mat_ParentNo, mat_ChildNo, bom_ChildEach,bom_ChildUnit, mt.mtt_Name
	 FROM ( SELECT mat_ParentNo, mat_ChildNo, bom_ChildEach,bom_ChildUnit FROM BOM WHERE mat_ParentNo = @mat_ParentNo ) b 
		INNER JOIN Materials m ON b.mat_ChildNo = m.mat_No 
		INNER JOIN Materials_Type mt ON m.mtt_No = mt.mtt_No
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllByIDsList]    Script Date: 2019-12-13 오전 10:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name> GetAllByIDsList
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetAllByIDsList]
	@parentValues NVARCHAR(100),
	@sep NVARCHAR(1)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT mat_No, off_No ,mat_Name, mat_Cost, mat_Each, mat_MinSize, mt.mtt_No, mtt_Name, mat_Unit
	FROM Materials m
		INNER JOIN Materials_Type mt ON mt.mtt_No = m.mtt_No
	WHERE m.mat_No in (select CONVERT(INT,item) from [dbo].[SplitString](@parentValues, @sep));
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllMaterials]    Script Date: 2019-12-13 오전 10:33:04 ******/
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
CREATE PROCEDURE [dbo].[GetAllMaterials]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT m.mat_No, m.off_No, m.mat_Name, m.mat_Cost, m.mat_Each, m.mat_MinSize,m.mtt_No, mt.mtt_Name,m.mat_Unit
	FROM Materials m INNER JOIN Materials_Type mt ON m.mtt_No = mt.mtt_No
	

	--SELECT m.mat_No, m.off_No, m.mat_Name, m.mat_Cost, m.mat_Each, m.mat_MinSize,m.mtt_No, mt.mtt_Name,m.mat_Unit
	--FROM Materials m INNER JOIN Materials_Type mt ON m.mtt_No = mt.mtt_No 
	
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllMaterialsNotExistInProduct]    Script Date: 2019-12-13 오전 10:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		신소연
-- Create date: 12/11
-- Description:	완제품이며 Product 테이블에 존재하지 않는 완제품을 가져온다.
-- =============================================
CREATE PROCEDURE [dbo].[GetAllMaterialsNotExistInProduct]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT m.[mat_No], mt.[mtt_No], m.[off_No], m.[mat_Name], m.[mat_Cost], m.[mat_Each], m.[mat_MinSize], m.[mat_Unit], mt.mtt_Name
	FROM (SELECT [mat_No], [mtt_No], [off_No], [mat_Name], [mat_Cost], [mat_Each], [mat_MinSize], [mat_Unit] FROM Materials WHERE mtt_No = 1) m
		INNER JOIN Materials_Type mt ON m.mtt_No = mt.mtt_No
		INNER JOIN (SELECT DISTINCT mat_ParentNo FROM BOM) b ON m.mat_No = b.mat_ParentNo
	WHERE NOT EXISTS (SELECT 'EXIST' FROM Product p WHERE p.mat_No = m.mat_No)

END
GO
/****** Object:  StoredProcedure [dbo].[GetAllMaterialsType]    Script Date: 2019-12-13 오전 10:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		박상인
-- Create date: 2019.12.10
-- Description:	자제타입
-- =============================================
CREATE PROCEDURE [dbo].[GetAllMaterialsType]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select mtt_No,mtt_Name from Materials_Type
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllOffereData]    Script Date: 2019-12-13 오전 10:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		박상인
-- Create date: 12.04
-- Description:	제조사 데이터 all 프로시저
-- =============================================
CREATE PROCEDURE [dbo].[GetAllOffereData]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select off_No,off_Name,off_OwnerName,off_OwnerMobile,off_Manager,off_ManagerMobile,off_Addr
	from Offerer;
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllOrder]    Script Date: 2019-12-13 오전 10:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		박박박
-- Create date: 20191211
-- Description:	발주내역
-- =============================================
CREATE PROCEDURE [dbo].[GetAllOrder]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
select ofo_No,ofo_Each,mat_No,off_No,c.cmt_No,ofo_Price,ofo_Date,cmt_Type from Offerer_Order o inner join CompleteType c on o.cmt_No=c.cmt_No ;




END
GO
/****** Object:  StoredProcedure [dbo].[GetAllProduct]    Script Date: 2019-12-13 오전 10:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		'박상인'
-- Create date: 12/05
-- Description:	상품
-- =============================================
CREATE PROCEDURE [dbo].[GetAllProduct]
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT pro_No,pro_Name,mat_No, pro_Price,pro_Img
	from Product

END
GO
/****** Object:  StoredProcedure [dbo].[GetAllProductMaterialConnect]    Script Date: 2019-12-13 오전 10:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		신소연
-- Create date: 12/11
-- Description:	Product_Form에서 Material과 Product가 연결된게 필요해짐
-- =============================================
CREATE PROCEDURE [dbo].[GetAllProductMaterialConnect]
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT pro_No,pro_Name,m.mat_No, pro_Price, m.mat_Each, mt.mtt_Name
	from Product p
		INNER JOIN Materials m  ON p.mat_No = m.mat_No 
		INNER JOIN Materials_Type mt ON mt.mtt_No = m.mtt_No
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllSubOrder]    Script Date: 2019-12-13 오전 10:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		박상인
-- Create date: 201912.11
-- Description:	발주 폼에 보여질 제품과 제조사 관계
-- =============================================
CREATE PROCEDURE [dbo].[GetAllSubOrder]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
		select m.mat_No,m.mat_Name,m.off_No,m.mat_Cost,o.off_Name 
		from Materials m inner join Offerer o on m.off_No=o.off_No
END
GO
/****** Object:  StoredProcedure [dbo].[GetUser]    Script Date: 2019-12-13 오전 10:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetUser]
	-- Add the parameters for the stored procedure here
	@cus_Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT  * from Customer where cus_Id=@cus_Id
END
GO
/****** Object:  StoredProcedure [dbo].[InsertBOM]    Script Date: 2019-12-13 오전 10:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsertBOM]
	-- Add the parameters for the stored procedure here
	@mat_ParentNo	INT,
	@mat_ChildNo	INT,
	@bom_ChildEach	INT,
	@bom_ChildUnit	NVARCHAR(2)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	-- SET NOCOUNT ON;

    -- Insert statements for procedure here
	DECLARE @V_CNT     INT;

    -- Insert statements for procedure here
	SELECT @V_CNT = COUNT(mat_ParentNo) FROM BOM 
	  WHERE mat_ParentNo = @mat_ParentNo and mat_ChildNo = @mat_ChildNo

    IF @V_CNT = 0 -- BOM이 구성안된 경우
		BEGIN
			INSERT INTO BOM (mat_ParentNo,mat_ChildNo,bom_ChildEach, bom_ChildUnit) 
				 VALUES (@mat_ParentNo,@mat_ChildNo,@bom_ChildEach,@bom_ChildUnit)
		END
	ELSE -- BOM이 구성된 경우
		BEGIN
			UPDATE BOM SET mat_ChildNo = @mat_ChildNo,
						   bom_ChildEach = @bom_ChildEach,
						   bom_ChildUnit = @bom_ChildUnit
					 Where mat_ParentNo = @mat_ParentNo
		END
END
GO
/****** Object:  StoredProcedure [dbo].[InsertOrder]    Script Date: 2019-12-13 오전 10:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		박상인
-- Create date: 20191211
-- Description:	발주 추가
-- =============================================
CREATE PROCEDURE [dbo].[InsertOrder]
	

	@ofo_Each INT,
	@mat_No INT,
	@off_No INT,
	@cmt_No INT,
	@ofo_Price INT,
	@ofo_Date DATETIME

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

	INSERT INTO Offerer_Order(ofo_Each,mat_No,off_No,cmt_No,ofo_Price,ofo_Date) VALUES(@ofo_Each,@mat_No,@off_No,@cmt_No,@ofo_Price,@ofo_Date)


END
GO
/****** Object:  StoredProcedure [dbo].[IsProductNosValid]    Script Date: 2019-12-13 오전 10:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		신소연
-- Create date: 12/12
-- Description:	문자열 pro_No의 묶음을 가져와 해당 묶음의 개개요소가 존재하는지 int로 select
-- =============================================
CREATE PROCEDURE [dbo].[IsProductNosValid]
	@ProductNos NVARCHAR(100),
	@sep NVARCHAR(1)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT count(pro_No)
	FROM Product 
	WHERE pro_No in (select CONVERT(INT,item) from [dbo].[SplitString](@ProductNos, @sep));

END
GO
/****** Object:  StoredProcedure [dbo].[MaterialEachUpdate]    Script Date: 2019-12-13 오전 10:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		박상인
-- Create date: 20191212
-- Description:	발주된자재 갯수 증가.
-- =============================================
CREATE PROCEDURE [dbo].[MaterialEachUpdate]
	-- Add the parameters for the stored procedure here
	@mat_No INT,
	@mat_Each INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
UPDATE Materials SET mat_Each=mat_Each+@mat_Each
			WHERE mat_No=@mat_No
		
END
GO
/****** Object:  StoredProcedure [dbo].[MaterialsDelete]    Script Date: 2019-12-13 오전 10:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		박상인
-- Create date: 20191211
-- Description:	무결성조약으로인해 bom mat_no product mat_no materials mat_no 삭제
-- =============================================

 CREATE PROCEDURE   [dbo].[MaterialsDelete] 
	-- Add the parameters for the stored procedure here
	     @mat_No int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	delete from Product where mat_No = @mat_No;
	delete from BOM where mat_ParentNo=@mat_No;
	delete from BOM where mat_ChildNo=@mat_No;
	delete from Materials where mat_No=@mat_No;
	

END
GO
/****** Object:  StoredProcedure [dbo].[MaterialsInsert_Update]    Script Date: 2019-12-13 오전 10:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		박상인
-- Create date: 20191211
-- Description:	자제insert update
-- =============================================
CREATE PROCEDURE [dbo].[MaterialsInsert_Update]

				@mat_No INT,
			   @mtt_No INT,
               @off_No INT,
               @mat_Name NVARCHAR(50), 
               @mat_Cost INT, 
               @mat_Each INT, 
               @mat_MinSize INT,
               @mat_Unit NVARCHAR(4) 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF NOT EXISTS(SELECT mat_No FROM Materials WHERE mat_No=@mat_No)	
		BEGIN
			Insert into Materials(mtt_No,off_No,mat_Name,mat_Cost,mat_Each,mat_MinSize,mat_Unit) values (@mtt_No,@off_No,@mat_Name,@mat_Cost,@mat_Each,@mat_MinSize,@mat_Unit)	
		END
	
	ELSE 
		BEGIN
			UPDATE Materials SET mtt_No= @mtt_No ,off_No=@off_No ,mat_Name=@mat_Name ,mat_Cost=@mat_Cost ,mat_Each=@mat_Each ,mat_MinSize=@mat_MinSize ,mat_Unit=@mat_Unit
			WHERE mat_No=@mat_No
		
		END
END
GO
/****** Object:  StoredProcedure [dbo].[MaterialsInsert_Update_GetID]    Script Date: 2019-12-13 오전 10:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		신소연
-- Create date: 12/12
-- Description:	자제insert update AND GET ID
-- =============================================
CREATE PROCEDURE [dbo].[MaterialsInsert_Update_GetID]

				@mat_No INT,
			   @mtt_No INT,
               @off_No INT,
               @mat_Name NVARCHAR(50), 
               @mat_Cost INT, 
               @mat_Each INT, 
               @mat_MinSize INT,
               @mat_Unit NVARCHAR(4) 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.

			Insert into Materials(mtt_No,mat_Name,mat_Unit) values (@mtt_No,@mat_Name,@mat_Unit)	
		SELECT @@IDENTITY;
END
GO
/****** Object:  StoredProcedure [dbo].[ProductsDelete]    Script Date: 2019-12-13 오전 10:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		신소연
-- Create date: 12/12
-- Description:	문자열 pro_No들을 가져와 제거하는 프로시저
-- =============================================
CREATE PROCEDURE [dbo].[ProductsDelete]
	@ProductNos NVARCHAR(1000),
	@sep NVARCHAR(1)
AS
BEGIN

	DELETE FROM Product
	WHERE pro_No in (select CONVERT(INT,item) from [dbo].[SplitString](@ProductNos, @sep));

END
GO
/****** Object:  StoredProcedure [dbo].[TempProcedure]    Script Date: 2019-12-13 오전 10:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TempProcedure]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT b.mat_ParentNo, b.mat_ChildNo, b.bom_ChildEach, mat_No, off_No, mat_Name, mat_Cost, mat_Each, mat_MinSize, mt.mtt_No, mtt_Name, mat_Unit
	FROM (SELECT [mat_No], [mtt_No], [off_No], [mat_Name], [mat_Cost], [mat_Each], [mat_MinSize], [mat_Unit] FROM Materials WHERE mtt_No = 1)  m
		INNER JOIN Materials_Type mt ON m.mtt_No = mt.mtt_No
		INNER JOIN (SELECT DISTINCT mat_ParentNo, mat_ChildNo, bom_ChildEach FROM BOM) b ON m.mat_No = b.mat_ParentNo
END
GO
/****** Object:  StoredProcedure [dbo].[Update_Order]    Script Date: 2019-12-13 오전 10:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		박상인
-- Create date: 20191212
-- Description:	발주 업데이트
-- =============================================
CREATE PROCEDURE [dbo].[Update_Order]
	-- Add the parameters for the stored procedure here
	@ofo_No INT,@cmt_No INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE Offerer_Order SET cmt_No=@cmt_No
			WHERE ofo_No=@ofo_No
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateBOM]    Script Date: 2019-12-13 오전 10:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		김상영
-- Create date: 2019-12-09
-- Description:	BOM 업데이트
-- =============================================
CREATE PROCEDURE [dbo].[UpdateBOM]
	-- Add the parameters for the stored procedure here
	@mat_ParentNo		INT,
	@mat_ChildNo		INT, 
	@bom_ChildEach		INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	-- SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE BOM SET  bom_ChildEach = @bom_ChildEach
			 where  mat_ChildNo = @mat_ChildNo 
			   and mat_ParentNo = @mat_ParentNo

END
GO
/****** Object:  StoredProcedure [dbo].[UpdateOfferer_Order]    Script Date: 2019-12-13 오전 10:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		박상인
-- Create date: 20191212
-- Description:	발주 업데이트
-- =============================================
CREATE PROCEDURE [dbo].[UpdateOfferer_Order]
	-- Add the parameters for the stored procedure here
	@ofo_No INT,@cmt_No INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE Offerer_Order SET cmt_No=@cmt_No
			WHERE ofo_No=@ofo_No
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'주문타입코드 : auto_increment' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CompleteType', @level2type=N'COLUMN',@level2name=N'cmt_No'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'주문타입이름 : 발주중/ 배송중/ 배송완료' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CompleteType', @level2type=N'COLUMN',@level2name=N'cmt_Type'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'고객번호 :  auto_increment' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'cus_No'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'고객아이디' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'cus_Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'고객비밀번호' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'cus_Password'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'고객이름' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'cus_Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'고객전화번호' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'cus_Phone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'고객주소' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'cus_Addr'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'고객이메일' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'cus_Email'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'관리자여부' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'IsManager'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'주문코드 : auto_increment' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer_Order', @level2type=N'COLUMN',@level2name=N'cuo_No'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'고객번호' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer_Order', @level2type=N'COLUMN',@level2name=N'cus_No'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'주문날짜' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer_Order', @level2type=N'COLUMN',@level2name=N'cuo_Datetime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'주문총가격' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer_Order', @level2type=N'COLUMN',@level2name=N'cuo_TotalPrice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'주문상세코드' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer_Order_Detail', @level2type=N'COLUMN',@level2name=N'cod_No'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'주문코드' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer_Order_Detail', @level2type=N'COLUMN',@level2name=N'cuo_No'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'제품코드' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer_Order_Detail', @level2type=N'COLUMN',@level2name=N'pro_No'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'주문상세갯수' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer_Order_Detail', @level2type=N'COLUMN',@level2name=N'cod_Each'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'자재코드 : auto_increment' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Materials', @level2type=N'COLUMN',@level2name=N'mat_No'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'자재타입코드' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Materials', @level2type=N'COLUMN',@level2name=N'mtt_No'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'제조사코드' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Materials', @level2type=N'COLUMN',@level2name=N'off_No'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'자재이름' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Materials', @level2type=N'COLUMN',@level2name=N'mat_Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'자재총가격 : 자재를 구성하는 모든 재료의 가격' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Materials', @level2type=N'COLUMN',@level2name=N'mat_Cost'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'자재갯수 : 창고에 쌓인 자재 개수' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Materials', @level2type=N'COLUMN',@level2name=N'mat_Each'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'최소수' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Materials', @level2type=N'COLUMN',@level2name=N'mat_MinSize'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'단위' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Materials', @level2type=N'COLUMN',@level2name=N'mat_Unit'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'타입코드 : auto_increment' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Materials_Type', @level2type=N'COLUMN',@level2name=N'mtt_No'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'타입이름 : 완제품/ 반제품/ 원재료 등' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Materials_Type', @level2type=N'COLUMN',@level2name=N'mtt_Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'제조사코드 : auto_increment' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Offerer', @level2type=N'COLUMN',@level2name=N'off_No'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'제조사이름' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Offerer', @level2type=N'COLUMN',@level2name=N'off_Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'대표이름' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Offerer', @level2type=N'COLUMN',@level2name=N'off_OwnerName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'대표전화번호' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Offerer', @level2type=N'COLUMN',@level2name=N'off_OwnerMobile'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'담당자이름' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Offerer', @level2type=N'COLUMN',@level2name=N'off_Manager'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'담당자전화번호' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Offerer', @level2type=N'COLUMN',@level2name=N'off_ManagerMobile'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'제조사주소' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Offerer', @level2type=N'COLUMN',@level2name=N'off_Addr'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'상품코드 : auto_increment' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Product', @level2type=N'COLUMN',@level2name=N'pro_No'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'상품이름' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Product', @level2type=N'COLUMN',@level2name=N'pro_Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'자재코드' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Product', @level2type=N'COLUMN',@level2name=N'mat_No'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'상품가격' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Product', @level2type=N'COLUMN',@level2name=N'pro_Price'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'상품이미지' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Product', @level2type=N'COLUMN',@level2name=N'pro_Img'
GO
USE [master]
GO
ALTER DATABASE [TEAM4] SET  READ_WRITE 
GO