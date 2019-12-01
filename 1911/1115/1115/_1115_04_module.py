import sys
from sub import _1115_03_class as mymodule
from sub._1115_03_class import FiveCalc  # 필요한 클래스만 읽기
from forPathTest import module1
import math
from math import pi, sin 


def main():
    print(math.pi)
    print(pi)
    print(sin(10))
    print('\n'.join(sys.path))

    calc = FiveCalc()
    


if(__name__ =='__main__') : main()