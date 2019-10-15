-- 
create table test_table (select * from buytbl );

--
alter table test_table add column orderSum int;
desc test_table;

update test_table set orderSum = price * amount;
commit;
select * from test_table;

use employees;
select e.emp_no, concat(e.first_name, ' ', e.last_name) as `name` , d.dept_no, d.dept_name
from dept_emp de
	inner join departments d on de.dept_no = d.dept_no
    inner join employees e on e.emp_no = de.emp_no
where de.to_date = '9999-01-01'
order by e.emp_no;

drop view if exists v_View;
create view v_View as (
select e.emp_no, concat(e.first_name, ' ', e.last_name) as view_name , d.dept_no, d.dept_name
from dept_emp de
	inner join departments d on de.dept_no = d.dept_no
    inner join employees e on e.emp_no = de.emp_no
where de.to_date = '9999-01-01'
order by e.emp_no);

select * from v_View;

insert into v_View(emp_no, view_name, dept_no, dept_name) values(1,'aaa','11','1sda');

select * from goodie.member;

create table goodie.deleted_member as select * from goodie.member where 1=0;

delete from goodie.member where userid='test01';

rollback;
-- 어제사고 오늘 탈퇴했을 때도 정상적으로 다 출력되게 하시오
select * from goodie.deleted_member
union
select * from goodie.member;
--
select userid, username, 'Y' as useYn from goodie.member
union
select userid, username, 'N' as useNn from goodie.member;
--

select * from employees;