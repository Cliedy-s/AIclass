
def add(first, second) :
    return first + second
def sub(first, second) :
    return first - second
def mul(first, second) :
    return first * second
def div(first, second) :
    return first / second

def addother(*nums) :
    sum = 0
    for x in nums :
        sum += x
    return sum
def addkv(**knnums):
    return (knnums['a'] + knnums['b'])

def addglobal():
    global first, second
    return first + second

print(f'{add(3, 5)}')
print(f'{addother(3,5,6,7,8,9,10)}')
first, second = 10, 5
print(f'{addglobal()}')
print(addkv(a=3, b=4))

print(f'{sub(3, 5)}')