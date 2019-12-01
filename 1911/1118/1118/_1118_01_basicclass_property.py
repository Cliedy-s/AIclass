class TestClass:
    memberCnt = 0
    #def __init__(self, name='홍기롷' , phone='010-1111-1111'):
    #    self.name = name
    #    self.phone = phone
    #    print('생성')

    #def __init__(self, **kwargs): # 많이 쓰는 방법
    #    self.name = kwargs.get('name', '홍길동')
    #    self.phone = kwargs.get('phone','010-1111-1111')
    #    print('생성')
        
    #def __init__(self, *kwargs):
    #    self.name = kwargs['name'] == None and '홍길동' or kwargs['name']
    #    self.phone = kwargs['phone'] == None and '010-1111-1111' or kwargs['phone']
    #    print('생성')

    def __init__(self, *args, **kwargs):
        if len(args) == 2:
            self.__name = args[0]
        else:
            self.__name = kwargs.get('name', '홍길동')
            self.phone = kwargs.get('phone','010-1111-1111')
        print('생성')
        TestClass.memberCnt +=1 

    # property
    # get
    @ property
    def name(self):
        return self.__name
    # set
    @ name.setter
    def name(self, name):
        self.__name = name
    #

    def showInfo(self):
        return self.__str__()

    # == ToString()
    def __str__(self):
        return f"name : {self.name} phone : {self.phone}"

    def __del__(self):
        TestClass.memberCnt -= 1
        print('소멸')

def main():
    tc = TestClass(name = '홍길동', phone = '111-1111-1111')
    tc2 = TestClass()
    tc3 = TestClass('박박박','333-3333-3333')

    print(tc)

    print(tc2) # __str__
    print(tc2.showInfo())

    print(id(tc), id(tc2))

    print(tc.__dict__)
    print(tc2.__dict__) # 속성 값만 보여줌

    print(dir(tc)) # 선언된 메서드까지 보여줌

    print(TestClass.memberCnt, tc.memberCnt, tc2.memberCnt)
    del tc2
    print(TestClass.memberCnt, tc.memberCnt)
    print(tc)

if (__name__ == '__main__') : main()