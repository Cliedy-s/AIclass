# commit;
#select * from goodie.member;

#use employees;
#use goodie;
#select * from employees.employees;
/* # 멤버 만들기
CREATE TABLE `member` (
  `userID` varchar(20) NOT NULL COMMENT '고객 아이디',
  `userName` varchar(45) NOT NULL DEFAULT 'unknown' COMMENT '고객 이름',
  `userPhone` varchar(13) NOT NULL COMMENT '고객 전화번호',
  `userGender` char(1) NOT NULL DEFAULT 'F',
  `userEmail` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`userID`),
  UNIQUE KEY `userID_UNIQUE` (`userID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='고객 테이블';
 */
 
# alter table goodie.member add column userInfo varchar(20);

#select count(*) from employees.employees;

# userTbl, buyTbl 만들기
-- CREATE DATABASE goodie;
USE goodie;
CREATE TABLE userTbl (
    userID CHAR(8) NOT NULL PRIMARY KEY,
    name VARCHAR(10) NOT NULL,
    birthYear INT NOT NULL,
    addr CHAR(2) NOT NULL,
    mobile1 CHAR(3),
    mobile2 CHAR(8),
    height SMALLINT,
    mDate DATE
);
CREATE TABLE buyTbl (
    num INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
    userID CHAR(8) NOT NULL,
    prodName CHAR(6) NOT NULL,
    groupName CHAR(4),
    price INT NOT NULL,
    amount SMALLINT NOT NULL,
    FOREIGN KEY (userID)
        REFERENCES userTbl (userID)
);

INSERT INTO userTbl VALUES('LSG', '이승기', 1987, '서울', '011', '1111111', 182, '2008-8-8');
INSERT INTO userTbl VALUES('KBS', '김범수', 1979, '경남', '011', '2222222', 173, '2012-4-4');
INSERT INTO userTbl VALUES('KKH', '김경호', 1971, '전남', '019', '3333333', 177, '2007-7-7');
INSERT INTO userTbl VALUES('JYP', '조용필', 1950, '경기', '011', '4444444', 166, '2009-4-4');
INSERT INTO userTbl VALUES('SSK', '성시경', 1979, '서울', NULL  , NULL      , 186, '2013-12-12');
INSERT INTO userTbl VALUES('LJB', '임재범', 1963, '서울', '016', '6666666', 182, '2009-9-9');
INSERT INTO userTbl VALUES('YJS', '윤종신', 1969, '경남', NULL  , NULL      , 170, '2005-5-5');
INSERT INTO userTbl VALUES('EJW', '은지원', 1972, '경북', '011', '8888888', 174, '2014-3-3');
INSERT INTO userTbl VALUES('JKW', '조관우', 1965, '경기', '018', '9999999', 172, '2010-10-10');
INSERT INTO userTbl VALUES('BBK', '바비킴', 1973, '서울', '010', '0000000', 176, '2013-5-5');
INSERT INTO buyTbl VALUES(NULL, 'KBS', '운동화', NULL   , 30,   2);
INSERT INTO buyTbl VALUES(NULL, 'KBS', '노트북', '전자', 1000, 1);
INSERT INTO buyTbl VALUES(NULL, 'JYP', '모니터', '전자', 200,  1);
INSERT INTO buyTbl VALUES(NULL, 'BBK', '모니터', '전자', 200,  5);
INSERT INTO buyTbl VALUES(NULL, 'KBS', '청바지', '의류', 50,   3);
INSERT INTO buyTbl VALUES(NULL, 'BBK', '메모리', '전자', 80,  10);
INSERT INTO buyTbl VALUES(NULL, 'SSK', '책'    , '서적', 15,   5);
INSERT INTO buyTbl VALUES(NULL, 'EJW', '책'    , '서적', 15,   2);
INSERT INTO buyTbl VALUES(NULL, 'EJW', '청바지', '의류', 50,   1);
INSERT INTO buyTbl VALUES(NULL, 'BBK', '운동화', NULL   , 30,   2);
INSERT INTO buyTbl VALUES(NULL, 'EJW', '책'    , '서적', 15,   1);
INSERT INTO buyTbl VALUES(NULL, 'BBK', '운동화', NULL   , 30,   2);

SELECT 
    *
FROM
    userTbl;
SELECT 
    *
FROM
    buyTbl;
#

-- drop table userTbl;
-- drop table buytbl;

