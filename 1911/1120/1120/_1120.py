class Contact :
    def __init__(self, *args, **kwargs):
        self.name = kwargs.get('name', '노네임')
        self.phone = kwargs.get('phone','번호 없음')
        self.address = kwargs.get('address', '주소 없음')
        self.email = kwargs.get('email', '이메일 없음')

    def print_info(self):
        print(self.name, self.phone, self.address, self.email,  sep= ' : ')

def print_menu():
    print('1. 연락처 입력')
    print('2. 연락처 출력')
    print('3. 연락처 삭제')
    print('4. 종료')
    return int(input('메뉴 선택 : '))

def set_contact():
    name = input('name : ')
    phone = input('phone : ')
    address = input('address : ')
    email = input('email : ')
    return Contact(name=name, phone = phone, address = address, email = email)

def print_contact(fclist):
    for x in fclist :
        x.print_info()

def delete_contact(contacts, deleteName):
    #for x in contacts:
    #    if(x.name == deleteName):
    #        contacts.remove(x)
    for i, contact in enumerate(contacts): # 인덱스 자동 생성
        if (contact.name == deleteName) :
            print('삭제할 사람 : ', end='')
            contact.print_info()
            if(input('삭제 하시겠습니까? (Y/N)').upper().strip() == 'Y'):
                del contacts[i]

def store_contact(list):
    # text save
    with open('contact.txt','wt',encoding='utf-8') as f : # wt? : test write, wb? : binary write, w? : test write
        for contact in list:
            f.write(contact.name + '\n')
            f.write(contact.phone + '\n')
            f.write(contact.email + '\n')
            f.write(contact.address + '\n')

def load_contact(list):
    with open('contact.txt','r',encoding='utf-8') as f:
        lines = f.readlines()
        print(lines)

    cnt = int(len(lines)/4)
    for x in range(0, cnt):
        num = x * 4
        name = lines[num].rstrip('\n')
        phone = lines[num+1].rstrip('\n')
        email = lines[num+2].rstrip('\n')
        address = lines[num+3].rstrip('\n')
        list.append(Contact(name=name, phone=phone, email=email, address=address))
            
def main():
    contacts = []
    load_contact(contacts)
    while True:
        try: menu = print_menu()
        except : continue

        if(menu == 1) : contacts.append(set_contact())
        elif(menu == 2) : 
           print_contact(contacts)
        elif(menu == 3) : 
            deleteName = input('삭제할 이름 : ')
            delete_contact(contacts, deleteName)
        elif(menu == 4) : 
            # 파일에 저장
            store_contact(contacts)
            break
        
import sys
if __name__ == "__main__":
    sys.exit(int(main() or 0))