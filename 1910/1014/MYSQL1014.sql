# 아침
-- 1. 현재 근무 중인 직원 정보를 출력하시오.
SELECT E.*
  FROM EMPLOYEES E
       INNER JOIN DEPT_EMP DE ON DE.EMP_NO=E.EMP_NO
 WHERE DE.TO_DATE = '9999-01-01';
 -- 2. 현재 근무 중인 직원의 모든 정보(수행업무 포함) 를 출력하시오.
SELECT E.*, T.TITLE
  FROM EMPLOYEES E
        INNER JOIN TITLES T ON T.EMP_NO=E.EMP_NO
 WHERE T.TO_DATE = '9999-01-01';
-- 3. 현재 근무 중인 부서명를 출력하시오. (사원번호, 사원명, 부서코드, 부서명)
SELECT E.EMP_NO, E.FIRST_NAME, D.DEPT_NO, D.DEPT_NAME
  FROM DEPT_EMP DE
       INNER JOIN EMPLOYEES E ON E.EMP_NO=DE.EMP_NO
	   INNER JOIN DEPARTMENTS D ON D.DEPT_NO=DE.DEPT_NO
WHERE DE.TO_DATE = '9999-01-01';
-- 4. 가장오래 근무한 직원 10명의 현재 부서를 출력하시오.
SELECT E.EMP_NO, E.FIRST_NAME, E.LAST_NAME, D.DEPT_NAME, E.HIRE_DATE
  FROM DEPT_EMP DE
	  INNER JOIN EMPLOYEES E ON E.EMP_NO=DE.EMP_NO
	  INNER JOIN DEPARTMENTS D ON D.DEPT_NO=DE.DEPT_NO
 WHERE DE.TO_DATE = '9999-01-01'  
 ORDER BY HIRE_DATE 
 LIMIT 10 ;
-- 5. 부서별로 직원 수를 구하되 부서 이름이 나오게 출력하시오.
SELECT DEPT_NAME, COUNT(*) 
  FROM DEPT_EMP DE
		INNER JOIN DEPARTMENTS D ON D.DEPT_NO=DE.DEPT_NO
 WHERE DE.TO_DATE='9999-01-01'  
 GROUP BY DEPT_NAME
 ORDER BY DEPT_NAME;
-- 6. 부서별, 성별 직원 수를 구하시오
SELECT D.DEPT_NAME, E.GENDER, COUNT(*) 
  FROM DEPT_EMP DE
		INNER JOIN DEPARTMENTS D ON D.DEPT_NO=DE.DEPT_NO
		INNER JOIN EMPLOYEES E ON E.EMP_NO=DE.EMP_NO
 WHERE DE.TO_DATE='9999-01-01'  
 GROUP BY D.DEPT_NAME, E.GENDER
 ORDER BY D.DEPT_NAME, E.GENDER;
-- 7. 급여 평균이 가장 높은 부서 5개를 출력하시오. 
SELECT D.DEPT_NAME, AVG(SALARY) SA
  FROM DEPT_EMP DE
	  INNER JOIN DEPARTMENTS D ON D.DEPT_NO=DE.DEPT_NO
	  INNER JOIN SALARIES S ON S.EMP_NO=DE.EMP_NO
WHERE DE.TO_DATE='9999-01-01' AND S.TO_DATE='9999-01-01' 
GROUP BY D.DEPT_NAME
ORDER BY SA DESC
LIMIT 5;
-- 8. 급여 평균이 가장 높은 부서를 제외하고, 급여 평균이 높은 부서를 5개를 출력하시오. 
SELECT D.DEPT_NAME, AVG(SALARY) SA
  FROM DEPT_EMP DE
	  INNER JOIN DEPARTMENTS D ON D.DEPT_NO=DE.DEPT_NO
	  INNER JOIN SALARIES S ON S.EMP_NO=DE.EMP_NO
WHERE DE.TO_DATE='9999-01-01' AND S.TO_DATE='9999-01-01'  
GROUP BY D.DEPT_NAME
ORDER BY SA DESC
LIMIT 1, 5;
-- 9. 급여를 많이 받는 부서장 리스트를 출력하시오
SELECT E.*, S.SALARY
  FROM DEPT_MANAGER DM
	   INNER JOIN SALARIES S ON S.EMP_NO = DM.EMP_NO
	   INNER JOIN EMPLOYEES E ON E.EMP_NO = DM.EMP_NO
 WHERE S.TO_DATE = '9999-01-01'
 ORDER BY SALARY DESC;

