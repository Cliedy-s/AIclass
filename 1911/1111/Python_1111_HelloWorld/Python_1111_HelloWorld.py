import keyword # 내장 모듈

print(keyword.kwlist)


'''
print('hello world')
print(123)
print('안녕하세요')
'''

# 한 줄 주석
'''
여러 줄 주석입니다.
'''
print('Hello', 'World', 123, 234, sep=',', end=' "this is end token" ')

print('Hellorlaro 김개똥')
print('hello','world', '\n', ' ', '\'')

i = 23
print(i)

i= 'abc'
print(i)

print()

a = 1
b = 2
a, b = b, a

# input what is your name
# a = input("What is your name")
print(a)
# b = input("What is your ID?")
print(b)

a = 2147483648
print(a)

print('I\'m OK!!')

print(
'''
'Hello',
'김개똥',
'안녕하세요'
'''
)

print(type('python'))
print(type(1234))

print(type(str(123)))

print('=' * 50)

# 문자열
a = 'Life is too short, You need Python'
# 인덱싱
print(a[-6])
# 슬라이싱
print(a[0:4])
print(a[12:17])
print(a[:12]) # 0부터 12까지
print(a[3:]) # 3부터 끝까지
print(a[:5:24])
# 포멧팅
