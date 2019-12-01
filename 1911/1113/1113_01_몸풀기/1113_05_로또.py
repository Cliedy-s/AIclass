import random as r

lotto = set({})
while len(lotto) < 6 : 
    lotto.add(r.randint(1, 6))
print(list(lotto))


lst = range(1, 47)
r.sample(lst, 6)



