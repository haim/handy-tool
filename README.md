# Handy Tool

This is a windows form application written in C#. It was designed to hold shortcuts to things I use a lot during my day, to try and save some time. 

![Handy Tool screenshot](http://i.imgur.com/FTfIlhP.png)

There are different sections in the tool which serve different functions. These are explained below

## Selenium

The Selenium section allows you to start and stop a Selenium Server Hub. Once the Hub has successfully started you can start a Node. It's set to start up 5 instances of Firefox and Chrome and 1 instance of IE.

The Selenium version is 3.5.0

- Click Start Hub
- Click Start Node
- Enter localhost:4444/grid/console in your browser to check that it's started up ok
- The Node and Hub can both be stopped by clicking Stop Hub or you can stop them individually

![Selenium start up example](http://i.imgur.com/mLIYJQI.gif)

## Android

The adb devices button simply runs the command adb devices and prints the output. This is useful to check if your device is connected and properly configured to run adb commands

![adb commands example](http://i.imgur.com/vf4ryA0.gif)

## Windows

The "Open Add/Remove Programs" does what it says on the tin. It opens the Windows Add/Remove screen to allow you to quickly uninstall or modify programs

![appwiz example](http://i.imgur.com/EzxYC88.gif)

The "Open hosts file" button runs notepad.exe as administrator and opens the hosts file from C:\Windows\System32\drivers\etc

![hosts file example](http://i.imgur.com/yHMW0D1.gif)

The "Event Viewer" button opens the Windows event viewer to allow you to view logs

![event viewer example](http://i.imgur.com/1xhJney.gif)
