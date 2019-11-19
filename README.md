# Youtube-dl-GUI
A simple GUI for the youtube-dl bash utility for Windows.

### Prerequisites
Binary file tested to run on Windows 10 Home, it should work on some other Windows systems as well.
If you want to help developing the app: Visual Studio is recommended. So far developed with Visual Studio 2017.

You also need python installed and https://www.microsoft.com/en-US/download/details.aspx?id=5555 (for youtube-dl).

## How to use:
### If you want to help out with the app
Clone this git repository and use the app by (probably first updating youtube-dl by the above command and then) starting the "/bin/Release/VidMp3Downloader.exe". When it comes to development just use Visual Studio, you know what to do ;)
### If you just want to use the app
Either clone the app or download this file:
  - https://github.com/Sebbestune/youtube-dl-GUI/blob/master/VidMp3Downloader/bin/Release/VidMp3Downloader.exe

After that run the app by starting VidMp3Downloader.exe and downloading the necessary components.

## Some more things planned to be fixed:
- [ ] Better name for application
- [x] Easier download options for downloading the application itself for people that simply want to use the application and not be a part of the development 
- [x] Automatic update of youtube-dl at start of application
- [x] Application should download necessary dependencies when not present (after asking user)
- [x] Better naming of variables, code-refactoring
- [x] Code cleanup and removing uneccessary files from github solution
- [ ] Fix icon
- [x] Possible GUI fixes such as thinking through where to put buttons and what text should say etc.


This is a hobby project and was done during approximately 1-2 days since I thought it could be a nice idea to make a GUI. No extra thought were given about naming of variables and the like. Refactoring of code and increased documentation might be done in the future in case the project gets any traction.
