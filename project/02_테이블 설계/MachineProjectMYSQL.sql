USE machineprojectdb;

DROP TABLE IF EXISTS MACHINE;
DROP TABLE IF EXISTS EMPLOYEES;
DROP TABLE IF EXISTS PRODUCTION;
DROP TABLE IF EXISTS TODO;
DROP TABLE IF EXISTS PRODUCTIONLIST;
DROP TABLE IF EXISTS PLISTBYMACHINE;
DROP TABLE IF EXISTS PRODUCTIONPLAN;

#CREATE
CREATE TABLE MACHINE (
MachineID                      CHAR (5)   NOT NULL ,
isRunning                      BIT (1)   DEFAULT b'0'  
) ;
CREATE TABLE EMPLOYEES (
EmployeeID              CHAR (5)   NOT NULL  ,
Name                           VARCHAR (30)   NOT NULL  ,
Phone                          VARCHAR (14)    ,
Email                          VARCHAR (30)    ,
Addr                           VARCHAR (50)    ,
Authority                      VARCHAR (10)   NOT NULL  ,
ID                             VARCHAR (20)   NOT NULL  ,
Password                       VARCHAR (20)   NOT NULL  
) ;
CREATE TABLE PRODUCTION (
ProductionID                   CHAR (5)   NOT NULL  ,
ProductionName                 VARCHAR (20)   NOT NULL  
) ;
CREATE TABLE TODO (
TodoCode                       INT     NOT NULL  ,
MachineID                      CHAR (5)   NOT NULL  ,
ProductionID                   CHAR (5)   NOT NULL  ,
EmployeeID                     CHAR (5)   NOT NULL  ,
Amount                         INT     NOT NULL  
) ;

CREATE TABLE PRODUCTIONLIST (
ProductionCode                 INT     NOT NULL  ,
MachineID                      CHAR (5)   NOT NULL  ,
ProductionID                   CHAR (5)   NOT NULL  ,
TodoCode                       INT     NOT NULL  ,
EmployeeID                   CHAR (5)   NOT NULL  ,
Amount                         INT     NOT NULL  ,
ProductionDate                 DATETIME     NOT NULL  ,
DefectRate                     DOUBLE      
) ;

CREATE TABLE PLISTBYMACHINE (
MachineID                      CHAR (5)   NOT NULL  ,
ProductionID                   CHAR (5)   NOT NULL  ,
CapacityPerDay                 INT     NOT NULL  
) ;

CREATE TABLE PRODUCTIONPLAN (
ProductionPlanCode             INT     NOT NULL  ,
ProductionID                   CHAR (5)   NOT NULL  ,
Amount                         INT     NOT NULL  
) ;

#PK
ALTER TABLE MACHINE ADD CONSTRAINT pk_machine_machineid PRIMARY KEY( MachineID);				
ALTER TABLE EMPLOYEES ADD CONSTRAINT pk_employees_employeeid PRIMARY KEY( EmployeeID);				
ALTER TABLE PRODUCTION ADD CONSTRAINT pk_producttion_productionid PRIMARY KEY( ProductionID);				
ALTER TABLE TODO ADD CONSTRAINT pk_todo_todocode PRIMARY KEY( TodoCode);				
ALTER TABLE PRODUCTIONLIST ADD CONSTRAINT pk_producttionlist_productioncode PRIMARY KEY( ProductionCode);				
ALTER TABLE PLISTBYMACHINE ADD CONSTRAINT pk_plistbymachine_machineid_productionid PRIMARY KEY(machineid, productionid);				
ALTER TABLE PRODUCTIONPLAN ADD CONSTRAINT pk_productionplan_productionplancode PRIMARY KEY( ProductionPlanCode);				

#FK	
-- ALTER TABLE TODO ADD CONSTRAINT fk_machine_todo_machineid  FOREIGN KEY(MachineID ) REFERENCES machine(MachineID);					
-- ALTER TABLE TODO ADD CONSTRAINT fk_production_todo_productionid  FOREIGN KEY(ProductionID ) REFERENCES production(ProductionID);					
-- ALTER TABLE TODO ADD CONSTRAINT fk_employees_todo_employeeid  FOREIGN KEY(EmployeeID ) REFERENCES employees(EmployeeID);		
#=>
ALTER TABLE TODO ADD CONSTRAINT fk_plistbymachine_todo_machineid  FOREIGN KEY(MachineID ) REFERENCES plistbymachine(MachineID);					
ALTER TABLE TODO ADD CONSTRAINT fk_plistbymachine_todo_productionid  FOREIGN KEY(ProductionID ) REFERENCES plistbymachine(ProductionID);					
ALTER TABLE TODO ADD CONSTRAINT fk_employees_todo_employeeid  FOREIGN KEY(EmployeeID ) REFERENCES employees(EmployeeID);
#			