SELECT E.*, S.SALARY, T.Title
  FROM DEPT_MANAGER DM
	   INNER JOIN SALARIES S ON S.EMP_NO = DM.EMP_NO
	   INNER JOIN EMPLOYEES E ON E.EMP_NO = DM.EMP_NO
       INNER JOIN TITLES T ON E.EMP_NO = T.EMP_NO AND DM.FROM_DATE = T.FROM_DATE
 WHERE S.TO_DATE = '9999-01-01'
 ORDER BY SALARY DESC;
-- 10. 개발부(Development)에서 급여를 가장 많이 받는 직원 5명을 출력하시오.
SELECT E.*, SALARY
  FROM DEPT_EMP DE
	   INNER JOIN EMPLOYEES E ON E.EMP_NO = DE.EMP_NO
	   INNER JOIN SALARIES S ON S.EMP_NO = DE.EMP_NO
 WHERE DE.TO_DATE = '9999-01-01' AND DEPT_NO='D005'
 ORDER BY SALARY DESC
 LIMIT 5;
 
# 또 다른 조인법 
-- 1. 부서별(부서명) 직원 수를 구하시오.
-- 부서를 추출하고, 각 부서의 인원수를 계산하는 것
SELECT D.DEPT_NAME, 
		(SELECT COUNT(*) 
          FROM DEPT_EMP DE 
         WHERE DE.TO_DATE = '9999-01-01' 
           AND DE.DEPT_NO=D.DEPT_NO)     
  FROM DEPARTMENTS D;

-- 부서와 인원 테이블을 조인해서 데이터를 구성하고 부서명으로 그룹화 한 뒤 인원을 계산
SELECT D.DEPT_NAME, COUNT(*) 
  FROM DEPARTMENTS D
 INNER JOIN DEPT_EMP DE ON DE.DEPT_NO=D.DEPT_NO
 WHERE DE.TO_DATE = '9999-01-01'
 GROUP BY D.DEPT_NAME;
 
 
 -- 문자열로 그룹화 하는 것보다는 정형화된 코드로 그룹화하는 것이 좋다.
 SELECT DEPT_NAME, CNT
   FROM DEPARTMENTS D
	   INNER JOIN (
			SELECT DEPT_NO, COUNT(*) CNT
			  FROM DEPT_EMP
			 WHERE TO_DATE='9999-01-01'
			 GROUP BY DEPT_NO
	  ) DS ON D.DEPT_NO = DS.DEPT_NO
 ORDER BY D.DEPT_NO;
 
-- (
-- inner join
select d.dept_name, count(emp_no)
from dept_emp de inner join departments d on de.dept_no = d.dept_no
where year(de.to_date) = 9999
group by d.dept_no;

select d.dept_name
from dept_emp de inner join departments d on de.dept_no = d.dept_no
where year(de.to_date) = 9999;


-- subquery
select d.dept_name, 
	(
    select count(*) from dept_emp de 
    where year(de.to_date) = 9999 
    and de.dept_no = d.dept_no
    ) as '직원 수'# 스칼라 서브쿼리 => 전체 데이터 행 수 만큼 실행
from departments d;

select count(*) from dept_emp de 
where year(de.to_date) = 9999 
and de.dept_no = 'd001';

--  subquery + inner join ( 가장 빠름  => 결과 집합을 작게 )
select dept_name, cnt
from departments d
	inner join ( select dept_no, count(*) cnt
							from dept_emp
                            where year(to_date) = 9999
                            group by dept_no 
                            ) as ds on d.dept_no = ds.dept_no; # 코드로 group by 
-- )
 
-- 2. 각 부서에서 가장 오래 근무한 직원을 출력하시오.

SELECT DEPT_NAME
    , (SELECT FIRST_NAME
         FROM DEPT_EMP DE 
              INNER JOIN EMPLOYEES E ON E.EMP_NO = DE.EMP_NO
         WHERE DE.TO_DATE = '9999-01-01' 
           AND DE.DEPT_NO=D.DEPT_NO
         ORDER BY FROM_DATE 
         LIMIT 1) EMPLOYEE
  FROM DEPARTMENTS D;


-- 3. 가장 오래된 직원 10명이 근무했던 처음과 마지막 부서를 출력하시오.
-- (
select e.*
			, ( select dept_name
                from dept_emp de2
                where de2.emp_no = de.emp_no 
                order by from_date asc
                limit 1
                ) as first_dept_name
			, d.dept_name as last_dept_no
from dept_emp de 
	inner join employees e on de.emp_no = e.emp_no
    inner join departments d on de.dept_no = d.dept_no
where year(to_date) = 9999
order by e.hire_date
limit 10;
-- )

