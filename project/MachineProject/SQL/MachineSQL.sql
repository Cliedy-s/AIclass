USE MACHINEPROJECTDB;
DROP TABLE IF EXISTS MACHINE;
CREATE TABLE MACHINE (																
machineID                      CHAR (10)   NOT NULL  PRIMARY KEY,						
isRunning                      BIT (1)   DEFAULT b'0'  							
) ;

DROP TABLE EMPLOYEES ;
CREATE TABLE EMPLOYEES (
emp_Code                       CHAR (10)   NOT NULL  PRIMARY KEY,
emp_Name                       VARCHAR (30)   NOT NULL  ,
emp_Phone                      VARCHAR (14)    ,
emp_Email                      VARCHAR (30)    ,
emp_Addr                       VARCHAR (50)    ,
emp_authority                  VARCHAR (10)   NOT NULL  ,
emp_ID                         VARCHAR (20)   NOT NULL  ,
emp_password                   VARCHAR (20)   NOT NULL  
) ;

DROP TABLE PRODUCTTION ;
CREATE TABLE PRODUCTTION (
prd_ProductionCode             INT   PRIMARY KEY  AUTO_INCREMENT,
prd_MachineID                  CHAR (10)   NOT NULL  ,
prd_ProductID                  CHAR (10)   NOT NULL  ,
prd_TodoCode                   INT     NOT NULL  ,
prd_EmployeeCode               CHAR (10)   NOT NULL  ,
prd_Amount                     INT     NOT NULL  ,
prd_Date                       DATETIME     NOT NULL  ,
prd_DefectRate                 DOUBLE 
);