use employees;
SELECT 
    emp_no, birth_date, first_name, last_name, gender, hire_date
FROM
    employees.employees
WHERE
    gender = 'F';

SELECT 
    *
FROM
    employees.employees
WHERE
    YEAR(HIRE_DATE) = '1999';

SELECT 
    emp_no, birth_date, first_name, last_name, gender, hire_date
FROM
    employees.employees
WHERE
    gender = 'F'
        AND (hire_date BETWEEN '1999-01-01' AND '2000-01-01');

SELECT 
    emp_no, birth_date, first_name, last_name, gender, hire_date
FROM
    employees.employees
WHERE
    gender = 'F' AND hire_date LIKE '1999%';

SELECT 
    emp_no, birth_date, first_name, last_name, gender, hire_date
FROM
    employees.employees
WHERE
    last_name IN ('Senzako' , 'Perris', 'Henseler');

SELECT 
    emp_no, birth_date, first_name, last_name, gender, hire_date
FROM
    employees.employees
WHERE
    YEAR(hire_date) IN ('1999' , '2001', '1994');
SELECT 
    userID,
    name,
    birthYear,
    addr,
    mobile1,
    mobile2,
    height,
    mDate
FROM
    usertbl
WHERE
    addr = '경남' OR addr = '경북';

SELECT 
    userID,
    name,
    birthYear,
    addr,
    mobile1,
    mobile2,
    height,
    mDate
FROM
    usertbl
WHERE
    addr LIKE '경%';

SELECT 
    userID,
    name,
    birthYear,
    addr,
    mobile1,
    mobile2,
    height,
    mDate
FROM
    usertbl
WHERE
    name LIKE '김%' OR name LIKE '이%';

SELECT 
    userID,
    name,
    birthYear,
    addr,
    mobile1,
    mobile2,
    height,
    mDate
FROM
    usertbl
WHERE
    name LIKE '%경%';
SELECT 
    userID,
    name,
    birthYear,
    addr,
    mobile1,
    mobile2,
    height,
    mDate
FROM
    usertbl
WHERE
    height IN (SELECT 
            height
        FROM
            usertbl
        WHERE
            name LIKE '%경%');

SELECT 
    userID,
    name,
    birthYear,
    addr,
    mobile1,
    mobile2,
    height,
    mDate
FROM
    usertbl
WHERE
    height > ANY (SELECT 
            height
        FROM
            usertbl
        WHERE
            name LIKE '%경%');
SELECT 
    userID,
    name,
    birthYear,
    addr,
    mobile1,
    mobile2,
    height,
    mDate
FROM
    usertbl
ORDER BY height;

SELECT 
    userID,
    name,
    birthYear,
    addr,
    mobile1,
    mobile2,
    height,
    mDate
FROM
    usertbl
ORDER BY height DESC;

SELECT 
    userID,
    name,
    birthYear,
    addr,
    mobile1,
    mobile2,
    height,
    mDate
FROM
    usertbl
ORDER BY addr , height;

SELECT 
    emp_no, birth_date, first_name, last_name, gender, hire_date
FROM
    employees.employees
ORDER BY birth_date DESC;
SELECT 
    emp_no, birth_date, first_name, last_name, gender, hire_date
FROM
    employees.employees
ORDER BY first_name;

SELECT 
    emp_no, birth_date, first_name, last_name, gender, hire_date
FROM
    employees.employees
ORDER BY hire_date;

SELECT 
    emp_no, birth_date, first_name, last_name, gender, hire_date
FROM
    employees.employees
ORDER BY hire_date;

SELECT 
    *
FROM
    employees.employees
        JOIN
    employees.salaries ON employees.employees.emp_no = employees.salaries.emp_no
ORDER BY employees.salaries.salary DESC;

SELECT 
    *
FROM
    employees.employees
        JOIN
    employees.salaries ON employees.employees.emp_no = employees.salaries.emp_no
ORDER BY employees.salaries.salary DESC
LIMIT 6 , 5;
-- 범위를 좁혀서 가져옴

SELECT 
    *
FROM
    employees.employees
        JOIN
    (SELECT 
        emp_no, salary
    FROM
        employees.salaries
    ORDER BY salary
    LIMIT 6 , 5) salarys ON employees.employees.emp_no = salarys.emp_no
ORDER BY salarys.salary DESC;

SELECT 
    first_name, last_name, hire_date
