CREATE SCHEMA LICENSEDB;
USE LICENSEDB;

DROP TABLE IF EXISTS License;
DROP TABLE IF EXISTS LicenseRegistry;
DROP TABLE IF EXISTS customer;

CREATE TABLE License (
	LicenseID int not null,
    LicenseName varchar(20) default null,
    LicenseCost int default null,
    LicenseDeleted bit(1) default b'0',
    primary key (LicenseID)
);
CREATE TABLE LicenseRegistry (
	RegistryCode int not null AUTO_INCREMENT,
    CustomerID int not null,
    LicenseID int not null,
    RegistryDate datetime default null,
    primary key (RegistryCode)
);
CREATE TABLE customer (
    CustomerID int,
    CustomerName varchar(50),
	CustomerM_Date datetime default NOW(),
    CustomerDeleted bit(1) default b'0',
    primary key (CustomerID)
);



INSERT INTO License (LicenseID, LicenseName, LicenseCost) VALUES(10001, '정보처리산업기사', 22000);
INSERT INTO License (LicenseID, LicenseName, LicenseCost) VALUES(10002, '컴퓨터활용능력', 18000);
INSERT INTO License (LicenseID, LicenseName, LicenseCost) VALUES(10003, '정보처리기사', 25000);

INSERT INTO LicenseRegistry (RegistryCode, CustomerID, LicenseID, RegistryDate) VALUES(10001, 10002, 10003, sysdate());
INSERT INTO LicenseRegistry (RegistryCode, CustomerID, LicenseID, RegistryDate) VALUES(10002, 10002, 10002, sysdate());
INSERT INTO LicenseRegistry (RegistryCode, CustomerID, LicenseID, RegistryDate) VALUES(10003, 10003, 10001, sysdate());

INSERT INTO Customer (CustomerID, CustomerName) VALUES(10001,'허영만');
INSERT INTO Customer (CustomerID, CustomerName) VALUES(10002,'김영만');
INSERT INTO Customer (CustomerID, CustomerName) VALUES(10003,'박영만');

UPDATE Customer SET CustomerName = '박박박' WHERE CustomerID = 10001;
DELETE FROM Customer WHERE CustomerID = 10001;

COMMIT;
ROLLBACK;
select * from license;
select * from licenseregistry;
select * from customer;

SELECT CustomerID, CustomerName, CustomerM_Date FROM customer WHERE CustomerDeleted = b'0';