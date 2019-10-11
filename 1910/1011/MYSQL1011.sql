-- goodie
use goodie;
CREATE TABLE testTbl1 (
    id INT ,
    userName CHAR(3),
    age INT
);
CREATE TABLE testtbl2 (
    id INT AUTO_INCREMENT PRIMARY KEY,
    userName CHAR(3),
    age INT
);


-- SELECT문
SELECT  id, userName, age FROM testTbl1;
SELECT  id, userName, age FROM testTbl2;
SELECT @@autocommit;

#INSERT문
insert into testTbl1(id, userName, age) values(1,"김일일",20);
insert into testTbl1(id, userName, age) values(2,"이둘둘",22);
insert into testTbl1(id, userName, age) values(3,"박삼삼",23);

insert into testTbl2(id, userName, age) values(null,"김일일",20);
insert into testTbl2(id, userName, age) values(null,"이둘둘",22);
insert into testTbl2(id, userName, age) values(null,"박삼삼",23);
insert into testTbl2(userName, age) values("최사사",24); -- autoincrement

DELETE FROM testTbl1 WHERE userName = '최사사';
DELETE FROM testTbl1 WHERE userName = '박삼삼';

#AUTOINCREMENT
SELECT LAST_INSERT_ID();
alter table testtbl2 AUTO_INCREMENT =100;
set @@auto_increment_increment = 3;
insert into testTbl2(userName, age) values("최오토",20);
insert into testTbl2(userName, age) values("최오토",25);
commit;
SELECT * FROM testtbl2;

#TABLE DATA TO TABLE INSERT
INSERT INTO testTbl1 (id, userName, age)
SELECT id, userName, age FROM testTbl2;
 --  id중복?
INSERT INTO testTbl1 (id, userName, age)
( SELECT id + 500, userName, age FROM testTbl2 );

create table testtbl4(id int, Fname VARCHAR(50), Lname varchar(50));
insert into testtbl4 (id, Fname, Lname)
( select emp_no, first_name, last_name from employees.employees );
select * from testtbl4;
 
 --
SELECT * FROM testtbl1;
SELECT * FROM testtbl2;

# UPDATE	
UPDATE testtbl4 
SET 
    Fname = 'GeorgiCopy'
    , Lname = 'Face'
WHERE
    id = 10001;
    
UPDATE testtbl1 
SET 
    age = age + 10
WHERE
    age >= 25;
    
SELECT 
    *
FROM
    testtbl1
WHERE age >=25;

#DELETE
select * from testtbl1 where id>=500;

-- mysql query
delete from testtbl1 
where id>=500 
order by id 
limit 5;

#TRUNCATE AND DELETE ALL
truncate testtbl2; -- 한번에 다지움
select * from testtbl2;

delete from testtbl1; -- rollback 가능, 속도 늦음
select * from testtbl1;

#DROP 
drop table testtbl2;

#DATETIME
SELECT cast('2020-10-19 12:35:29.123' AS DATE) AS 'DATE' ,cast('2020-10-19 12:35:29.123' AS TIME) AS 'TIME' ,cast('2020-10-19 12:35:29.123' AS DATETIME) AS 'DATETIME' ;
SELECT NOW(), DATE(NOW()), TIME(NOW()) FROM DUAL;

# 변수의 사용
SET @MYVALUE = 3;
SELECT @MYVALUE;

#PREPARE QUERY WITH VALIABLE
PREPARE myQuery
	FROM 'SELECT Name, height FROM userTbl ORDER BY height LIMIT ?';
    
SET @myVal1 = 2;
SELECT @myVal1;

EXECUTE myQuery USING @myVal1;

#형변환
SELECT * FROM buytbl;

SELECT cast(AVG(amount) AS SIGNED INTEGER) AS 'TOINT' FROM buytbl;
SELECT convert(avg(amount), SIGNED int) AS 'TOINT' FROM buytbl;

-- 암시적 형변환 
SELECT CONCAT(first_name, ' ', last_name) from employees.employees;
SELECT first_name + last_name  from employees.employees;

SELECT CONCAT(100, '200') FROM DUAL;
SELECT CONCAT(100, 200) FROM DUAL;
SELECT 3> '2MEGA' FROM DUAL;
SELECT 0 = 'MEGA2' FROM DUAL; -- 문자는 0임


#내장 함수
-- IF문
SELECT IF(100<200, '참이다', '거짓이다') AS 결과 FROM DUAL;
SELECT IFNULL(mobile1, '휴대폰 없음') FROM usertbl; -- text ?? "null이다."
 -- SELECT NULLIF(true, true) FROM dual; -- 둘이 값이 같으면 null...? --무시
 SELECT CASE 
				WHEN ifnull(age, 20)<30 THEN '청년'
				WHEN ifnull(age, 20)<40 THEN '중년'
                ELSE '중장년'
                END `나이` 
FROM testtbl1;
--

SELECT length(first_name), first_name FROM employees.employees;
SELECT length(userName), userName from testtbl1;
SELECT char_length(first_name), first_name FROM employees.employees;
SELECT char_length(userName), userName from testtbl1;

SELECT concat('안녕','하세요') FROM DUAL;
SELECT concat_ws(',','안녕','하세요') FROM DUAL;

#JOIN
use employees;
select dept.dept_no, dept_name, emp.emp_no, concat(first_name, ' ',last_name)
from employees emp inner join dept_emp dept on emp.emp_no = dept.emp_no 
										inner join departments on departments.dept_no= dept.dept_no -- join
where to_date = '9999-01-01' and dept.dept_no = 'd001';

select dept.dept_no, dept_name, emp.emp_no, concat(first_name, ' ',last_name)
from employees emp natural join dept_emp dept 
										natural join departments 
where to_date = '9999-01-01' and dept.dept_no = 'd001';

select * from departments;

#?
use goodie;

select u.userID, u.name 
from usertbl u natural left outer join buytbl b
group by u.name;

select u.userID, u.name 
from usertbl u natural join buytbl b
group by u.name;

select u.userID, u.name, sum(price * amount) as totalPrice, count(*)
from usertbl u natural join buytbl b
group by u.name;

select u.userID, u.name, ifnull(sum(price * amount), 0) as totalPrice, count(*)
from usertbl u natural left outer join buytbl b
group by u.name;

select u.userID, u.name, ifnull(sum(price * amount), 0) as totalPrice, count(*)
from usertbl u left outer join buytbl b
on u.userID = b.userID
group by u.name;

-- || ---------------------------------------------------------------------
#COMMIT
COMMIT;
ROLLBACK;