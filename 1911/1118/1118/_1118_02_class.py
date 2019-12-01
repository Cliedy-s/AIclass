import sys
class My:
    def __init__(self, *args, **kwargs):
        self.name = 'korea'
        print('My')

    def getName(self):
        return self.name

class SubMy(My):
    # 자식이 생성자를 오버라이드하면 
    # 부모의 생성자는 호출이 안됨
    # 인스턴스 상속x
    def __init__(self, *args, **kwargs):
        super().__init__(*args, **kwargs)
        print('SubMy init')

    def subPrint(self):
        print('SubPrint :', self.getName())


def main(): 
    s = SubMy()
    print(s.name, s.getName(), s.subPrint())

if __name__ == "__main__":
    sys.exit(int(main() or 0))
