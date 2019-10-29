# TCL
Commit;
Rollback;
# Select문
SELECT  EmployeeID, Email, Password, Name, Phone, ZipCode, Addr1, Addr2, Authority FROM EMPLOYEES;
SELECT  EmployeeID, Email, Password, Name, Phone, ZipCode, Addr1, Addr2, Authority FROM EMPLOYEES WHERE EmployeeID='10001';
# Insert문
INSERT INTO EMPLOYEES(EmployeeID, Email, Password, Name, Phone, ZipCode, Addr1, Addr2) VALUES('10001', 'bhb0047@gmail.com','tlsth9189', '신소연','01063055237','k0001','세웅빌딩','409호');
# Delete문
DELETE FROM EMPLOYEES WHERE EmployeeID = '10001';
# Update문
UPDATE EMPLOYEES SET `Password` = , `Name`, Phone = , Addr1 = , Addr2 =  WHERE EmployeeID = ;
# TCL
Commit;
Rollback;
