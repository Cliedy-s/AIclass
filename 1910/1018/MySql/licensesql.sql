CREATE SCHEMA LICENSEDB;
USE LICENSEDB;

drop table if exists CUSTOMER;
drop table if exists LICENSE;
drop table if exists LICENSEREGISTRY;

CREATE TABLE CUSTOMER (
CustomerID varchar(20) primary key
, CustomerName varchar(30) not null
, CustomerM_Date datetime default now()
,CustomerDeleted bit(1) default	b'0');

CREATE TABLE LICENSE(
LicenseID char(10) primary key
, LicenseName varchar(20) not null
, LicenseCost int not null
);

CREATE TABLE LICENSEREGISTRY(
registrycode int auto_increment primary key
, CustomerID varchar(20) not null
, LicesneID varchar(20) not null
);

INSERT INTO Customer (CustomerID, CustomerName) VALUES(10001, '정정정'); 

INSERT INTO License (LicenseID, LicenseName, LicenseCost) VALUES(20001, '정처산기', 15000);

INSERT INTO LICENSEREGISTRY (CustomerID, LicesneID) VALUES(10001, 20001);

commit;