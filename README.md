vghere
======

vghere is wget type visual web downloader application for windows.

Download, install and usage
-------
1. Download or build executable (https://github.com/vetoketju/wghere/blob/master/wghere_source/bin/Release/wghere.exe)

2. Place wghere.exe to C:\Windows

3. Add wghere to the mouse context menu
- open registry editor: windows + r > regedit
- go to HKEY_CLASSES_ROOT\Directory\shell
- add new key "Download here..." and under that key add new key "command"
- edit default under "command"
- copy & paste to Value data: C:\Windows\wghere.exe %w

4. Done
Now you can download anything from the web to your current working directory


Licence
-------
GPL V.3 http://www.gnu.org/licenses/gpl.txt
