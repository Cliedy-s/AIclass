# 읽기
import csv # mime? : text/csv

with open('data/data1.csv', 'r') as f :  # encoding='cp949/utf-8'
    reader = csv.reader(f)

    next(reader) # 줄 하나 스킵
    for line in reader:
        print(' '.join(line))

    print(reader)
    print(type(reader))


with open('data/data2.csv', 'r') as f :  # encoding='cp949/utf-8'
    reader = csv.reader(f, delimiter = '|')

    next(reader) # 줄 하나 스킵
    for line in reader:
        print(' '.join(line))

#---------------------------------------------------------------------------
#딕셔너리 읽기

with open('data/data2.csv', 'r') as f :  # encoding='cp949/utf-8'
    reader = csv.DictReader(f, delimiter = '|')

    #next(reader) # 줄 하나 스킵
    for line in reader:
        for k, v in line.items():
            print(k , v, sep = ' : ')
        #print(line)
        print('-' * 50)


# ============================================
# 쓰기

wl = [['a',42],['b',3],['b',11],['va',5],['c',34],['d',1],['e',4],['f',1],['s',10]]

with open('data/dataWrite01.csv', 'w', newline='') as f:
    writer = csv.writer(f)
    writer.writerows(wl) # 한번에 다 쓰기

    for x in wl:
        writer.writerow(x) # 하나씩 쓰기