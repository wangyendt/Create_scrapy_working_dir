E:
cd E:\Programmes\Scrapy
scrapy startproject %1
cd %1
scrapy genspider spider_%1 %2
cd %1
echo # coding: utf-8 > main.py
echo.>> main.py
echo from scrapy import cmdline >> main.py
echo.>> main.py
echo cmdline.execute('Scrapy crawl spider_%1'.split()) >> main.py
start main.py
pause