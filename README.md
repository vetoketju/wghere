vghere
======

vghere is wget type visual web downloader application for windows.

![Screenshot](/wghere_screenshot.jpg "Screenshot")


Download, install and usage
-------
1. Download or build executable (https://github.com/vetoketju/wghere/blob/master/wghere_source/bin/Release/wghere.exe)

2. Place wghere.exe under "C:\Windows" -directory

3. Add "Download here..." command to the mouse context menu

 a. open Registry Editor: windows + r > regedit

 b. go to HKEY_CLASSES_ROOT\Directory\Background\shell

 c. add new key "Download here...", under that add another new key "command"

 d. edit default -value under "command"

 e. type C:\Windows\wghere.exe %w to Value data.

4. Done
Now you can download anything from the web to your current working directory


Licence
-------
GPL V.3 http://www.gnu.org/licenses/gpl.txt
