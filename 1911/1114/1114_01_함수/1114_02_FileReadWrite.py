
# dir
import os
    # mkdir
if(not os.path.isdir('data')):
    os.mkdir('data')
    
# file
import sys
print(sys.stdin.encoding)
print(sys.stdout.encoding)
    # create file
f = open('data/test.txt', 'w', encoding='utf-8')
f.close()
        # with
with open('data/test.txt','w', encoding='utf-8') as f:
    f.write('write with with')

    # write file
        #delete original
f = open('data/test.txt','w', encoding='utf-8')
for x in range(1,11):
    data = f'{x}번째 줄입니다. \n'
    f.write(data)
f.close()
        #append
f = open('data/test.txt','a', encoding='utf-8')
f.write('-' * 50)
for x in range(11,21):
    f.write(f'\n{x} : Hello Python ')
f.close()


    # read file
        # readlines => list
print()
f = open('data/test.txt','r',encoding= 'utf-8')
print(''.join(f.readlines()))
f.close()
        # readline => string
f = open('data/test.txt','r',encoding= 'utf-8')
while True:
    line = f.readline()
    if(not line) :
        break
    print(line, end='')
f.close()
        # readline => string (2)
with open('data/test.txt','r',encoding= 'utf-8') as f :
    for word in f:
        print(word.strip())

        # read => big string
print()
f = open('data/test.txt','r',encoding= 'utf-8')
print(f.read())
f.close()


