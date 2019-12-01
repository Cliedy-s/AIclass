
treeHit = 0
while True:
    treeHit +=1
    print('나무를 %d번 찍었습니다.' % treeHit)
    if treeHit == 10 :
        print('10번을 찍었습니다. 쓰러집니다.')
        break
print('end')

i = 0
sum = 0
while i < 10:
    i+=1
    sum += i
print(sum)

tot = 0
for ints in [0,1,2,3,4,5,6,7,8,9,10]:
    tot += ints
print(tot)

tot =0
for ints in range(0, 11, 1) :
    tot += ints
print(tot)

# 구구단
for y in range(2, 10, 1):
    for x in range(1, 10, 1):
        print('%3d x %3d = %3d' %(y, x, y*x), end=' ')
    print()
print()
for y in range(1, 10, 1):
    for x in range(2, 10, 1):
        print('%3d x %3d = %3d' %(x, y, y*x), end=' ')
    print()
print()


gugudan = [i*j for i in range(2, 10, 1) for j in range(1, 10, 1)]
gugudan = [i*j for i in range(2, 10, 1) for j in range(1, 10, 1) if i ==2 if j %3==0]
gugudan