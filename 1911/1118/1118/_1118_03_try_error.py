class myException(Exception) : 
    def __init__(self, msg = '입력오류입니다', *args, **kwargs):
        super().__init__(*args, **kwargs)
        self.msg = msg

    def __str__(self):
        return self.msg

#try(raise) - else - finally
try:
    3/3
except :
    print('오류')
    
else :
    print('오류x')
finally : 
    print('항상')


#a = int(input('a = '))
#b = int(input('b = '))
a,b = 1, 3
try:
    int(a) / int(b)
except ZeroDivisionError:
    print('오류 발생')
else: # ZeroDivisionError를 실행하지 않았을 때
    print(a/b)



from random import randint

n = randint(1, 100)
print(n)

while True:
    ans = input("Guess my number (1~100) ? (Q to exit): ")
    if ans.upper() == "Q":
        break

    try:
        if not (ans.isdigit()) : raise myException('숫자 입력') # 문자 입력했을 때
        ians = int(ans)
        if not (0 < ians and ians < 101) : raise myException('입력 오류') # 1~100이 아닐 때
    except Exception as ee:
        print(ee)
        continue

    if (n == ians):
        print("Correct!")
        break
    elif (n > ians):
        print("UP!")
    else:
        print("Down!")

