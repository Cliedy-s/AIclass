def sum(a, b) :
    return a+b

def say_myself(name,  man=True, old = 20):
    print("나의 이름은 %s 입니다." % name)
    print("나이는 %d살입니다." % old)
    if man:
        print("남자입니다.")
    else:
        print("여자입니다.")
    print();

def sums(*ints): # => 여러 값 전달
    sum = 0
    for x in ints: 
        sum += x
    return sum

def cal(choice='Sum', *args, result = 0):
    if choice == "Sum":
        result = 0
        for i in args:
            result += i
    elif choice == "Mul":
        result = 1
        for i in args:
            result *= i
    else:
        result = "오류 발생"
    return result


abc = (1,2,3,4,5)
#print(sums(abc)) 
print(sum(1,3))

say_myself('홍길동')
say_myself('홍길동',30)
say_myself('홍길동', old = 30)
say_myself('홍길동', man = False)
say_myself('홍길동', True, 25)

print(sums(1,2,3,4,5,6,7,8))
print(sums(1,2,3,4,5))
print(sums(1,2,3))

print(cal('Mul', 1,2,3,4,5,6,7,8,9,10))

a = 3
b = 4


def myNum(**kwargs):
    print(kwargs)
    print('First value : {first}'.format(**kwargs)) # **kwargs의 first
    print('First value : {0}'.format(kwargs['first'])) # **kwargs의 first
    print('Second value : {second}'.format(**kwargs))


print(f'{a:8}{b:3}')
print(f'{a+b:3}') # 산술연산 지원 f-string

myNum(first=1, second=2) # 'first' :1 'second' :2 

n = 5

def myFun():
    global n # 전역변수 지정
    n += 1
    return n

print(myFun())
print(n)

# 람다식
f = lambda x: x**2
print(f(8))

# immutable, mutable의 차이
print('call_by_value' + '-' * 50)
def call_by_value(num, mlist):
    print(id(num))
    num += num
    print(id(num))
    mlist.append('add 1')

num = 10
mlist = [1,2,3]

print(num, mlist , id(num) )
call_by_value(num, mlist) # num(immutable) => 값 수정x, num에 새로운 값 줌 , mlist (mutable) => 값 수정 o
print(num, mlist, id(num))

print('call_by_value'+ '-' * 50)
# 함수의 스코프 _1
g_val = 3
def foo():
    l_val = 2
foo()

g_val = 3
def foo():
    g_val = 2 # 새로운 지역변수 선언
foo()
print (g_val)

g_val = 3
def foo():
    l_val = g_val
    print (l_val)
foo()

g_val = 3
def foo():
    global g_val
    g_val = 2
foo()
print (g_val)

# 함수의 스코프 _2
x = "global"
def foo():
    print('x inside :', x)
foo()
print('x outside :', x )

x = "global"
def foo():
    # x = x*2 # 오류 : 지역변수 x를 선언하지 않음
    print(x)
foo()

def foo():
    y = 'local'
foo()
# print(y) # => foo local을 가져올 수 없음

x = 5
def foo():
    x = 10
    print('local x :', x)
foo()
print('global x :', x )

# 함수의 스코프 _3
x = 'global'
def outer():
    x = 'local'
    def inner():
        nonlocal x
        x = 'nonlocal'
        print('inner :',x)
    inner()
    print('outer :',x)
outer()
print('global :', x)

# 람다
print((lambda x,y : x+y )(10,20))

pairs = [(1, 'one'), (2, 'two'), (3, 'three'), (4, 'four')]
def shortKey(pair) :
    return pair[1]

pairs.sort(key = shortKey)
pairs.sort(key = lambda pair: pair[0] )
print(pairs)

# 함수를 반환하는 함수
def make_incrementor(n):
    print("n", n)
    return lambda x: x + n
f = make_incrementor(42) # f 함수를 생성함
print(make_incrementor(0))
print(f)
print(f(0))
print(f(1))
print(make_incrementor(65)(1))

# 내장 함수
#eval(input()) # 문자열을 그대로 실행시켜줌 # evaluate

mylist = ['apple','banana']
for x in mylist:
    print(x)

mylist = ['apple','banana']
for i, v in enumerate(mylist, 1):
    print(i, v)
    
mylist = ['apple','banana']
for v in range(0, len(mylist)):
    print(v)

 #zip
actor = ['정우성','나나']
gender = ['여','여']
for x in zip(actor, gender):
    print(','.join(x))

#unzip
gentor = {'정우성':'여','나나':'여'}
a, b = zip(*gentor)
a
