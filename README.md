#PowerBar 1.4
![main window](http://i.imgur.com/4QhEygo.jpg)

A bar on the desktop with essential PC info and controls including:

* CPU usage and speed
* RAM usage and size
* Network upload/download (single adapter at a time)
* Disk read/write rate
* Computer uptime
* Time and date
* Master volume left and right level
* Master Windows volume control and mute

All settings are save in the local user profile (My.Settings).

##Requirements
* .NET Framework 4
* Windows XP/Vista/7/8/8.1/10
* Minimum recommended monitor width: 720 pixels

##How to use
* Run the program. A bar will appear on the right side of the screen (primary monitor).
* Hover over a control or text to get information on it
​* Right click on a graph bar to change it's foreground and background color
* Right click on label, button or anywhere else to exit or show the options window:

##Options
![options window](http://i.imgur.com/EwmUcs7.png)

* The general update interval is the interval at which all the graphs and information update at (in seconds)
* The VU Meter update interval is the interval at which the left and right volume bars update themselves (in milliseconds)
* The Net Adapter dropdown controls which network adapter's upload and download speeds will be monitored.
* Be sure to choose the right one for wireless or ethernet. If the selected adapter does not exist anymore, the application will reset this setting on start
* The Position dropdown lets you choose where the bar is positioned (primary monitor)
* The Foreground and Background is that of the bar itself. * The Foreground changes the color of all text labels.
* The Opacity setting toggles between "Solid" and "Transparent". When solid, the selected background color is PowerBar's background. When transparent, the PowerBar background is see-through and click-through. You can still access the context menus by right-clicking on controls or text.
