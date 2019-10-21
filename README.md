# youtube-dl-GUI
A simple GUI for the youtube-dl bash utility for Windows.

Notice that if youtube-dl is updated as of now the utility will stop working and wait for you to first update youtube-dl in the command window. This is done through: "youtube-dl -U" (more info: https://github.com/ytdl-org/youtube-dl ).

### Prerequisites
Binary file tested to run on Windows 10 Home, it should work on some other Windows systems as well.
If you want to help developing the app: Visual Studio is required. So far developed with Visual Studio 2017.
## How to use:
### If you want to help out with the app
Clone this git repository and use the app by (probably first updating youtube-dl by the above command and then) starting the "/bin/Release/VidMp3Downloader.exe". 
### If you just want to use the app
Either clone the app or download these 4 files into the same folder:
  - https://github.com/Sebbestune/youtube-dl-GUI/blob/master/VidMp3Downloader/bin/Release/VidMp3Downloader.exe
  - https://github.com/Sebbestune/youtube-dl-GUI/blob/master/VidMp3Downloader/bin/Release/ffmpeg.exe
  - https://github.com/Sebbestune/youtube-dl-GUI/blob/master/VidMp3Downloader/bin/Release/ffprobe.exe
  - https://github.com/Sebbestune/youtube-dl-GUI/blob/master/VidMp3Downloader/bin/Release/youtube-dl.exe

After that run the app by updating youtube-dl and then starting VidMp3Downloader.exe 

## Some more things I'm planning to work on in the future:
[] Better name for application
[] Easier download options for downloading the application itself for people that simply want to use the application and not be a part of the development 
(Right now this can be done by downloading the following files into the same folder: 
  - https://github.com/Sebbestune/youtube-dl-GUI/blob/master/VidMp3Downloader/bin/Release/VidMp3Downloader.exe
  - https://github.com/Sebbestune/youtube-dl-GUI/blob/master/VidMp3Downloader/bin/Release/ffmpeg.exe
  - https://github.com/Sebbestune/youtube-dl-GUI/blob/master/VidMp3Downloader/bin/Release/ffprobe.exe
  - https://github.com/Sebbestune/youtube-dl-GUI/blob/master/VidMp3Downloader/bin/Release/youtube-dl.exe
)
[] Automatic update of youtube-dl at start of application
[] Application should download necessary dependencies when not present (after asking user)
[] Fix icon
[] Possible GUI fixes such as thinking through where to put buttons and what text should say etc.

This is a hobby project and was done during approximately 1-2 days since I thought it could be a nice idea to make a GUI. No extra thought were given about naming of variables and the like. Refactoring of code and increased documentation might be done in the future in case the project gets any traction.

- Sebastian
