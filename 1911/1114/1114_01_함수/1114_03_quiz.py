
A = [1,2,3,4,5,6,73,8,10,54]

def maxFunc(list):
    max = list[0]
    for x in list:
        if(x > max):
            max = x
    return max

def maxFunc2(list):
    max = list[0]

    def toMax(x) :
        nonlocal max
        if( x > 0 ) :
            max = x

    map(toMax, list)    
    return max

print(maxFunc(A))
print(maxFunc2(A))
print(max(A))
print(min(A))
