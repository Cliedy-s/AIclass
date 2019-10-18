# Create Tables
DROP TABLE IF EXISTS Book;
DROP TABLE IF EXISTS student;
DROP TABLE IF EXISTS lending;
DROP TABLE IF EXISTS lendingitem;

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
CREATE TABLE Student (
	studentid int not null,
    studentname varchar(50),
    department varchar(50),
    deleted bit(1) default b'0',
    primary key (studentid)
);
CREATE TABLE lending (
	lendingid int not null auto_increment,
    studentid int,
    lenddate datetime,
    primary key (lendingid)
);
CREATE TABLE lendingitem (
	lendingid int not null,
    bookitem int,
    bookid int not null,
    returndate datetime,
    primary key (lendingid, bookid)
);


#Select
SELECT bookid, bookname, author, publisher FROM book WHERE deleted = 0;
SELECT studentid, studentname, department FROM student WHERE deleted = 0;
SELECT deleted FROM student WHERE studentid = 234;
SELECT count(*) FROM student WHERE deleted = 1 AND studentid = 234;


-- ----------------------------------------------------------------------
SELECT * FROM student;
SELECT * FROM Book;
DESC Book;
#DML
INSERT INTO student (studentid, studentname, department) VALUES(10001, '홍길동','철학과');
INSERT INTO book (bookid, bookname, author, publisher) VALUES('1001','식객1','허영만','김영사');
INSERT INTO book (bookid, bookname, author, publisher) VALUES('1002','식객2','허영만','김영사');
INSERT INTO book (bookid, bookname, author, publisher) VALUES('1003','식객3','허영만','김영사');
INSERT INTO book (bookid, bookname, author, publisher) VALUES('1004','식객4','허영만','김영사');
INSERT INTO book (bookid, bookname, author, publisher) VALUES('1005','식객5','허영만','김영사');
INSERT INTO book (bookid, bookname, author, publisher) VALUES('1006','식객6','허영만','김영사');
INSERT INTO book (bookid, bookname, author, publisher) VALUES('1007','식객7','허영만','김영사');
INSERT INTO book (bookid, bookname, author, publisher) VALUES('1008','식객8','허영만','김영사');
INSERT INTO book (bookid, bookname, author, publisher) VALUES('1009','식객9','허영만','김영사');
INSERT INTO book (bookid, bookname, author, publisher) VALUES('1010','식객10','허영만','김영사');

INSERT INTO lending(lendingid, studentid,lenddate ) VALUES (1,1,sysdate());
INSERT INTO lendingitem(lendingid, bookitem, bookid, returndate) VALUES (1,1,1,sysdate());

SELECT bookid, bookname, author, publisher, ifnull(reservestuid, 0) as reservestuid, lendingstate FROM book where deleted = b'0';

UPDATE book SET reservestuid =0 WHERE reservestuid is null;
UPDATE student SET studentname = '', department='' WHERE studentid = 234;
UPDATE book SET lendingstate = b'1' WHERE bookid%2 = 0 ;
DELETE FROM student WHERE studentid = 234;
COMMIT;
ROLLBACK;



