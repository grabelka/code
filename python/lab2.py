import requests
from bs4 import BeautifulSoup
 
url = input('Print a URL: ')
r = requests.get(url)
page = BeautifulSoup(r.text, 'html.parser')
word = ' '
word += input('Print a word to find: ')
word += ' '
all = page.get_text()
all_list = all.split()
tag = input('Print a tag to find: ')
word_list = page.find_all(text=lambda t: word in t)
print("\n1. Frequency of this words is %.2f %%" %(float)(len(word_list)/len(all_list)*100))
tag_list = page.find_all(tag)
all_tag_list = page.find_all()
print("2. Frequency of this tags is %.2f %%" %(len(tag_list)/len(all_tag_list)*100))
a_list = page.find_all('a')
img_list = page.find_all('img')
print("3. Quantity of URLs is %d" %(len(a_list)))
print("4. Quantity of images is %d" %(len(img_list)))