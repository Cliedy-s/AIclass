CREATE TABLE memberInfo
(
	`Name` Varchar(30) PRIMARY KEY NOT NULL,
    Birth DATETIME,
    Email VARCHAR(50),
    Family TINYINT
);

commit;

select * from memberInfo;