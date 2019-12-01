from datetime import datetime
import random as r
import turtle
from urllib import request

def main():
    print(r.choice(['a','b','c','d','e']))
    lists = [1,2,3,4,5,6,7,8,9,10]
    r.shuffle(lists)
    print(lists)

    #turtle.shape('turtle')
    #for x in range(0,100,1):
    #    turtle.right(20)
    #    turtle.forward(100)
    #    turtle.left(150)
    #    turtle.forward(100)

    # 구글 개발자모드 소스 읽기
    target = request.urlopen('https://google.com')
    output = target.read()
    print(output)
    print()

    # 오늘 날짜
    print(datetime.now())
if(__name__ =='__main__') : main()