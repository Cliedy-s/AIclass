# 1. a b c d e 를 저장하는 튜플을 만들고 첫 번째 튜플값과 마지막번째 튜플값을 출력하세요.
t = ('a','b','c','d','e')
t[0]
t[-1]

# 2. 다음 코드를 작성해서 실행해보고 에러가 나는 이유를 설명하세요.
# tupledata = ('dave','fun-coding','endless')
# tupledata[0] = 'david'

#=> 튜플은 읽기전용 불변 immutable 이기때문

# 3. 다음 튜플 데이터를 리스트 데이터로 변환한 후에 'fun-coding4' 데이터를 마지막에 추가하고 다시 튜플 데이터로 변환하세요
tupledata = ('fun-coding1','fun-coding2','fun-coding3')
listdata = list(tupledata)
listdata.append('fun-coding4')
tupledata = tuple(listdata)
tupledata

# 4. 비어있는 튜플, 리스트, 딕셔너리 변수를 하나씩 각각 만드세요.
tupledata = ()
listdata = []
dicdata = {}

# 5. 다음 actor_info 딕셔너리 변수를 만들고, 홈페이지, 배우 이름, 최근 출연 영화 갯수를 다음과 같이 출력하세요.
# 배우이름:마동석
# 홈페이지 : https://www.instagram.com/madongseok
# 출연 영화 개수:3

actor_info = {
    'actor_detail' : {'생년월일' : '1971-03-01', '성별' : '남','직업': '배우', '홈페이지':'https://www.instagram.com/madongseok'},
    'actor_name':'마동석',
    'actor_rate':59361,
    'date':'2017-10',
    'movie_list' : ['범죄도시','부라더','부산행']
              } 
print('배우 이름 : ' + actor_info['actor_name'],
     '홈페이지 : '+ actor_info['actor_detail']['홈페이지'],
    '출연 영화 개수 : '+ str(len(actor_info['movie_list'])),
   sep='\n')

# 6. Apple 제거
listdata = ['Banana','Apple','Orange']

listdata.remove('Apple')
del listdata[1]

listdata

# 7. 리스트 변환
list((1,2,3,4))

# 8. 딕셔너리 선언
dicdata = {'성인':100000,'청소년':70000,'아동':30000}

# 9. 소아 항목 추가
dicdata['소아'] = 0

# 10. 키 항목만 출력
print(dicdata.keys())

# 11. 벨류 항목만 출력
print(dicdata.values())

dicdata.items()