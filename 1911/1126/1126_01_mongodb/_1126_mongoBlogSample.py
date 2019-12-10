from pymongo import MongoClient
import sys
import datetime
#pymongo 모듈을 사용하면, 몽고DB에서 사용하는 명령어와 거의 흡사하게 프로그램 할 수 있다.

#MongoClient("127.0.0.1", 27017)
#client = MongoClient("mongodb://test:1234@127.0.0.1:27017/")
client = MongoClient("mongodb://127.0.0.1:27017/")
db = client.python_db


def insert():
    title = input("제목 : ")
    writer = input("작성자 : ")
    contents = input("내용 : ")

    db.blog.insert_one({
        "title": title,
        "contents": contents,
        "writer": writer,
        "wdate": datetime.datetime.now().strftime('%Y-%m-%d %H:%M:%S')
    })
    print('--------------------------------------------------------------')


def update():
    from_title = input("원본제목 : ")
    to_title = input("수정제목 : ")

    db.blog.update_one({"title": from_title}, {"$set": {"title": to_title}})
    print('--------------------------------------------------------------')


def delete():
    title = input("제목 : ")
    row = db.blog.find_one({'title': title})

    db.blog.delete_one({
        "_id": row['_id']
    })
    print('--------------------------------------------------------------')


def select():
    rows = db.blog.find()

    for row in rows:
        print(row['title'], row['contents'], row['writer'], row['wdate'])
    print('--------------------------------------------------------------')


def main():
    while (True):
        sel = input("1.목록, 2.추가 3.수정 4.삭제 0.종료 \n")
        if sel == "1":
            select()
        elif sel == "2":
            insert()
        elif sel == "3":
            update()
        elif sel == "4":
            delete()
        elif sel == "0":
            break
if __name__ == "__main__":
    sys.exit(int(main() or 0))

