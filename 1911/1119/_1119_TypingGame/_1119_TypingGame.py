import sqlite3
import random as r
import time
import winsound as sound
import threading

def playsound(filepath):
        sound.PlaySound(filepath, sound.SND_FILENAME)

words = []
with open('resource/word.txt', 'r', encoding='utf-8') as f :
    for word in f:
        words.append(word.strip())

input('ready? press any key ... ')
start = time.time() # 현재 시간
n = 1 # 게임 시도 횟수
collect = 0
while n <= 5:
    r.shuffle(words)
    q = r.choice(words)
    print(q)
    x = input('#{0}>> ' .format(n))
    if (q.strip() == x.strip()) :
        t = threading.Thread(target=playsound, args=('./sound/good.wav',))
        t.start()
        print('pass!')
        collect += 1
    else :
        t = threading.Thread(target=playsound, args=('./sound/bad.wav',))        
        t.start()
        print('wrong!')
    n += 1
    
end = time.time() # 완료한시간
et = format(end - start, '.3f')

print(f'{et} : {collect}개 맞춤')
if collect >= 3 : 
    print('Success!')
else : print('Fail!')

initial = input('initial : ')

conn = sqlite3.connect('./records.db')
cursor = conn.cursor()
## 존재하지 않을 경우 생성
cursor.execute('''CREATE TABLE IF NOT EXISTS scores ( 
                    id integer primary key autoincrement
                    , name text
                    , score INT 
                    , record text
                    , regdate text
                    ); ''')
# insert
from datetime import datetime 
cursor.execute(f'INSERT INTO scores (name, score, record, regdate) VALUES(?, ?, ?, ?)', (initial, collect, et, datetime.now().strftime('%Y-%m-%d %H:%M:%S'))) # H: 24시간, 
conn.commit()
# select
cursor.execute('SELECT name, record, score FROM scores ORDER BY record, score')
print('랭킹')
print((cursor.fetchall()))
conn.close()    