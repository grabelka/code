import requests
from bs4 import BeautifulSoup
 
url = input('Print a URL: ')
r = requests.get(url)
page = BeautifulSoup(r.text, 'html.parser')
word = ' '
word += input('Print a word to find: ')
word += ' '
tag = input('Print a tag to find: ')
word_list = page.find_all(text=lambda t: word in t)
print("\n1. Quantity of this words is %d" %(len(word_list)))
tag_list = page.find_all(tag)
print("2. Quantity of this tags is %d" %(len(tag_list)))
a_list = page.find_all('a')
img_list = page.find_all('img')
print("3. Quantity of URLs is %d" %(len(a_list)))
print("4. Quantity of images is %d" %(len(img_list)))