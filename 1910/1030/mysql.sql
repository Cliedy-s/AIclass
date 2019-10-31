
CREATE TABLE EMPLOYEES (
EmployeeID                     CHAR (5)   NOT NULL ,
Email                          VARCHAR (30)    NOT NULL  ,
Password                       VARCHAR (20)   NOT NULL  ,
Name                           VARCHAR (30)   NOT NULL  ,
Phone                          VARCHAR (14)    ,
ZipCode                          VARCHAR (5)    ,
Addr1                          VARCHAR (50)    ,
Addr2                          VARCHAR (50)    ,
Authority                      BIT(4)   NOT NULL  DEFAULT b'0001'
)  ;

ALTER TABLE EMPLOYEES ADD CONSTRAINT pk_employees_employeeid PRIMARY KEY( EmployeeID);	

SELECT Email, Password FROM EMPLOYEES;

INSERT INTO employees (EmployeeID, Email, Password, Name) VALUES('10001','bhb0047@naver.com','tlsth1352','신소연');
commit;





