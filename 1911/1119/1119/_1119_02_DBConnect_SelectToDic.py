import sqlite3
import sys
from datetime import datetime

def main():
    conn = sqlite3.connect('database.db')
    conn.row_factory = sqlite3.Row # 딕셔너리 구조로 컬럼을 접근하는 옵션
    cursor = conn.cursor()

    cursor.execute("SELECT * FROM books;")

    rows = cursor.fetchall()
    for row in rows:
        print(row, row['title'], row['pages'])
    

if __name__ == "__main__":
    sys.exit(int(main() or 0))

