IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.VIEWS
        WHERE TABLE_NAME = 'VW_NorthWindCode_04')
    DROP VIEW VW_NorthWindCode_04
GO
CREATE VIEW VW_NorthWindCode_04
AS
       select Cast([CategoryID] as VARCHAR(10)) Code, [CategoryName] CodeNm, '' PCode, 'Categories' CodeType from [dbo].[Categories]
       union all
       select [CustomerID] Code, [CompanyName] CodeNm, '' PCode, 'Customers' CodeType from [dbo].[Customers]
       union all
       select Cast([EmployeeID] as VARCHAR(10)) Code, concat([FirstName],[LastName]) CodeNm, '' PCode, 'Employees' CodeType from [dbo].[Employees]
       union all
       select Cast([ProductID] as VARCHAR(10)) Code, [ProductName] CodeNm, Cast([CategoryID] as VARCHAR(10)) PCode, 'Products' CodeType from [dbo].[Products]
       union all
       select Cast([RegionID] as VARCHAR(10)) Code, [RegionDescription] CodeNm, '' PCode, 'Region' CodeType from [dbo].[Region]
       union all
       select Cast([ShipperID] as VARCHAR(10)) Code, [CompanyName] CodeNm, '' PCode, 'Shippers' CodeType from [dbo].[Shippers]
       union all
       select Cast([SupplierID] as VARCHAR(10)) Code, [CompanyName] CodeNm, '' PCode, 'Suppliers' CodeType from [dbo].[Suppliers]
       union all
       select [TerritoryID] Code, [TerritoryDescription] CodeNm, '' PCode, 'Territories' CodeType from [dbo].[Territories]
GO

SELECT * FROM VW_NorthWindCode_04