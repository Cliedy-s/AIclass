SELECT bookid, bookname, author, publisher, reservestuid, lendingstate FROM Book WHERE BOOKID=1 AND Deleted =0;


-- 인풋 파라미터 

DELIMITER $$
DROP PROCEDURE IF EXISTS CREATE_PROTOCOLLED_RECORD;
DELIMITER @@
CREATE PROCEDURE CREATE_PROTOCOLLED_RECORD( ARecordName VARCHAR(255), AReferenceObjects VARCHAR(255) )
BEGIN
DECLARE Remainder TEXT;
DECLARE Delimiter CHAR(1);
DECLARE Pos INT DEFAULT 1 ;
DECLARE Str VARCHAR(1000);

SELECT ARecordName;

SET Delimiter = ',';
SET Remainder = AReferenceObjects;

WHILE CHAR_LENGTH(Remainder) > 0 AND Pos > 0 DO
SET Pos = INSTR(Remainder, `Delimiter`);
IF Pos = 0 THEN
SET Str = Remainder;
ELSE
SET Str = LEFT(Remainder, Pos - 1);
END IF;
IF TRIM(Str) != '' THEN
SELECT Str;
END IF;

SET Remainder = SUBSTRING(Remainder, Pos + 1);
END WHILE;
END;
@@

DELIMITER ;

use goodeeproject;
INSERT INTO lending( studentid, lenddate) values(1, now());
select * from lending;
rollback;
INSERT INTO lendingitem(lendingid, bookitem, bookid) VALUES(1, 1,1001);
SELECT * FROM lendingitem;

UPDATE book SET lendingstate = 1 WHERE bookid = 1001;

select * from book;
rollback;

# update book set reservestuid =  where bookid = 1001;
commit;

select count(*)
from lending l 
	inner join lendingitem li on l.lendingID = li.lendingID
where l.studentid = 1 and li.bookid = 1001
	and li.returndate is null;
    
select * 
from lending l 
	inner join lendingitem li on l.lendingID = li.lendingID;
    
select * from lendingitem;
select * from lending;

