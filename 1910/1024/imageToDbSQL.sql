use goodie;
CREATE TABLE product(
		productID INT NOT NULL AUTO_INCREMENT,
        productName VARCHAR(45) DEFAULT NULL,
        PRIMARY KEY(productID)
);

CREATE TABLE productimage(
	productImgID INT NOT NULL AUTO_INCREMENT,
    productID INT DEFAULT NULL,
    productImgFileName VARCHAR(100) DEFAULT NULL,
    productImage LONGBLOB,
    PRIMARY KEY(productImgID)
);

select productID, productName from product;
select productImgID, productID, IFNULL(productImgFileName, 'BLOB이미지') as productImgFileName from productimage order by productID, productImgID;
commit;

INSERT INTO productImage(productID, productImgFileName) VALUES(1, '{1}');
DELETE FROM productImage WHERE productImgFileName = '';

truncate productImage;
select * from productimage;
rollback;
commit;