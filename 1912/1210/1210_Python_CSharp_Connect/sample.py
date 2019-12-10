def GetString():
    return 'Hello World'  

def Sum( num1, num2 ):
    return num1 + num2

def GetList1(data):
    data.append('Python1')
    data.append('Python2')
    data.append('Python3')
    return data

def GetList2():
    data=[]
    data.append('Python1')
    data.append('Python2')
    data.append('Python3')
    return data

class World:

    def __init__(self):
        self.name = 'AAA'

    def hello(self):
        print("Hello")

    def getName(self):
        return self.name

    def add(self, a, b):
        return (a + b)

    def setName(self, name):
        self.name = name
        return self.name