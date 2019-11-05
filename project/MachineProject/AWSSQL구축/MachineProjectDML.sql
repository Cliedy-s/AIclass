USE MachineProject;
# TCL
Commit;
Rollback;
# Select문
SELECT  EmployeeID, Email, Password, Name, Phone, ZipCode, Addr1, Addr2, Authority FROM EMPLOYEES;
SELECT  EmployeeID, Email, Password, Name, Phone, ZipCode, Addr1, Addr2, Authority FROM EMPLOYEES WHERE EmployeeID='10001';
SELECT EmployeeID, Email, Password, Name, Phone, ZipCode, Addr1, Addr2, Authority FROM EMPLOYEES WHERE Email='bhb0047@naver.co.kr'; 
SELECT DomainCode, Domain FROM EMAILDOMAINS ORDER BY DomainCode;
SELECT M.MachineID, M.isRunning, PL.ProductionID,PL.AmountPerDay FROM MACHINE M
	INNER JOIN PLISTBYMACHINE PL ON M.MachineID = PL.MachineID;
SELECT MachineID, isRunning FROM MACHINE;
SELECT MachineID, ProductionID, AmountPerDay FROM PLISTBYMACHINE;
SELECT TodoCode, MachineID, ProductionID, EmployeeID, TotalAmount FROM TODO;
SELECT ProductionPlanCode, ProductionID, TotalAmount FROM PRODUCTIONPLAN;
SELECT MachineID, ProductionID, AmountPerDay FROM PLISTBYMACHINE WHERE MachineID='20001' AND ProductionID = '30001'; 
SELECT ProductionPlanCode, ProductionID, TotalAmount, (TotalAmount - PlanedAmount) as LeftAmount, PlanedAmount FROM PRODUCTIONPLAN; 

SELECT  EmployeeID, Email, Password, Name, Phone, ZipCode, Addr1, Addr2, Authority FROM EMPLOYEES;

SELECT ProductionID, ProductionName FROM PRODUCTION;
SELECT MachineID, ProductionID, IFNULL(AmountPerDay, 0) as AmountPerDay FROM PLISTBYMACHINE; 
SELECT * FROM TODO;
SELECT ProductionPlanCode, ProductionID, TotalAmount, PlanedAmount FROM PRODUCTIONPLAN;
SELECT (TotalAmount - PlanedAmount) as LeftAmount FROM PRODUCTIONPLAN; 
SELECT isRunning FROM MACHINE WHERE MachineID = 20001;
SELECT isRunning FROM MACHINE;
SELECT MachineID, isRunning FROM MACHINE WHERE isRunning =1;

SELECT * FROM PRODUCTIONLIST;
SELECT * FROM TODO;
# Insert문
# 사용자 : 10000대
# 기계 : 20000대
# 제품 : 30000대
INSERT INTO EMPLOYEES(EmployeeID, Email, Password, Name, Phone, ZipCode, Addr1, Addr2) VALUES('10001', 'bhb0047@gmail.com','tlsth9189', '신소연','01063055237','k0001','세웅빌딩','409호');
INSERT INTO EMPLOYEES(EmployeeID, Email, Password, Name, Phone, Authority) VALUES('00001', 'admin','1234', '관리자','00000000000', b'0010');
INSERT INTO EMPLOYEES(EmployeeID, Email, Password, Name, Phone, Authority) VALUES('00002', 'emp','1234', '사용자','00000000000', b'0001');
INSERT INTO EMPLOYEES(EmployeeID, Email, Password, Name, Phone, Authority) VALUES('00003', 'emp2','1234', '사용자','00000000000', b'0001'); commit;
INSERT INTO EMAILDOMAINS( DomainCode,Domain) VALUES(0, '직접입력');
INSERT INTO EMAILDOMAINS( DomainCode, Domain) VALUES(1, 'naver.com');
INSERT INTO EMAILDOMAINS( Domain) VALUES('gmail.com');
INSERT INTO EMAILDOMAINS( Domain) VALUES('nate.com');
INSERT INTO EMAILDOMAINS( Domain) VALUES('paran.com');
INSERT INTO EMAILDOMAINS( Domain) VALUES('hanmail.net');

