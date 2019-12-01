import sqlite3
import sys
from datetime import datetime

def createDB() :
    conn = sqlite3.connect('database.db')
    cursor = conn.cursor()
    # print('커서 타입 :', type(cursor))

    cursor.execute(''' create table if not exists books(
                            title text,
                            published_date text,
                            publisher text,
                            pages integer
                             ); ''')

    #insert query ========================================================================

    nowdt = datetime.now().strftime('%Y-%m-%d %H:%M:%S')
    print(nowdt)

    # cursor.execute('''INSERT books (title, published_date, publisher, ListPrice, pages, regdate) VALUES (?, ?, ?, ?, ?, ? ); ''')
    #cursor.execute(f"INSERT INTO books (title, published_date, publisher, pages) VALUES ('박', '{nowdt}', '이랑', 1 ); ")
    #cursor.execute(f"INSERT INTO books (title, published_date, publisher, pages) VALUES ('김', '{nowdt}', '이랑', 2 ); ")
    #cursor.execute(f"INSERT INTO books (title, published_date, publisher, pages) VALUES ('치', '{nowdt}', '이랑', 3 ); ")

    #cursor.execute("INSERT INTO books (title, published_date, publisher, pages) VALUES (?,?,?,? ); ", ('박',nowdt,'이랑',1))

    userlist = [
        ('신', nowdt ,'011-1111-1111',3),
        ('검', nowdt ,'011-2222-1111',3),
        ('래', nowdt ,'011-1111-3333',3),
                ]

    #cursor.executemany("INSERT INTO books (title, published_date, publisher, pages) VALUES (?,?,?,? ); ", userlist)
    conn.commit()
    ## ===============================================================================
    
    ## select query ========================================================================
    cursor.execute("SELECT * FROM books;")

    #print(cursor.fetchone())
    #print(cursor.fetchmany(3))
    #print(cursor.fetchall())

    rows = cursor.fetchall()
    for row in rows:
        print(row)

    ## ===============================================================================

    ## update
    cursor.execute('UPDATE books SET published_date = ? WHERE title = ?', (nowdt, '박'))
    conn.commit()
    ##

    ##delete 
    cursor.execute('DELETE FROM books WHERE title = ?', ('박',))
    conn.commit()
    ##



    conn.close()

    






def main():
    print(sqlite3.version) # 모듈 버전
    print(sqlite3.sqlite_version) # sqlite 버전

    createDB()

if __name__ == "__main__": sys.exit(int(main() or 0))

