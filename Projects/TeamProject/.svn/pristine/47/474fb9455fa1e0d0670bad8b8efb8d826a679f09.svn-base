---- .Utility
-- ID seed 초기화
dbcc checkident(Materials_Type, reseed, 0)
dbcc checkident(Customer, reseed, 4999)
dbcc checkident(Offerer, reseed, 2999)




-------------------------------------------------------------------------------Materials
-- Select Materials
SELECT TOP (1000) [mat_No]
      ,[mtt_No]
      ,[off_No]
      ,[mat_Name]
      ,[mat_Cost]
      ,[mat_Each]
      ,[mat_MinSize]
  FROM [TEAM4].[dbo].[Materials]
-- truncate table Materials
delete from Materials 
insert into Materials 
(mtt_No,	off_No,	mat_Name,	mat_Cost,	mat_Each,	mat_MinSize)
values
 (2	,	3000,	'콘'				,	100,	10,	30)
,(2	,	3001,	'딸기시럽'		,	100,	10,	30)
,(2	,	3002,	'초코시럽'		,	100,	10,	30)
,(2	,	3003,	'바닐라시럽'	,	100,	10,	30)
,(2	,	3004,	'녹차시럽'		,	100,	10,	30)
,(2	,	3005,	'카라멜시럽'	,	100,	10,	30)

insert into Materials
(mtt_No,	off_No,	mat_Name,	mat_Cost,	mat_Each,	mat_MinSize)
values
(1, null, '그린티 아이스크림', 1500, 0, 10)
,(1, null, '뉴욕 치즈케이크 아이스크림', 1500, 0, 10)
,(1, null, '레인보우 샤베트 아이스크림', 1500, 0, 10)
,(1, null, '민트 초콜릿 칩 아이스크림', 1500, 0, 10)
,(1, null, '바닐라 아이스크림', 1500, 0, 10)
,(1, null, '슈팅스타 아이스크림', 1500, 0, 10)
,(1, null, '자모카 아몬드 훠지 아이스크림', 1500, 0, 10)
,(1, null, '체리쥬빌레 아이스크림', 1500, 0, 10)
,(1, null, '초콜릿 무스 아이스크림', 1500, 0, 10)
,(1, null, '초콜릿 아이스크림', 1500, 0, 10)

------------------------------------------------------------------------------Materials_Type
-- Select Materials_Type
SELECT TOP (1000) [mtt_No]
      ,[mtt_Name]
 FROM [TEAM4].[dbo].[Materials_Type]

-- insert table Materials_Type
delete from Materials_Type
truncate table Materials_Type
insert into Materials_Type(mtt_Name) 
values ('완제품'), ('반제품'),('원재료')


------------------------------------------------------------------------------Customer
-- select Customer
SELECT TOP (1000) [cus_No]
      ,[cus_Id]
      ,[cus_Password]
      ,[cus_Name]
      ,[cus_Phone]
      ,[cus_Addr]
      ,[cus_Email]
      ,[IsManager]
  FROM [TEAM4].[dbo].[Customer]

 -- insert Customer
delete from Materials_Type
insert into Customer
(cus_Id,cus_Password,cus_Name,cus_Phone,cus_Addr,cus_Email,IsManager )
values
('qwe'	,'qwe'		,'반고흐'				,'010-1111-1111'	,		'서울 강남구'		,'qwe@gmail.com'	,0			     )
,('asd'	,'asd'		,'김기리'				,'010-2222-2222'	,		'서울 구로구'		,'asd@gmail.com'		,0			     )
,('zxc'	,'zxc'	  		,'도라희'				,'010-3333-3333'	,		'경기도 광명시'	,'zxc@gmail.com'		,0			     )
,('rty'	,'rty'	  		,'땡칠이'				,'010-4444-4444'	,		'울산 남구'			,'rty@gmail.com'		,0			     )
,('fgh'	,'fgh'		,'송아지'				,'010-5555-5555'	,		'부산 서구'			,'fgh@gmail.com'		,0			     )


------------------------------------------------------------------------------Offerer
-- select Offerer
SELECT TOP (1000) [off_No]
      ,[off_Name]
      ,[off_OwnerName]
      ,[off_OwnerMobile]
      ,[off_Manager]
      ,[off_ManagerMobile]
      ,[off_Addr]
  FROM [TEAM4].[dbo].[Offerer]


-- insert Offerer
insert into Offerer 
(off_Name,		off_OwnerName,	off_OwnerMobile,			off_Manager,	off_ManagerMobile,			off_Addr	  )
values
(	'티라유텍'		,'김정하'			,'010-1111-1111'			,'심은주'		,'010-2222-2222'				,'서울 강남구'			  )
,(	'티라링'		,'조원철'			,'010-3333-3333'			,'이정철'		,'010-4444-4444'				,'서울 강남구'			  )
,(	'디투엘'			,'김길동'			,'010-5555-5555'			,'장길동'		,'010-6666-6666'				,'경기도 수원'			  )
,(	'엑센 솔루션'	,'파이썬'			,'010-7777-7777'			,'이승찬'		,'010-8888-8888'				,'서울 구로구'			  )
,(	'빅데이터'		,'이상한'			,'010-9999-9999'			,'정명훈'		,'010-1010-1010'				,'울산 남구'			  )
,(	'아리랑'			,'김아리'			,'010-3434-3434'			,'강아리'		,'010-4545-4545'				,'경기도 파주'			  )



------------------------------------------------------------------------------CompleteType
SELECT TOP (1000) [cmt_No]
      ,[cmt_Type]
  FROM [TEAM4].[dbo].[CompleteType]

  insert into CompleteType (cmt_Type)
  values
  ('발주완료')
  ,('배송중')
  ,('배송완료')

  
------------------------------------------------------------------------------Product
SELECT TOP (1000) [mat_No]
      ,[mtt_No]
      ,[off_No]
      ,[mat_Name]
      ,[mat_Cost]
      ,[mat_Each]
      ,[mat_MinSize]
  FROM [TEAM4].[dbo].[Materials]
  
------------------------------------------------------------------------------Product
SELECT TOP (1000) [pro_No]
      ,[pro_Price]
      ,[pro_Name]
      ,[pro_Img]
      ,[mat_No]
  FROM [TEAM4].[dbo].[Product]

  insert into Product(pro_Price, pro_Name, pro_Img, mat_No)
  values
  (1500, '그린티 아이스크림', 'Image/그린티.png', 2006)
 , (1500, '뉴욕 치즈케이크 아이스크림', 'Image/뉴욕 치즈케이크.png', 2007)
 , (1500, '레인보우 샤베트 아이스크림', 'Image/레인보우 샤베트.png', 2008)
 , (1500, '민트 초콜릿 칩 아이스크림', 'Image/민트 초콜릿 칩.png', 2009)
 , (1500, '바닐라 아이스크림', 'Image/바닐라.png', 2010)
 , (1500, '슈팅스타 아이스크림', 'Image/슈팅스타.png', 2011)
 , (1500, '자모카 아몬드 훠지 아이스크림', 'Image/자모카 아몬드 훠지.png', 2012)
 , (1500, '체리쥬빌레 아이스크림', 'Image/체리쥬빌레.png', 2013)
 , (1500, '초콜릿 무스 아이스크림', 'Image/초콜릿 무스.png', 2014)
 , (1500, '초콜릿 아이스크림', 'Image/초콜릿 아이스크림.png', 2015)