INSERT INTO PRODUCTION(ProductionID, ProductionName) VALUES('30001','허니버터칩');
INSERT INTO PRODUCTION(ProductionID, ProductionName) VALUES('30002','다이제');
INSERT INTO PRODUCTION(ProductionID, ProductionName) VALUES('30003','포카칩');
INSERT INTO PRODUCTION(ProductionID, ProductionName) VALUES('30004','새우깡');
INSERT INTO PRODUCTION(ProductionID, ProductionName) VALUES('30005','마가렛트');
INSERT INTO PRODUCTION(ProductionID, ProductionName) VALUES('30006','콘초');
INSERT INTO PRODUCTION(ProductionID, ProductionName) VALUES('30007','초코파이');
INSERT INTO PRODUCTION(ProductionID, ProductionName) VALUES('30008','인디안밥');
INSERT INTO PRODUCTION(ProductionID, ProductionName) VALUES('30009','자갈치');
INSERT INTO PRODUCTION(ProductionID, ProductionName) VALUES('30010','신당동떡볶이');

INSERT INTO MACHINE(MachineID, isRunning) VALUES('20001',0);
INSERT INTO MACHINE(MachineID, isRunning) VALUES('20002',0);
INSERT INTO MACHINE(MachineID, isRunning) VALUES('20003',0);
INSERT INTO MACHINE(MachineID, isRunning) VALUES('20004',0);
INSERT INTO MACHINE(MachineID, isRunning) VALUES('20005',0);

INSERT INTO PLISTBYMACHINE(MachineID, ProductionID) VALUES('20001','30001');
INSERT INTO PLISTBYMACHINE(MachineID, ProductionID) VALUES('20001','30002');
INSERT INTO PLISTBYMACHINE(MachineID, ProductionID) VALUES('20001','30003');
INSERT INTO PLISTBYMACHINE(MachineID, ProductionID) VALUES('20002','30002');
INSERT INTO PLISTBYMACHINE(MachineID, ProductionID) VALUES('20002','30003');
INSERT INTO PLISTBYMACHINE(MachineID, ProductionID) VALUES('20002','30004');
INSERT INTO PLISTBYMACHINE(MachineID, ProductionID) VALUES('20002','30005');
INSERT INTO PLISTBYMACHINE(MachineID, ProductionID) VALUES('20003','30003');
INSERT INTO PLISTBYMACHINE(MachineID, ProductionID) VALUES('20003','30006');
INSERT INTO PLISTBYMACHINE(MachineID, ProductionID) VALUES('20003','30007');
INSERT INTO PLISTBYMACHINE(MachineID, ProductionID) VALUES('20003','30008');
INSERT INTO PLISTBYMACHINE(MachineID, ProductionID) VALUES('20004','30009');
INSERT INTO PLISTBYMACHINE(MachineID, ProductionID) VALUES('20005','30010');

INSERT INTO PRODUCTIONPLAN(ProductionID, TotalAmount) VALUES('30001',3000);
INSERT INTO PRODUCTIONPLAN(ProductionID, TotalAmount) VALUES('30002',2000);
INSERT INTO PRODUCTIONPLAN(ProductionID, TotalAmount) VALUES('30003',50000);
INSERT INTO PRODUCTIONPLAN(ProductionID, TotalAmount) VALUES('30002',1000);

INSERT INTO TODO(MachineID, ProductionID, EmployeeID, Amount) VALUES('20001','30001','00002', 3000);
INSERT INTO TODO(MachineID, ProductionID, EmployeeID, Amount) VALUES('20001','30001','00002', 3000);

# Delete문
DELETE FROM EMPLOYEES WHERE EmployeeID = '신소연';
DELETE FROM EMPLOYEES WHERE EmployeeID = '10001';
DELETE FROM EMAILDOMAINS WHERE DomainCode = 1;
DELETE FROM TODO WHERE TodoCode = 1;
TRUNCATE TABLE TODO;
TRUNCATE TABLE PRODUCTIONPLAN;
# Update문
-- UPDATE EMPLOYEES SET `Password` = , `Name`, Phone = , Addr1 = , Addr2 =  WHERE EmployeeID = 10001;
UPDATE EMPLOYEES SET Authority = b'0010'  WHERE EmployeeID = 10001;
UPDATE PRODUCTIONPLAN SET PlanedAmount = 300 WHERE ProductionPlanCode = 1;
UPDATE TODO SET CompleteDate = now(), Complete = 'Y' WHERE TodoCode = 1;
UPDATE MACHINE SET isRunning = 0; commit;

-- auto_increment 초기화
ALTER TABLE TODO AUTO_INCREMENT=1;
SET @COUNT = 0;
UPDATE TODO SET TodoCode = @COUNT:=@COUNT+1; -- 초기화 후 모든 칼럼 정상 설정
--
# TCL
Commit;
Rollback;
