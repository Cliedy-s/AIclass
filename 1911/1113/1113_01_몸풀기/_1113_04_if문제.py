# 1~5문 if
# 1. 가을에 해당하는 과일을 출력하세요
q1 = {'봄': '딸기','여름':'토마토','가을':'사과'}
print(q1['가을'])

# 2. 
q2 = {'봄': '딸기','여름':'토마토','가을':'사과'}
for x in q2.items():
        if(x[0] =='사과') or (x[1] =='사과') :
            print(x[0], x[1])
            
for (key, value) in q2.items():
        if(key =='사과') or (value =='사과') :
            print(key, value)

hasf = ' '.join([ value for (key, value) in q2.items() if (key=='사과')or (value =='사과')])
if(len(hasf) > 0):
    print('사과 포함')
else :
    print('사과 불포함')

# 3.
score = 50
if score > 80 :
    print('A')
elif score > 60 :
    print('B')
elif score > 40 :
    print('C')
elif score > 20 :
    print('D')
else :
    print('E')

# 4.
max = 12
for x in [12, 6, 18]:
    if max < x:
        max = x
print(max)

lists = [12, 6, 18]
lists.sort()
lists[-1]

# 5. 
idnum = '123456-1234567'
if int(idnum[7]) %2 :
    print('남')
else :
    print('여')

# 6.
q3 = ['갑','을','병','정']
q3 = [ value for value in q3 if value != '정']
print(' '.join(q3))

for x in q3:
    if(x =='정') :
        continue
    print(x, end=' ')
print()

# 7. 
for x in range(0,100,1):
    if x%2 :
        print(x, end = ' ')

print(' '.join([str(x) for x in range(0, 101, 1) if x%2]))
print()
# 8.
q4 = ['nice','study','python','anaconda','!']
for x in q4:
    if len(x) >= 5:
        print(x, end =' ')
print()

# 9.
q5 = ['A','B','c','D','e','F','G','h']
for x in q5:
    if x.islower():
        print(x, end = ' ')
print()
# 10.
q6 = ['A','b','c','D','e','F','G','h']
for x in q6:
    if x.islower():
        x=x.upper()
    else :
        x=x.lower()
    print(x, end = ' ')
q6

# comprehention
' '.join([ str.upper() if str.islower() else str.lower() for str in q6 ])