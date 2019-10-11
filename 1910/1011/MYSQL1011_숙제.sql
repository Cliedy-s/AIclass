-- 1. 회원별 총 구매액에 따라서 고객 등급을 구분 (case when 사용)
--     (200원 미만 : 새싹고객, 1500원 미만 : 우수고객)
USE goodie;

select  case when sum(price* amount)< 200 then '새싹고객'
						when sum(price* amount)< 1500 then '우수고객'
                        else 'VIP'
                        end '고객 등급'
                        , userID , sum( price * amount) as 총구매액
from buytbl
group by userID;
-- 2. 구매 내역 중 제품의 카테고리명이 없는 제품은?
select prodName
from buytbl
where groupName is null
group by prodName;
-- 3. 구매된 제품의 카테고리명이 없는 경우는 '미분류' 라는 카테고리로 표시하세요. 
select prodName, ifnull(groupName, '미분류') as 카테고리
from buytbl
group by prodName;

-- 4. 회원테이블에 비밀번호 컬럼을 추가하고, 
--     임시로 회원아이디 + 출생년도2자리 + '1234'로 설정한다.
commit;
select * from usertbl;
alter table usertbl add ( user_password varchar(20) );
update usertbl set user_password= concat(userID, right(birthYear,2), 1234);
#|| 
update usertbl set user_password= concat(userID, substring(birthYear, 3), 1234); #?


-- 5. 이번달에 가입감사 메일을 보낼 회원을 조회
#????????????????????????????????????????????????????
select if(month(mDate) = month(now()), '보낼회원','pass') as '보낼회원조회', userID from usertbl;
#????????????????????????????????????????????????????

-- 6. 회원의 가입시기를 봄, 여름, 가을, 겨울로 구분하여 가입총계를 조회
--     (ppt의 pivot 테이블 참조)
select * from usertbl;

-- 	select u.name as name
-- 				, case 
-- 						when month(u.mDate)< 4 then '봄'
-- 						when month(u.mDate)< 7 then '여름'
-- 						when month(u.mDate)< 10 then '가을'
-- 						else '겨울' end season
-- 	from usertbl u;

select sum(if(m.season='봄', 1, 0)) as '봄',  sum(if(m.season='여름', 1, 0)) as '여름',  sum(if(m.season='가을', 1, 0)) as '가을',  sum(if(m.season='겨울',1, 0)) as '겨울'
from (
	select case 
						when month(u.mDate) in (3, 4, 5) then '봄'
						when month(u.mDate) in (6, 7, 8) then '여름'
						when month(u.mDate) in (9, 10, 11) then '가을'
						else '겨울' end season
	from usertbl u ) as m;

-- 7. BBK 회원의 모든 구매내역을 조회 => 유저 내용 보여주기 #?????????????
select num, prodName, name, birthYear, addr, mobile1, mobile2, height, mDate
from buytbl b join usertbl u on b.userID = u.userID
where b.userID = 'BBK';

-- 8. 구매내역이 있는 회원 정보 조회
select userID, name, birthYear, addr, mobile1, mobile2, height, mDate
from usertbl u  natural join buytbl b
group by userID;

# ||
select u.userID, name, birthYear, addr, mobile1, mobile2, height, mDate
from usertbl u  join buytbl b on u.userID = b.userID
group by userID;


-- 9. 구매기록이 없는 회원만 출력 
select u.userID, name, birthYear, addr, mobile1, mobile2, height, mDate, b.num
from usertbl u left outer join buytbl b on u.userID = b.userID
where b.num is null;

-- /////////////////////////////////////////////////////////////
-- 1. 현재 근무 중인 직원 정보를 출력하시오.
use employees;
select e.emp_no, birth_date, first_name, last_name, gender, hire_date
from employees e inner join dept_emp de on e.emp_no = de.emp_no
where year(de.to_date) = 9999;
 
-- 2. 현재 근무 중인 직원의 모든 정보(수행업무 포함) 를 출력하시오.
select e.emp_no, e.birth_date, e.first_name, e.last_name, e.gender, e.hire_date, d.dept_name, s.salary, t.title
from dept_emp de
			inner join employees e on de.emp_no = e.emp_no
            inner join departments d on de.dept_no = d.dept_no
            inner join salaries s on de.emp_no = s.emp_no
            inner join titles t on de.emp_no = t.emp_no
where year(s.to_date) = 9999 and year(t.to_date) = 9999;

-- 3. 현재 근무 중인 부서명를 출력하시오. (사원번호, 사원명, 부서코드, 부서명)
select  e.emp_no, concat(first_name, last_name) as emp_name, d.dept_no, dept_name
from dept_emp de
			inner join employees e on de.emp_no = e.emp_no
            inner join departments d on de.dept_no = d.dept_no
where year(de.to_date) = 9999
order by emp_no;

-- 4. 가장오래 근무한 직원 10명의 현재 부서를 출력하시오.
select dept_no, from_date
from dept_emp de
where year(de.to_date) = 9999
order by from_date asc
limit 5;

-- 5. 부서별로 직원 수를 구하되 부서 이름이 나오게 출력하시오.
select d.dept_name, count(de.emp_no)
from dept_emp de 
		inner join departments d on de.dept_no = d.dept_no
where year(de.to_date) = 9999
group by d.dept_name;

-- 6. 부서별, 성별 직원 수를 구하시오
select d.dept_name, e.gender, count(*)
from dept_emp de
		inner join departments d on de.dept_no = d.dept_no
        inner join employees e on de.emp_no = e.emp_no
where year(de.to_date) = 9999
group by d.dept_name, e.gender;

-- 7. 급여 평균이 가장 높은 부서 5개를 출력하시오. 
select avg(salary) as `급여평균`, de.dept_no
from dept_emp de 
		inner join salaries s on de.emp_no = s.emp_no
group by de.dept_no
order by `급여평균` desc
limit 5;

-- 8. 급여 평균이 가장 높은 부서를 제외하고, 급여 평균이 높은 부서를 5개를 출력하시오. 
select avg(salary) as `급여평균`, de.dept_no
from dept_emp de 
		inner join salaries s on de.emp_no = s.emp_no
group by de.dept_no
order by `급여평균` desc
limit 1, 5;


-- 9. 급여를 많이 받는 부서장 리스트를 출력하시오
select dm.emp_no, s.salary
from dept_manager dm join salaries s on dm.emp_no = s.emp_no
where year(dm.to_date) = 9999
order by s.salary desc;
 
-- 10. 개발부(Development)에서 급여를 가장 많이 받는 직원 5명을 출력하시오.
select de.emp_no, s.salary
from dept_emp de 
		join salaries s on de.emp_no = s.emp_no
where de.dept_no = ( select dept_no from departments where dept_name = 'Development') 
		and year(de.to_date) = 9999 and year(s.to_date) = 9999
order by s.salary desc
limit 5;

-- select * from dept_emp de where de.dept_no= ( select dept_no from departments where dept_name = 'Development') ;