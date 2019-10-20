CREATE SCHEMA LICENSEDB;
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