use employees;
select dept_no, dept_name from departments;

select concat(first_name, last_name) as emp_name, de.dept_no
from employees e
	inner join ( select emp_no, dept_no
						from dept_emp 
                        where dept_no = 'd001' and de.to_date = '9999-01-01' ) as de on de.emp_no = e.emp_no;
                        
use goodie;
create table members ( userID varchar(20) primary key not null, userPWD varchar(20) not null, userName varchar(30) not null );
desc members;
select * from members;

insert into members (userID, userPWD, userName) values('abc','1234','홍길동');
commit;
select userID, userPWD, userName from members;

update members set userPWD = '1234', userName = 'abc' where userID = 'aaa'
