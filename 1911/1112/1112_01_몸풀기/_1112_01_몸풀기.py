# 1. 화면에 hello world를 출력하세요
print("hello world")

# 2. 화면에  i don't like  c language를 출력하세요
print ('i don\' like c language')
print ("i don' like c language")

# 3. print 함수를 사용하여 3.1415의 값을 출력하세요. // 소수점 아래는 1자리만
print('%.1f' %(3.1415))

# 4. 문자열 720 을 정수형으로 변환하세요, 정수 100을 문자열 100으로 변환하세요
int('720')
str(100)
print(type(int('720')))

# 5. 2와 4 숫자를 변수에 넣고 두 변수를 더한 값, 곱한 값, 나눈 값을 출력하세요.
a, b = 2, 4
print('%d %d %d' %(a+b, a*b, a/b))
print('{0} {1} {2}' .format(a+b, a*b, a/b))

# 6. 사용자로부터 두 개의 숫자를 입력받은 후 두 개의 숫자를 더한값, 곱한값을 각각 출력하는 프로그램을 작성하세요
a = int(input())
b = int(input())
print('%d %d' %(a+b, a*b))

# 7. niceman, google.com 문자열을 연속해서 출력할때 구분자를 @로 변경하여 출력하세요
print('niceman', 'google.com', sep='@')

# 8. str = 'Niceboy' 이 변수를 이용해서 아래와 같은 결과가 나오도록 슬라이싱하여 출력하세요
str = 'Niceboy'
print('%s'%( str[:3]))
print('%s'%( str[0:]))
print('%s'%( str[:len(str)-1]))
print('%s'%( str[0:]))
print('%s'%( str[1:4:2]))
print('%s'%( str[-3:6]))
print('%s'%( str[1:5]))
print('%s'%( str[::-1]))
print('%s'%( str[::2]))

