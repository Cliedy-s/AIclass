import csv


with open('data/population.csv', 'r') as f :  # encoding='cp949/utf-8'
    kvpair = ('', 0)

    reader = csv.reader(f)
    next(reader) # 줄 하나 스킵
    for line in reader:
        iv = int(line[1].replace(',',''))
        if(kvpair[1] < iv) :
            kvpair = (line[0], iv)
    print(f'{kvpair[0]} : {kvpair[1]:,}') # 3자리 포멧팅

    
with open('data/population.csv', 'r') as f :  # encoding='cp949/utf-8'
    reader = csv.reader(f)

    max = 0
    key = ''
    next(reader) # 줄 하나 스킵
    #reader = reader[1:] # 외안되지

    def toMax(llist) :
        global max, key
        iv =  int(llist[1].replace(',',''))
        if( iv > max) :
            key, max = llist[0], iv
        return [key, max]

    mlist = []
    for line in reader:
        mlist.append(line)
    mlist = list(map(toMax, mlist))
    #mlist = map(toMax, mlist)
    
    print(f'{key} : {max:,}')



#with open('data/population.csv', 'r') as f :  # encoding='cp949/utf-8'
#    reader = csv.DictReader(f, delimiter = ',')

#    #next(reader) # 줄 하나 스킵
#    max = 0
#    key = ''
#    for line in reader:
#        for k, v in line.items():
#            if(k =='Population'):
#                iv = v.replace(',','')
#                print(k, iv)
#            #if(max < int()) :
#            #   max = v
#            #   key = k
#        print('-'*50)