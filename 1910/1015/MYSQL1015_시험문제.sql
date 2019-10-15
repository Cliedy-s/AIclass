USE fortest;
#1. 테이블 생성 스크립트 (10점)
DROP TABLE IF EXISTS department;
DROP TABLE IF EXISTS student;

CREATE TABLE department
	( 
    dno INT PRIMARY KEY 
	, dname VARCHAR(30) 
    );
CREATE TABLE student
	( 
    sno INT PRIMARY KEY
	, sname VARCHAR(20)
    , address VARCHAR(20)
    , score SMALLINT
    , dno INT
    );
#2. department 의 dno와 student 의 dno 참조키 설정 (5점)
ALTER TABLE student ADD CONSTRAINT FOREIGN KEY (dno) REFERENCES department(dno);
#3. 데이터 생성 스크립트 (10점)
INSERT INTO department(dno, dname) VALUES(100, 'Computer');
INSERT INTO department(dno, dname) VALUES(200, 'Electronics');
INSERT INTO department(dno, dname) VALUES(300, 'MIS');

INSERT INTO student(sno, sname, address, score, dno) VALUES(100, 'HONG','Seoul', 95, 100);
INSERT INTO student(sno, sname, address, score, dno) VALUES(200, 'KIM','Jeju', 85, 100);
INSERT INTO student(sno, sname, address, score, dno) VALUES(300, 'LEE','Busan', 90, 200);
INSERT INTO student(sno, sname, address, score, dno) VALUES(400, 'SON','Seoul', 80, 300);
INSERT INTO student(sno, sname, address, score, dno) VALUES(500, 'HONG','Busan', 95, 300);

SELECT * FROM department;
SELECT * FROM student;
#4. 2명 이상의 학생을 갖고, 성적 평균이 80이상인 학과의 학과코드(dno), 학과명(dname), 학생수를 검색 (10점)
SELECT d.dno, d.dname, count(s.sno)
FROM department d INNER JOIN student s on d.dno = s.dno
GROUP BY d.dno
HAVING count(s.sno) >=2 AND AVG(s.score) >=80;

#5. Computer 학과가 아닌 학생은 총 몇명인지 검색 (5점)
SELECT count(s.sno)
FROM department d INNER JOIN student s on d.dno = s.dno
WHERE d.dname <> 'Computer';

#6. MIS 학과를 삭제(폐지)하고, 관련학과 학생들은 Computer 학과로 전과 (10점) 
UPDATE Student 
SET dno = (SELECT dno FROM department WHERE dname = 'Computer')
WHERE dno = (SELECT dno FROM department WHERE dname = 'MIS');
DELETE FROM department WHERE dname = 'MIS';

#7. 전체 데이터베이스의 목록을 조회하여, employees 데이터베이스를 선택한다.  
#employees 데이터베이스의 테이블 목록을 조회하고 dept_emp 테이블의 구조를 살펴보는 쿼리문 작성 (10점)
SHOW DATABASES;
USE employees;
SHOW TABLES;
DESC dept_emp;

#8. DEPT_EMP 테이블에는 TO_DATE(근무종료일) 과 DEPT_NO(부서코드) 컬럼이 있다. 근무종료일이 '9999-01-01' 으로 된 것은 현재 근무중인 사원으로 볼 수 있다.
#부서별로 현재 인원수가 가장 많은 상위 5개 부서를 구하는 쿼리문을 작성 (10점)
SELECT dept_no, count(emp_no) as cnt
FROM dept_emp 
WHERE to_date = '9999-01-01'
GROUP BY dept_no
ORDER BY cnt DESC
LIMIT 5;

#9. 1999 년의 월별 신입 사원수를 조회하는 쿼리문 작성. (10점)
select month(e.hire_date) AS 월, count(*) AS 신입사원수
from dept_emp de 
	inner join employees e on de.emp_no = e.emp_no
where year(e.hire_date) = 1999
group by month(e.hire_date)
order by month(e.hire_date);

#10.  부서별 직원 리스트를 출력하되 부서장이면 표시를 하고,  
#각 부서에서 가장 먼저 나오게 쿼리문 작성 (20점)
select de.dept_no
			, e.emp_no
            , case when m.emp_no is not null then '부서장'
				else '' end 부서장
from dept_emp de 
	inner join employees e on de.emp_no = e.emp_no
    left outer join ( select emp_no
								from dept_manager dm 
                                where to_date ='9999-01-01'
                                ) as m on m.emp_no = de.emp_no
where de.to_date = '9999-01-01'
order by dept_no, m.emp_no desc;