SELECT EM.*
          , (SELECT DEPT_NAME 
               FROM DEPT_EMP DEE, DEPARTMENTS DE 
              WHERE DEE.DEPT_NO=DE.DEPT_NO 
                AND DEE.EMP_NO = EM.EMP_NO
              ORDER BY FROM_DATE LIMIT 1) FIRST_DEPT 
          , (SELECT DEPT_NAME 
               FROM DEPT_EMP DEE, DEPARTMENTS DE 
			  WHERE DEE.DEPT_NO=DE.DEPT_NO 
                AND DEE.EMP_NO = EM.EMP_NO
              ORDER BY FROM_DATE DESC LIMIT 1) LAST_DEPT 
  FROM EMPLOYEES EM
 ORDER BY HIRE_DATE
 LIMIT 10;

-- 4. 각 부서에서 급여를 가장 많이 받는 직원 리스트를 구하시오.

SELECT DEPT_NAME
	 , (SELECT FIRST_NAME 
		  FROM DEPT_EMP DE 
			  INNER JOIN EMPLOYEES E ON E.EMP_NO = DE.EMP_NO
			  INNER JOIN SALARIES S ON S.EMP_NO = DE.EMP_NO
		 WHERE DE.TO_DATE = '9999-01-01' 
           AND DE.DEPT_NO = D.DEPT_NO
		 ORDER BY SALARY DESC 
	     LIMIT 1) EMPLOYEE
 FROM DEPARTMENTS D;
 
 
 -- 5. 전체 평균보다 많이 받는 직원 수를 계산하시오.
 
SELECT COUNT(*) -- 107706
  FROM SALARIES S 
 WHERE S.TO_DATE = '9999-01-01'
   AND SALARY >= (SELECT AVG(SALARY) 
                    FROM SALARIES 
				   WHERE TO_DATE = '9999-01-01');

-- 6. 퇴직한 직원 정보를 구하시오.
use employees;
SELECT *
  FROM EMPLOYEES E  
 WHERE NOT EXISTS(SELECT 1 FROM DEPT_EMP DE 
                   WHERE DE.TO_DATE = '9999-01-01' 
                     AND E.EMP_NO=DE.EMP_NO);

SELECT *
 FROM EMPLOYEES E  
WHERE EMP_NO NOT IN (SELECT DISTINCT EMP_NO 
                       FROM DEPT_EMP DE 
					  WHERE DE.TO_DATE = '9999-01-01');
                      

# self join


# union
-- 10월에 회원가입한 회원과 총구매액이 1000원 이상인 회원정보 조회
use goodie;

select u.userID, name, birthYear, addr, mobile1, mobile2, height, mDate, user_password, num, prodName, groupName, (price * amount) as totalPrice
from usertbl u  inner join buytbl b  on u.userID = b.userID
where month(mDate) in( 1,2,3,4,5) and  (price * amount) >= 1000 ;

select userID, mDate from usertbl where month(mDate) = 10
union all # union
select userID, price * amount as totalPrice from buytbl where price * amount >= 1000;

# in..

# STORED PROCEDURE=
SELECT *, timestampdiff(year, curdate(), hire_date ),
		case 
			when timestampdiff(year, curdate(), hire_date ) < 5 then '5년 미만'
			else '5년 이상' end '고용일수'
FROM employees
WHERE emp_no = 10001;


DROP PROCEDURE IF EXISTS STARTPROCEDURE;
DROP PROCEDURE IF EXISTS HELLOWORLDIFELSE;

DELIMITER $$ 
CREATE PROCEDURE STARTPROCEDURE()
BEGIN
	DECLARE var1 int;
    SET var1 = 100;
    SELECT var1;
END $$

CREATE PROCEDURE HELLOWORLDIFELSE()
BEGIN
	DECLARE var2 int;
    SET var2 = 200;
    IF var2 = 100 THEN
		SELECT '100입니다.';
	ELSE
		SELECT '100이 아닙니다';
	END IF;
END $$
DELIMITER ;

CALL STARTPROCEDURE();
CALL HELLOWORLDIFELSE();

--  TEACHER ---------------------------------------------------------------------------------------
DROP PROCEDURE IF EXISTS whileProc; 
DELIMITER $$
CREATE PROCEDURE whileProc()
BEGIN
	DECLARE i INT; -- 1에서 100까지 증가할 변수
	DECLARE hap INT; -- 더한 값을 누적할 변수
    SET i = 1;
    SET hap = 0;

	WHILE (i <= 100) DO
		SET hap = hap + i;  -- hap의 원래의 값에 i를 더해서 다시 hap에 넣으라는 의미
		SET i = i + 1;      -- i의 원래의 값에 1을 더해서 다시 i에 넣으라는 의미
	END WHILE;

	SELECT hap;   
