name = 'sdf'# input('당신의 이름은?')
age = str(12) # input('당신의 나이는?')
floating = 123.456789101112

print('이름은 ',name ,'이고 나이는 ',age,'입니다', sep= '')
print('이름은 ' + name  +'이고 나이는 ' +age +'입니다')

print('이름은 %s이고 나이는 %d입니다. %%' %(name, int(age)))
print('이름은 {0}이고 나이는 {1}입니다. %%' .format(name, int(age)))
print('이름은 {name}이고 나이는{age} 입니다' .format(name=name, age=age))
print('%.5f' % floating)

print(name.join('helloworld'))


print('Python')