FROM
    employees.employees
ORDER BY hire_date
LIMIT 1;

SELECT 
    first_name, last_name, hire_date
FROM
    employees.employees
WHERE
    hire_date = (SELECT 
            MIN(hire_date)
        FROM
            employees.employees);

SELECT 
    emp_no, birth_date, first_name, last_name, gender, hire_date
FROM
    employees.employees
WHERE
    gender = 'F';

SELECT 
    *
FROM
    employees.employees
WHERE
    YEAR(HIRE_DATE) = '1999';

SELECT 
    emp_no, birth_date, first_name, last_name, gender, hire_date
FROM
    employees.employees
WHERE
    gender = 'F'
        AND (hire_date BETWEEN '1999-01-01' AND '2000-01-01');

SELECT 
    emp_no, birth_date, first_name, last_name, gender, hire_date
FROM
    employees.employees
WHERE
    gender = 'F' AND hire_date LIKE '1999%';

SELECT 
    emp_no, birth_date, first_name, last_name, gender, hire_date
FROM
    employees.employees
WHERE
    last_name IN ('Senzako' , 'Perris', 'Henseler');

SELECT 
    emp_no, birth_date, first_name, last_name, gender, hire_date
FROM
    employees.employees
WHERE
    YEAR(hire_date) IN ('1999' , '2001', '1994');

desc employees.employees;

SELECT DISTINCT
    YEAR(hire_date)
FROM
    employees
ORDER BY YEAR(hire_date);
SELECT DISTINCT
    YEAR(hire_date) AS hire_yy
FROM
    employees
ORDER BY 1;

SELECT 
    *
FROM
    titles;
SELECT DISTINCT
    title
FROM
    titles;

SELECT 
    COUNT(DISTINCT title) AS titleCount
FROM
    titles;
SELECT DISTINCT
    title
FROM
    titles;
-- 1999년 입사
SELECT 
    COUNT(*)
FROM
    employees
WHERE
    YEAR(hire_date) = '1999';
SELECT 
    *
FROM
    employees
WHERE
    YEAR(hire_date) = '1999';

CREATE TABLE employees1999 (SELECT * FROM
    employees
WHERE
    YEAR(hire_date) = '1999');
SELECT 
    emp_no, birth_date, first_name, last_name, gender, hire_date
FROM
    employees1999;
SELECT 
    COUNT(*)
FROM
    employees1999;

-- 구조 복사
CREATE TABLE employeesStructure (SELECT * FROM
    employees
WHERE
    1 = 0);

-- 1999입사, 남, 생일 1960이후
SELECT 
    emp_no, birth_date, first_name, last_name, gender, hire_date
FROM
    employees
WHERE
    YEAR(hire_date) = '1999'
        AND gender = 'M'
        AND YEAR(birth_date) > '1960';

SELECT 
    *
FROM
    usertbl;

-- 연도별 입사
use employees;
SELECT 
    YEAR(hire_date) AS `년도`, COUNT(*) AS `뽑은 사람`
FROM
    employees
GROUP BY YEAR(hire_date)
ORDER BY `뽑은 사람` ASC;

-- 여자만 연도별로 몇명인지
SELECT 
    YEAR(hire_date) AS `년도`, COUNT(*) AS `뽑은 사람`
FROM
    employees
WHERE
    gender = 'F'
GROUP BY YEAR(hire_date)
HAVING `뽑은 사람` > 10000
ORDER BY `뽑은 사람` DESC;

-- 남자인지 여자인지 
SELECT 
    YEAR(hire_date) AS `년도`,
    gender,
    COUNT(*) AS `뽑은 사람`
FROM
    employees
GROUP BY YEAR(hire_date) , gender
HAVING `뽑은 사람` > 10000
ORDER BY `년도` DESC;

-- 남자인지 여자인지 
SELECT 
    YEAR(hire_date) AS `년도`,
    MIN(birth_date),
    gender,
    COUNT(*) AS `뽑은 사람`
FROM
    employees
GROUP BY YEAR(hire_date) , gender
HAVING `뽑은 사람` > 10000
ORDER BY `년도` DESC;

SELECT 
    gender, COUNT(emp_no)
FROM
    employees
GROUP BY gender;

# table
use goodie;
SELECT 
    num, userID, prodName, groupName, price, amount
FROM
    buytbl;
