
a = [1,2,3,4,5]
a[0:2]
b = a[:2]
b
c = a[2:]
type(c)

# 리스트 더하기
d = a+b
d

# 리스트 수정
a[1:2] = ['a','b','c']
a
print(a)
a[1:2] = [] # del a[1:2]
a
 
# 다차원 리스트
kor = [55, 6, 34, 60]
math = [78, 90, 45, 88]
eng = [56, 98, 78, 90]

grade = [kor, math, eng]
print('grade[0][0] : ', grade[0][0])
print('grade[1][1] : ', grade[1][1])
print('grade[2][2] : ', grade[2][2])

# mutable, immutable
x = 1
print(x, id(x))
x = 3
print(x, id(x))
x = 1
y = x
print(x, id(x))
print(y, id(y))
x = x -1 # 새로운 인스턴스를 만드므로 서로 주소값이 다름
print(x, id(x))
print(y, id(y))

x = [1,2]
y = x
print(x, y, id(x), id(y), id(x) == id(y)) 

y.append(3) # 새로운 인스턴스를 만들지 않고 append를 하므로 서로 주소값이 같음
print(x, y, id(x), id(y), id(x) == id(y))

# 문자열
x = '홍길동'
y = x
print(x, y, id(x), id(y), id(x) == id(y))

x += '배고파'
print(x, y, id(x), id(y), id(x) == id(y))

x = (1,2)
y = x
print(x, y, id(x), id(y), id(x) == id(y))
# y는 불변

# 빈 튜플
z = ()
# 빈 리스트
z = []
# 빈 딕셔너리
z = {}

# 1개의 튜플..? 괄호 연산자..?
z = (1) #<= 괄호 연산자,  튜플 => z = (1,)

# 리스트와 튜플의 차이
# 튜플
x = (1,2)
y = x

x+=y
print(x, y, id(x), id(y), id(x) == id(y)) # false

# 리스트
x = [1,2]
y = x

x += y
print(x, y, id(x), id(y), id(x) == id(y)) # true

dic = {1:'a', 1:'b'}
dic[2] = 'c'

dic.keys()
dic.values()
dic.items()

dic.clear()
dic

dic.get(1)
dic.get(2)
dic.get(3, '없다.')
#dic[1]

#1 in dic # 존재하는지?
#del dic[1] # 삭제

#dic.pop()

sets = [1,2,3,1,2,3]
print(sets, type(sets))
s2 = set([1,2,3,1,2,3])
print(s2, type(s2))

s2.add(3)
s2
s3 = {1 ,2 ,3 ,4 ,5}
type(s3)
# 초기화
s3 = set({})
type(s3)

