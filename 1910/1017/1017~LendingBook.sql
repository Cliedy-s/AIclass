
DROP TABLE IF EXISTS Book;
CREATE TABLE Book (
	bookid int not null,
    bookname varchar(50) default null,
    author varchar(50) default null,
    publisher varchar(30) default null,
    reservestuid int default null,
    lendingstate bit(1) default b'0',
    deleted bit(1) default b'0',
    primary key (bookid)
);

DROP TABLE IF EXISTS student;
CREATE TABLE Student (
	studentid int not null,
    studentname varchar(50),
    department varchar(50),
    deleted bit(1) default b'0',
    primary key (studentid)
);

SELECT * FROM student;

INSERT INTO student (studentid, studentname, department) VALUES(10001, '홍길동','철학과');
ROLLBACK;

SELECT bookid, bookname, author, publisher FROM book WHERE deleted = 0;
SELECT studentid, studentname, department FROM student WHERE deleted = 0;


SELECT * FROM Book;
DESC Book;



