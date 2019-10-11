-- 퇴사 관련 필드가 정의된 것은 없지만, 종료일자가 있는 테이블의 데이터를 살펴보면 '9999-01-01'인 데이터가 있다. 
-- 의미상 현재 근무 중인 직원은 급여나 현재 근무 부서, 업무의 종료일자가 없을 것이다. 
-- 종료일자가 없다는 의미를 '9999-01-01'로 사용한 것 같다.

SELECT COUNT(*) FROM SALARIES WHERE TO_DATE='9999-01-01';
SELECT COUNT(*) FROM TITLES WHERE TO_DATE='9999-01-01';
SELECT COUNT(*) FROM DEPT_EMP WHERE TO_DATE='9999-01-01';

use employees;
-- 1. 현재 근무중인 직원들의 업무별 직원수를 구하시오.
select title, count(*)
from titles 
where to_date = '9999-01-01'
group by title;

-- 2. 현재 근무중인 직원들의 평균 급여를 구하시오.
select avg(salary)
from salaries 
where to_date = '9999-01-01';

-- 3. 부서별 현재 인원수를 구하시오.
select departments.dept_name, count(*)
from dept_emp, departments
where departments.dept_no = dept_emp.dept_no and dept_emp.to_date = '9999-01-01' 
group by departments.dept_name;
# || 
select dept_no, count(*)
from dept_emp
where to_date = '9999-01-01' 
group by dept_no;

-- 4. 부서별 현재 인원수를 인원수가 많은 부서부터 출력하시오
select dept_no, count(*) as `현재 인원수`
from dept_emp
where to_date = '9999-01-01' 
group by dept_no
order by `현재 인원수` desc;

-- 5. 부서 이동이 많은 직원순으로 리스트를 출력하시오 (퇴직자 포함)
select count(*) as 부서이동, emp_no
from dept_emp
group by emp_no
order by 부서이동 desc;

-- 6. 부서별 현재 인원수가 15,000명 이상인 부서를 구하시오.
select dept_no, count(*) as `현재 인원수`
from dept_emp
where to_date = '9999-01-01' 
group by dept_no
having `현재 인원수` >= 15000;

-- 7. 부서별 현재 인원수가 가장 많은 상위 5개 부서를 구하시오
select dept_no, count(*) as `현재 인원수`
from dept_emp
where to_date = '9999-01-01' 
group by dept_no
order by `현재 인원수` desc
limit 5;

-- 8. 각 사원들의 급여를 10% 인상된 금액을 구하시오.
select salary * 1.1, emp_no
from salaries
where  to_date = '9999-01-01';

-- 9 . 현재 받는 급여의 평균보다 많이 받는 사원들의 사원번호,  급여액을 구하시오.
select emp_no, salary
from salaries
where salary > ( select avg(salary) from salaries where to_date = '9999-01-01') and to_date = '9999-01-01';

-- 10. d001 부서에 근무하고 있는 사원들의 사원번호와 사원명을 구하시오.
select dept.dept_no, emp.emp_no, emp.first_name , emp.last_name 
from employees emp, dept_emp dept 
where emp.emp_no = dept.emp_no and to_date = '9999-01-01' and dept.dept_no = 'd001';
# ||
select dept.dept_no, emp.emp_no, emp.first_name, emp.last_name
from employees emp join dept_emp dept on emp.emp_no = dept.emp_no
where to_date = '9999-01-01' and dept.dept_no = 'd001';





