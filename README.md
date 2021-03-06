SpotifyToaster
==============

Presents toast notifications (system tray popups) when Spotify changes songs.

![toast notification example](https://raw.githubusercontent.com/aauren/SpotifyToaster/master/images/toastNotificationExample.png)

## Background
I'm an avid Spotify user, but I've always felt that it was missing a way to identify the songs as they changed. Other applications like Windows Media Player or Winamp had the option of displaying toast notifications which I always referred to as "System Tray Popups." These popups would be displayed when a new song started and would appear near the clock on the Windows Menu Bar to give you the name of the artist, album, track number, and track title along with the album art.

So with this project I've attempted to recreate those notifications for Windows Spotify users. If you're like me and you miss those popups as well, feel free to use this application.

## Pre-requisites
A Windows based operating system. I've only tested it with Windows 7, but it **should run on any system that is installed with .NET 4.0 or higher**. I would be grateful for any testing others are willing to do.

**Disclaimer** - This project, to my knowledge, has only been tested on my own system so far. If you do end up testing it, please let me know how it works for you so that I can remove this section. = )

## Installation
Currently, the application is only a simple .exe file so you need only copy it to your computer and double-click it to get it going.

The compiled application lives in the bin folder, to make it easier though, you can:

**[Download The Application Here](https://github.com/aauren/SpotifyToaster/blob/master/bin/Release/SpotifyToaster.exe?raw=true)**

You don't need to have Spotify running in order to start the application. If everything went well, you should see something similar to [this](https://github.com/aauren/SpotifyToaster/blob/master/images/toastStartupNotificationExample.png) after double-clicking the exe. The next time you start Spotify and begin playing music, the application will begin notifying you of the songs being played. When you want to close the application just find the toast icon in your system tray (area near your clock), right-click it, and then click "Exit".

## Known Issues
If you have any questions about how this application works, or any problems please check the [issues](https://github.com/aauren/SpotifyToaster/issues) section first to see if your problem is already mentioned there. Please also use the search box as a question or issue that you have may already have been answered and closed. If not, feel free to add an issue that describes the problem you're experiencing.

1. [Windows ClearType Font Problems](https://github.com/aauren/SpotifyToaster/wiki/Windows-ClearType-Font-Problem)

## Contribution
I welcome any help people are willing to give just submit a pull request. In the future, I'll put more information here on how to build this application, but for right now if you're familiar with Visual Studio you should be fine.

One thing that you will need to do (if you want to see album artwork in your builds) will be to go to [LastFM's API Page](http://www.last.fm/api) and get your API keys. Once you have those, you need to create a resource within Visual Studio by doing the following:

1. Right-Click project name (SpotifyToaster) > Add > New Item...
2. Search or browse for an item named "Resources File"
3. Change it's name in the box at the bottom of the screen to: "ProtectedResources.resx"
4. In the Solution Explorer, drag this resource into the "Properties" folder
5. Double-Click ProtectedResources.resx and add a key value pair for lastFmAPIKey and add the key that you got from LastFm
 
## Credits
##### Ranveer Raghuwanshi ([GitHub](https://github.com/ranveer5289) [StackOverflow](http://stackoverflow.com/users/776084/ranrag)) and Matthew Javellana ([Gmail](mmjavellana@gmail.com))
When I first started this project, the first thing I did was look around to see if anything like this already existed. In fact, Ranveer and Matthew had already done a great job of producing this same functionality for Growl, Snarl, and Notifu in his application [spotifynotifier](https://code.google.com/p/spotifynotifier/). The only problem is that I had no other need for these notification frameworks and felt that they were a bit heavy for my use case.

So, as the application is now, most of the work of getting the current track, artist, and eventually album art is derrivitive from their original application. My original work mostly comes in with some refactoring that I did and the actual mechanism that displays the toast notification. Thanks Ranveer and Matthew!

##### aku - http://stackoverflow.com/users/1196/aku
My first ideas of how to animate a toast notification came from [aku's post on StackExchange](http://stackoverflow.com/questions/461184/toast-style-popup-for-my-application)