-- 총 구매액과 총 구매액수
SELECT 
    userID, SUM(price * amount), SUM(amount), COUNT(num)
FROM
    buytbl
GROUP BY userID;

-- 평균 구매횟수
SELECT 
    AVG(amount) AS `평균구매갯수`
FROM
    buytbl;

-- 사용자별 평균 구매횟수
SELECT 
    AVG(amount), userID
FROM
    buytbl
GROUP BY userID;

-- select avg(count(*))
-- from buytbl
-- group by userID;

SELECT 
    userID, MAX(height), MIN(height)
FROM
    usertbl;
-- pivot? 

SELECT 
    MAX(IF(page = 'MIN키', `value`, 0)) AS MIN키,
    MAX(IF(page = 'MIN이름', `value`, 0)) AS MIN이름,
    MAX(IF(page = 'MAX키', `value`, 0)) AS MAX키,
    MAX(IF(page = 'MAX이름', `value`, 0)) AS MAX이름
FROM
    (SELECT 
        'MIN키', 'MIN키' AS page, MIN(height) AS 'value'
    FROM
        usertbl UNION ALL SELECT 
        'MIN이름',
            'MIN이름' AS page,
            (SELECT 
                    name
                FROM
                    usertbl
                WHERE
                    height = (SELECT 
                            MIN(height)
                        FROM
                            usertbl)) AS `name`
     UNION ALL SELECT 
        'MAX키', 'MAX키' AS page, MAX(height) AS 'value'
    FROM
        usertbl UNION ALL SELECT 
        'MAX이름',
            'MAX이름' AS page,
            (SELECT 
                    name
                FROM
                    usertbl
                WHERE
                    height = (SELECT 
                            MAX(height)
                        FROM
                            usertbl)) AS `name`
    ) z;

-- select max(height), (select name from usertbl where height = (select max(height) from usertbl)) as maxName , min(height), (select name from usertbl where height = (select min(height) from usertbl)) as minName 
-- from usertbl;

SELECT 
    height, name
FROM
    usertbl
WHERE
    height = (SELECT 
            MAX(height)
        FROM
            usertbl)
        OR height = (SELECT 
            MIN(height)
        FROM
            usertbl);

SELECT 
    *
FROM
    usertbl;

SELECT 
    birthyear, addr, name
FROM
    usertbl;

SELECT 
    birthyear,
    MAX(IF(addr = '서울', name, 0)) AS 서울,
    MAX(IF(addr = '경북', name, 0)) AS 경북,
    MAX(IF(addr = '경기', name, 0)) AS 경기,
    MAX(IF(addr = '경남', name, 0)) AS 경남,
    MAX(IF(addr = '전남', name, 0)) AS 전남
FROM
    usertbl
GROUP BY birthyear
ORDER BY birthyear;

SELECT 
    MAX(height), maxName.maxName, MIN(height), minName.minName
FROM
    usertbl,
    (SELECT 
        name AS maxName
    FROM
        usertbl
    WHERE
        height = (SELECT 
                MAX(height)
            FROM
                usertbl)) AS maxName,
    (SELECT 
        name AS minName
    FROM
        usertbl
    WHERE
        height = (SELECT 
                MIN(height)
            FROM
                usertbl)) AS minName;

-- 휴대폰이 있는 사용자
SELECT 
    *
FROM
    usertbl
WHERE
    mobile1 IS NOT NULL;
SELECT 
    COUNT(*) AS `모바일이 등록된 사용자`
FROM
    usertbl
WHERE
    mobile1 IS NOT NULL;
SELECT 
    COUNT(mobile1) AS `모바일이 등록된 사용자`
FROM
    usertbl;

-- 1000원 이상 구매한 
SELECT 
    userID, SUM(price * amount) sums
FROM
    buytbl
GROUP BY userID
HAVING sums >= 1000;

-- 제품군별로 총 구매액
SELECT 
    groupName, SUM(price * amount)
FROM
    buytbl
GROUP BY groupName;

-- 
SELECT 
    CASE
        WHEN groupname IS NULL THEN '합계'
        WHEN groupname IS NULL THEN '합계'
        WHEN groupname IS NULL THEN '합계'
        WHEN groupname IS NULL THEN '합계'
        ELSE groupname
    END `GROUPNAME`,
    SUM(price * amount)
FROM
    buytbl
GROUP BY groupName WITH ROLLUP;




# rollback;