-- ALTER TABLE PRODUCTIONLIST ADD CONSTRAINT fk_machine_productionlist_machineid  FOREIGN KEY(MachineID ) REFERENCES machine(MachineID);					
-- ALTER TABLE PRODUCTIONLIST ADD CONSTRAINT fk_production_productionlist_productionid  FOREIGN KEY(ProductionID ) REFERENCES production(ProductionID);					
-- ALTER TABLE PRODUCTIONLIST ADD CONSTRAINT fk_todo_productionlist_todocode  FOREIGN KEY(TodoCode ) REFERENCES todo(TodoCode);					
-- ALTER TABLE PRODUCTIONLIST ADD CONSTRAINT fk_employees_productionlist_employeeid  FOREIGN KEY(EmployeeID ) REFERENCES employees(EmployeeID);					
#=>
ALTER TABLE PRODUCTIONLIST ADD CONSTRAINT fk_plistbymachine_productionlist_machineid  FOREIGN KEY(MachineID ) REFERENCES plistbymachine(MachineID);					
ALTER TABLE PRODUCTIONLIST ADD CONSTRAINT fk_plistbymachine_productionlist_productionid  FOREIGN KEY(ProductionID ) REFERENCES plistbymachine(ProductionID);					
ALTER TABLE PRODUCTIONLIST ADD CONSTRAINT fk_todo_productionlist_todocode  FOREIGN KEY(TodoCode ) REFERENCES todo(TodoCode);					
ALTER TABLE PRODUCTIONLIST ADD CONSTRAINT fk_employees_productionlist_employeeid  FOREIGN KEY(EmployeeID ) REFERENCES employees(EmployeeID);					
#

ALTER TABLE PLISTBYMACHINE ADD CONSTRAINT fk_machine_plistbymachine_machineid  FOREIGN KEY(MachineID ) REFERENCES Machine(MachineID);					
ALTER TABLE PLISTBYMACHINE ADD CONSTRAINT fk_production_plistbymachine_productionid  FOREIGN KEY(ProductionID ) REFERENCES Production(ProductionID);					

ALTER TABLE PRODUCTIONPLAN ADD CONSTRAINT fk_production_productionplan_productionid  FOREIGN KEY(ProductionID ) REFERENCES Production(ProductionID);					


# DROP CONSTRAINT		
-- ALTER TABLE TODO DROP FOREIGN KEY  `fk_machine_todo_machineid`;					
-- ALTER TABLE TODO DROP FOREIGN KEY  `fk_production_todo_productionid`;					
-- ALTER TABLE TODO DROP FOREIGN KEY  `fk_employees_todo_employeeid`;				
#=>
ALTER TABLE TODO DROP FOREIGN KEY  `fk_plistbymachine_todo_machineid`;					
ALTER TABLE TODO DROP FOREIGN KEY  `fk_plistbymachine_todo_productionid`;					
ALTER TABLE TODO DROP FOREIGN KEY  `fk_employees_todo_employeeid`;	
#

-- ALTER TABLE PRODUCTIONLIST DROP FOREIGN KEY  `fk_machine_productionlist_machineid`;					
-- ALTER TABLE PRODUCTIONLIST DROP FOREIGN KEY  `fk_production_productionlist_productionid`;					
-- ALTER TABLE PRODUCTIONLIST DROP FOREIGN KEY  `fk_todo_productionlist_todocode`;					
-- ALTER TABLE PRODUCTIONLIST DROP FOREIGN KEY  `fk_employees_productionlist_employeeid`;	
#=>
ALTER TABLE PRODUCTIONLIST DROP FOREIGN KEY  `fk_plistbymachine_productionlist_machineid`;					
ALTER TABLE PRODUCTIONLIST DROP FOREIGN KEY  `fk_plistbymachine_productionlist_productionid`;					
ALTER TABLE PRODUCTIONLIST DROP FOREIGN KEY  `fk_todo_productionlist_todocode`;					
ALTER TABLE PRODUCTIONLIST DROP FOREIGN KEY  `fk_employees_productionlist_employeeid`;				
#

ALTER TABLE PLISTBYMACHINE DROP FOREIGN KEY  `fk_machine_plistbymachine_machineid`;					
ALTER TABLE PLISTBYMACHINE DROP FOREIGN KEY  `fk_production_plistbymachine_productionid`;					

ALTER TABLE PRODUCTIONPLAN DROP FOREIGN KEY  `fk_production_productionplan_productionid`;					


-- AUDRMS03@NAVER.COM 잘ㅆ,겠음
