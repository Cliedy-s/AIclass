tuplelist = ('강아지','토끼','돼지','곰')
tuplelist = tuplelist + ('호랑이',) # tuple + tuple = tuple
tuplelist2 = (list(tuplelist)).append('개')
tuplelist3 = tuple(tuplelist2)
print(tuplelist3)

print(tuplelist)

tuplelist[:3]
tuplelist.index('강아지')
    
print(str(tuplelist))
print(','.join(tuplelist))
print(list(tuplelist))