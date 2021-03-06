VisualTraceroute
================

VisualTraceroute is a simple GUI based traceroute application that can map
the route to Google Maps using MaxMinds GeoIP database.

Usage
-----

Just run the application in either Windows or Mono (.NET [Client Profile] required).
Enter a target and wait for the traceroute to finish. Once it is done, you can map
it on Google Maps.

Accuracy of data
----------------

Because of limitations of ICMP and Geoip the data provided by VisualTraceroute
is only of informational value and should not be used for any serious purpouses.

Maxmind GeoIP
-------------

This application includes GeoLite data created by MaxMind, available from 
http://www.maxmind.com. It also uses MaxMinds C# Api.

### Accuracy of Geoip

By default this application uses the free GeoLiteCity database (in /res/GeoLiteCity.dat).
If you have a commercial database you can switch to it from whitin the application.

Note that there are limits as to how accurate such a system can be. Many routers are fairly
'close' (geographically speaking) so Geoip will report the same city for such nodes.

License
-------

### VisualTraceroute 

Copyright (C) 2012 Mihael Wagner

Permission is hereby granted, free of charge, to any person obtaining a copy of 
this software and associated documentation files (the "Software"), to deal in the 
Software without restriction, including without limitation the rights to use, copy,
modify, merge, publish, distribute, sublicense, and/or sell copies of the Software,
and to permit persons to whom the Software is furnished to do so, subject to the following 
conditions:

The above copyright notice and this permission notice shall be included in all copies 
or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR 
PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE 
FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR 
OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
DEALINGS IN THE SOFTWARE.

### MaxMind GeoIP C# API

Copyright 2011 MaxMind Inc
Licensed under the LGPL

http://www.maxmind.com
