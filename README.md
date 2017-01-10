wghere
======

wghere is a wget-type visual web downloader application for Windows.

![Screenshot](/wghere_screenshot.jpg "Screenshot")


Download, install and usage
-------
1. Download or build the executable (https://github.com/vetoketju/wghere/raw/master/wghere_source/bin/Release/wghere.exe)

2. Place wghere.exe under the `C:\Windows` directory.

3. Add "Download here..." command to the mouse context menu:

 a. open the Registry Editor: windows + r > regedit

 b. go to `HKEY_CLASSES_ROOT\Directory\Background\shell`

 c. add a new `wghere` key

 d. edit its default value to `Download here...`

 e. add another key called `command` under `HKEY_CLASSES_ROOT\Directory\Background\shell\wghere`

 f. edit its `default` value to `C:\Windows\wghere.exe %w`

4. (optional) Add an icon to the mouse context menu:

 a. open the Registry Editor: windows + r > regedit

 b. go to `HKEY_CLASSES_ROOT\Directory\Background\shell\wghere`

 c. add a new string called `Icon` and set it to `C:\Windows\wghere.exe`

5. Done!

Now you can download anything from the web to your current working directory. Simply right-click on the empty space inside the directory to bring up the context menu and click on the new "Download here..." command that's available. Enter the download link in the dialog that pops up and hit the "Download" button.

Licence
-------
GPL V.3 http://www.gnu.org/licenses/gpl.txt
