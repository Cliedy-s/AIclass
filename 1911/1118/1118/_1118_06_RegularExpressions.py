import re
str = 'my id nmber is kim0990'

answer = re.findall('[a-z]+', str)
print(answer)

a2 = re.findall('[A-Z]+', str)
print(a2)

a3 = re.findall('[0-9]+', str)
print(a3)

str = 'my id nmber is 김0990'
a3 = re.findall('[a-zA-Z0-9]+', str)
print(a3)

str = 'my id nmber is 김0990'
a3 = re.findall('[^a-zA-Z0-9]+', str)
print(a3)

str = 'my id nmber is 김0990'
a3 = re.findall('[\w]+', str)
print(a3)


def pwd_check(pwd): # 6~12자리, 영어 대문자 소문자 숫자까지
    if (len(pwd) < 6) or (len(pwd) > 12) : # 비밀번호의 길이가 적당하지 않습니다.
        return False
    if re.findall('[a-zA-Z0-9]+', pwd)[0] != pwd: # 숫자와 영문자로만 구성되어야 합니다.
        return False
    if len(re.findall('[a-z]', pwd)) ==0 or len(re.findall('[A-Z]', pwd)) ==0: # 대문자와 소문자 모두 써 주세요
        return False
    return True

def pwd_check2(pwd):
    if(len(re.findall('(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{6,12}', pwd)) > 0 ):
        return True
    return False

def email_check(email):
    if(len(re.findall('[a-zA-Z0-9]+@[a-zA-Z]+\.[a-z]+', email)) > 0) :
       print('올바른 이메일입니다.')
    else :
        print('올바르지 않는 이메일입니다.')
print()
print(pwd_check('12abc'))
print(pwd_check('123abc'))
print(pwd_check('123Abc'))
print(pwd_check('xcv467rawA'))
print()
print(pwd_check2('12abc'))
print(pwd_check2('123abc'))
print(pwd_check2('123Abc'))
print(pwd_check2('xcv467rawA'))
print()
email_check('kim88@gmail.com')
email_check('kim8_gmail.com')
email_check('kim')
email_check('kim@gmail.com')