END $$
DELIMITER ;
CALL whileProc();


DROP PROCEDURE IF EXISTS whileProc; 
DELIMITER $$
CREATE PROCEDURE whileProc()
BEGIN
	DECLARE i INT; -- 1에서 100까지 증가할 변수
	DECLARE hap INT; -- 더한 값을 누적할 변수
    SET i = 1;
    SET hap = 0;

	WHILE (i <= 100) DO
		SET hap = hap + i;  -- hap의 원래의 값에 i를 더해서 다시 hap에 넣으라는 의미
		SET i = i + 1;      -- i의 원래의 값에 1을 더해서 다시 i에 넣으라는 의미
	END WHILE;

	SELECT hap;   
END $$
DELIMITER ;
CALL whileProc();
DROP PROCEDURE IF EXISTS whileProc2; 
DELIMITER $$
CREATE PROCEDURE whileProc2()
BEGIN
    DECLARE i INT; -- 1에서 100까지 증가할 변수
    DECLARE hap INT; -- 더한 값을 누적할 변수
    SET i = 1;
    SET hap = 0;

    myWhile: WHILE (i <= 100) DO  -- While문에 label을 지정
	IF (i%7 = 0) THEN
		SET i = i + 1;     
		ITERATE myWhile; -- 지정한 label문으로 가서 계속 진행
	END IF;
        
        SET hap = hap + i; 
        IF (hap > 1000) THEN 
		LEAVE myWhile; -- 지정한 label문을 떠남. 즉, While 종료.
	END IF;
        SET i = i + 1;
    END WHILE;

    SELECT hap;   
END $$
DELIMITER ;
CALL whileProc2();

DROP PROCEDURE IF EXISTS errorProc; 
DELIMITER $$
CREATE PROCEDURE errorProc()
BEGIN
    DECLARE CONTINUE HANDLER FOR 1146 SELECT '테이블이 없어요ㅠㅠ' AS '메시지';
    SELECT * FROM noTable;  -- noTable은 없음.  
END $$
DELIMITER ;
CALL errorProc();

DROP PROCEDURE IF EXISTS errorProc2; 
DELIMITER $$

CREATE PROCEDURE errorProc2()
BEGIN
    DECLARE CONTINUE HANDLER FOR SQLEXCEPTION 
    BEGIN
    
	SHOW ERRORS; -- 오류 메시지를 보여 준다.
	SELECT '오류가 발생했네요. 작업은 취소시켰습니다.' AS '메시지'; 
	ROLLBACK; -- 오류 발생시 작업을 롤백시킨다.
    
    END;
    
    INSERT INTO userTbl VALUES('LSG', '이상구', 1988, '서울', NULL, 
		NULL, 170, CURRENT_DATE()); -- 중복되는 아이디이므로 오류 발생
END $$

DELIMITER ;
CALL errorProc2();
-- ---------------------------------------------------------------------------------------

# 동적 쿼리문
PREPARE var
FROM 'SELECT * FROM EMPLOYEES';

EXECUTE var;

# DDL
CREATE TABLE clubTbl (
	clubName VARCHAR(10) NOT NULL,
    roonNo CHAR(4) NOT NULL
);

ALTER TABLE clubTbl ADD CONSTRAINT PK_clubTbl_clubName PRIMARY KEY (clubName);
ALTER TABLE clubTbl ADD CONSTRAINT FK_clubTbl_roomNo FOREIGN KEY (roomNo) REFERENCES userTbl(userID);

 CREATE TABLE clubTbl(
	  clubName VARCHAR(10) NOT NULL PRIMARY KEY
    , roonNo CHAR(4) NOT NULL
    , CONSTRAINT PK_clubTbl_clubName PRIMARY KEY(clubName)
	, FOREIGN KEY( roomNo) REFERENCES userTbl(userID)
 );

#View
use goodie;
CREATE VIEW v_userBuyTble
AS SELECT  u.userid, u.name, b.prodName, u.addr, price * amount as '구매액'
FROM usertbl u INNER JOIN buytbl b ON u.userid = b.userid;

select * from v_userBuyTble;

select * from dept_emp_latest_date;

# 
SELECT * FROM goodie.member;

--
use goodie;
use employees;