import urllib.request
from urllib.parse import urlencode, quote_plus, unquote

decode_key = unquote('5Ak3%2FVtz7hUcg2Nm%2B9P1VYqMQbfy8QieUeL4L6EPMemZWYRbs3eL7S7VX0%2FKL5P3XyNCBHkKCto%2BktnoLakrdA%3D%3D')
url = 'http://openapi.epost.go.kr/postal/retrieveNewAdressAreaCdService/retrieveNewAdressAreaCdService/getNewAddressListAreaCd'
queryParams = '?' + urlencode({ quote_plus('ServiceKey') : decode_key
     , quote_plus('searchSe') : 'dong'
     , quote_plus('srchwrd') : '사당동 1009-28'
     , quote_plus('countPerPage') : '10'
     , quote_plus('currentPage') : '1' })

req = urllib.request
req.encoding = 'UTF-8'
req.get_method = 'GET'
body = req.urlopen(url + queryParams)
response_body = body.read().decode('utf-8')
import xml.etree.ElementTree as ET
root = ET.fromstring(response_body)

cd = root.find('newAddressListAreaCd');
print(cd.find('zipNo').tag, cd.find('zipNo').text, sep= ' : ')
print(cd.find('lnmAdres').tag, cd.find('lnmAdres').text, sep= ' : ')
print(cd.find('rnAdres').tag, cd.find('rnAdres').text, sep= ' : ')
