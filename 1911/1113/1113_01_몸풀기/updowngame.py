import random 

random.random()
randVal = random.randint(0, 10)

while True:
    inputs = int(input());
    if randVal > inputs :
        print('up') 
    elif randVal == inputs :
        print ('corr mect')
        break
    else :
        print('down')

