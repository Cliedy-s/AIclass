import random as r
import os

if(not os.path.isdir('data')):
    os.mkdir('data')

with open('data/score.txt', 'w', encoding='utf-8') as f :
    for x in range(0, 5, 1):
        randint = r.randint(50, 100)
        f.write(str(randint) + '\n')

with open('data/score.txt', 'r', encoding='utf-8') as f :
    #for line in f :
    #    if(not line):
    #        break
    sum, cnt = 0, 0
    while True:
        line = f.readline()
        if(not line) :
            break
        cnt += 1
        sum += int(line)
    print('%.3f' %(sum / cnt))