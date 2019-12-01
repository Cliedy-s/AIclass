class UserInfo:
    name = None
    age = None

    def __init__(self, name='노네임', age=None) :
        self.name = name
        self.age = age

    def printUserInfo(self):
        print(f'{self.name} : {self.age}')

    def __del__ (self): # 프로그램이 종료될 때 자동으로 호출됨
        print('객체 소멸')

class FourCalc :
    def __init__(self, name = '안녕계산기'):
        self.__name = name
        print('fourcalc :',self.__name)
    def add(self, first, second) :
        return first + second
    def sub(self, first, second) :
        return first - second
    def mul(self,first, second) :
        return first * second
    def div(self,first, second) :
        return first / second

class FiveCalc(FourCalc) :
    defaultvalue = None
    def __init__(self, name = '잘가계산기', defaultvalue = 0):
        super().__init__(name)
        self.defaultvalue = defaultvalue
        print('fivecalc :', self._FourCalc__name)

    def pow(self, first, second):
        return first ** second

    def div(self, first, second): # 재정의
        #if(second == 0) :
        #    #return self.defaultvalue
        if(second == 0) :
            return self.defaultvalue
        return first / second
    



def main():
    print(__name__)
    user1 = UserInfo('홍길동')
    user2 = UserInfo('김우빈')

    print(user1.name, user1.age, user2.name, user2.age)

    user1.printUserInfo()
    user2.printUserInfo()

    user3 = UserInfo('신민아', 30)
    user3.printUserInfo()

    calc = FourCalc()

    print(calc.add(3,5))
    print(calc.sub(3, 5))
    print(calc.mul(3, 5))

    fcalc = FiveCalc()
    print(fcalc.pow(3,4))
    print(fcalc.mul(3,0))


if(__name__ == '__main__'): main()