-- -----------------------------------------------------
-- Table Authority
-- -----------------------------------------------------
DROP TABLE IF EXISTS Authority ;

CREATE TABLE Authority (
  aut_No INT IDENTITY(1,1) NOT NULL ,
  aut_Name NVARCHAR(20) NOT NULL,
  PRIMARY KEY (aut_No))
GO

-- -----------------------------------------------------
-- Table Customer
-- -----------------------------------------------------
DROP TABLE IF EXISTS Customer ;

CREATE TABLE Customer (
  cus_No INT IDENTITY(1,1) NOT NULL ,
  cus_Id NVARCHAR(50) NOT NULL,
  cus_Password NVARCHAR(50) NOT NULL,
  cus_Name NVARCHAR(45) NULL,
  cus_Phone NVARCHAR(30) NULL,
  cus_Addr NVARCHAR(200) NULL,
  cus_Email NVARCHAR(50) NULL,
  aut_No INT NOT NULL DEFAULT 0,
  PRIMARY KEY (cus_No),
  CONSTRAINT fk_cus_autNo
    FOREIGN KEY (aut_No)
    REFERENCES Authority (aut_No)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
GO

-- -----------------------------------------------------
-- Table Materials_Type
-- -----------------------------------------------------
DROP TABLE IF EXISTS Materials_Type ;

CREATE TABLE Materials_Type (
  mtt_No INT IDENTITY(1,1) NOT NULL ,
  mtt_Name VARCHAR(45) NULL,
  PRIMARY KEY (mtt_No))
GO

-- -----------------------------------------------------
-- Table Offerer
-- -----------------------------------------------------
DROP TABLE IF EXISTS Offerer ;

CREATE TABLE Offerer (
  off_No INT IDENTITY(1,1) NOT NULL ,
  off_Name NVARCHAR(50) NOT NULL,
  off_OwnerName NVARCHAR(30) NOT NULL,
  off_OwnerMobile NVARCHAR(35) NOT NULL,
  off_Manager NVARCHAR(30) NOT NULL,
  off_ManagerMobile NVARCHAR(35) NOT NULL,
  off_Addr NVARCHAR(100) NOT NULL,
  PRIMARY KEY (off_No))
GO


-- -----------------------------------------------------
-- Table Materials
-- -----------------------------------------------------
DROP TABLE IF EXISTS Materials ;

CREATE TABLE Materials (
  mat_No INT IDENTITY(1,1) NOT NULL ,
  mtt_No INT,
  off_No INT,
  mat_Name NVARCHAR(50) NOT NULL,
  mat_Cost INT NULL,
  mat_Each INT NOT NULL DEFAULT 0,
  PRIMARY KEY (mat_No),
  CONSTRAINT fk_mat_offName
    FOREIGN KEY (off_No)
    REFERENCES Offerer (off_No)
    ON DELETE SET NULL
    ON UPDATE CASCADE,
  CONSTRAINT fk_mat_mttType
    FOREIGN KEY (mtt_No)
    REFERENCES Materials_Type (mtt_No)
    ON DELETE SET NULL
    ON UPDATE CASCADE)
GO


-- -----------------------------------------------------
-- Table CompleteType
-- -----------------------------------------------------
DROP TABLE IF EXISTS CompleteType ;

CREATE TABLE CompleteType (
  cmt_No INT IDENTITY(1,1) NOT NULL ,
  cmt_Type NVARCHAR(10) NOT NULL,
  PRIMARY KEY (cmt_No))
GO


-- -----------------------------------------------------
-- Table Product
-- -----------------------------------------------------
DROP TABLE IF EXISTS Product ;

CREATE TABLE Product (
  pro_No INT IDENTITY(1,1) NOT NULL ,
  pro_Price INT NULL,
  pro_Name NVARCHAR(50) NULL,
  pro_Img NVARCHAR(500) NULL,
  mat_No INT NOT NULL,
  PRIMARY KEY (pro_No),
  CONSTRAINT fk_pro_matNo
    FOREIGN KEY (mat_No)
    REFERENCES Materials (mat_No)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
GO


-- -----------------------------------------------------
-- Table Customer_Order
-- -----------------------------------------------------
DROP TABLE IF EXISTS Customer_Order ;

CREATE TABLE Customer_Order (
  cus_ord_No INT IDENTITY(1,1) NOT NULL ,
  pro_No INT NOT NULL,
  cus_No INT NOT NULL,
  cus_ord_Price INT NOT NULL,
  cus_ord_Each INT NOT NULL,
  cus_ord_Datetime DATETIME NOT NULL DEFAULT getdate(),
  cmt_No INT NOT NULL,
  PRIMARY KEY (cus_ord_No),
  CONSTRAINT fk_cmo_comNo
    FOREIGN KEY (cmt_No)
    REFERENCES CompleteType (cmt_No)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_cmo_cusNo
    FOREIGN KEY (cus_No)
    REFERENCES Customer (cus_No)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_cmo_proNo
    FOREIGN KEY (pro_No)
    REFERENCES Product (pro_No)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
GO


-- -----------------------------------------------------
-- Table BOM
-- -----------------------------------------------------
DROP TABLE IF EXISTS BOM ;

CREATE TABLE BOM (
  bom_No INT IDENTITY(1,1) NOT NULL ,
  mat_ParentNo INT NOT NULL,
  mat_ChildNo INT NOT NULL,
  bom_ChildEach INT NOT NULL DEFAULT 0,
  PRIMARY KEY (bom_No),
  CONSTRAINT fk_bom_ParentNo
    FOREIGN KEY (mat_ParentNo)
    REFERENCES Materials (mat_No)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_bom_ChildNo
    FOREIGN KEY (mat_ChildNo)
    REFERENCES Materials (mat_No)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
GO


-- -----------------------------------------------------
-- Table Offerer_Order
-- -----------------------------------------------------
DROP TABLE IF EXISTS Offerer_Order ;

CREATE TABLE Offerer_Order (
  ofo_No INT IDENTITY(1,1) NOT NULL ,
  ofo_Each INT NOT NULL,
  mat_No INT NOT NULL,
  off_No INT NOT NULL,
  cmt_No INT NOT NULL,
  PRIMARY KEY (ofo_No),
  CONSTRAINT fk_ofo_cmtNo
    FOREIGN KEY (cmt_No)
    REFERENCES CompleteType (cmt_No)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_ofo_offNo
    FOREIGN KEY (off_No)
    REFERENCES Offerer (off_No)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_ofo_matNo
    FOREIGN KEY (mat_No)
    REFERENCES Materials (mat_No)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
GO


-- INDEX 추가 해야함
-- BOM 
-- mat_ParentNo => idx_bom_ParentNo
-- mat_ChildNo => idx_bom_ChildNo