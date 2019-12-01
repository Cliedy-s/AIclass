# Python 샘플 코드 #
import urllib.request
from urllib.parse import urlencode, quote_plus, unquote

#urllib 패키지 => 원하는 사이트 크롤링
#urllib.request ↑ => url 요청
#urllib.parse ↑ => url 구문 분석
#urllib.error
#urllib.robotparse

#5Ak3%2FVtz7hUcg2Nm%2B9P1VYqMQbfy8QieUeL4L6EPMemZWYRbs3eL7S7VX0%2FKL5P3XyNCBHkKCto%2BktnoLakrdA%3D%3D
decode_key = unquote('5Ak3%2FVtz7hUcg2Nm%2B9P1VYqMQbfy8QieUeL4L6EPMemZWYRbs3eL7S7VX0%2FKL5P3XyNCBHkKCto%2BktnoLakrdA%3D%3D');
#인코딩된 문자열을 디코딩한 문자열로 변환해서 반환
url = 'http://openapi.airkorea.or.kr/openapi/services/rest/ArpltnInforInqireSvc/getCtprvnMesureSidoLIst'
queryParams = '?' + urlencode(
    {
       quote_plus('ServiceKey') : decode_key
     , quote_plus('numOfRows') : '25'
     , quote_plus('pageNo') : '1'
     , quote_plus('sidoName') : '서울'
     , quote_plus('searchCondition') : 'DAILY' }
    )

req = urllib.request;
req.encoding = 'UTF-8'
req.get_method = 'GET'
body = req.urlopen(url + queryParams)
response_body = body.read().decode('utf-8')
#print(decode_key, '\n')
print(url+queryParams)
#print(response_body)

#xml파싱
import xml.etree.ElementTree as ET
root = ET.fromstring(response_body)
for y in root.find('body').find('items'):
    for x in y:
        ele_name = x.tag
        ele_value = x.text
        print(ele_name, ele_value, sep= ' : ')
    print()



#request = Request(url + queryParams)
#request.get_method = lambda: 'GET'
#response_body = urlopen(request).read()
#print (response_body)