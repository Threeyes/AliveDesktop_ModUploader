# AliveDesktop_ModUploader

## Introduction
I create this sample project to upload mods to [Steam Workshop](https://steamcommunity.com/profiles/76561199378980403/myworkshopfiles/?appid=v) for my indie Steam App [AliveDesktop](https://store.steampowered.com/app/2190810/_/) using [AliveDesktopSDK](https://github.com/Threeyes/AliveDesktopSDK).
This project aimed for demonstrating how to using Plugins or custom Scripts to bring diffenent kinds of models alive. 

The items inside this project are for experimental purposes only, which will get updated frequently, may incompatible with old config data, so they may be imperfect for users. Think of this project as a tutorial, it won't cover every aspect but it will be a good start.


## Example (Scene)
* **[Ocean](https://steamcommunity.com/sharedfiles/filedetails/?id=3125768276)**: Stunning and interactive ocean scenes.

![Ocean_WatchSun](https://github.com/user-attachments/assets/b1e77707-90a3-4759-b2d2-950a08b9fe4f)


## Example (Model)

* **[Toy Car](https://steamcommunity.com/sharedfiles/filedetails/?id=3172246359)**: A drivable vehicle that supports adjusting its parameters through a right-click menu or editing interface.
  
![0 4 0_TankTurn](https://github.com/user-attachments/assets/f53ae571-2e0e-4253-9f6c-94f3de07e6b1)
![Default_DrivingIndoor](https://github.com/user-attachments/assets/8d42e733-7a72-4b87-be76-9bc29c92f533)

* **[Security Camera](https://steamcommunity.com/sharedfiles/filedetails/?id=3216537217)**: Real time monitoring camera, supporting player tracking, supporting manual angle adjustment, monitoring images synchronized to matching screens through RenderTexture.
  
![Security Camera](https://github.com/user-attachments/assets/dac2efaf-55be-4dc2-b2fa-34d6025ee122)

* **[Funky SunEntity](https://steamcommunity.com/sharedfiles/filedetails/?id=3231887356)**: Sun entities of different shapes.
  
![0 6 3_截图_阳光_Trim](https://github.com/user-attachments/assets/bd4df33a-8838-4aa9-ba2d-175519e1fc77)


## Note
+ Always make sure that you have imported the latest simulator resources, see more info on [wiki](https://github.com/Threeyes/AliveDesktopSDK/wiki/Setup-SDK).
+ **Don't** try to reupload any items using this project because them have been uploaded by me and their's id are settled in `WorkshopItemInfo.asset`!
+ If you want to use or modify some items in this project, please create a new item dir in your project using `Item Manager` Window, then copy all assets under `Assets/Items/(DesireItemName)` folder to your project's new item dir except `WorkshopItemInfo.asset`. 
+ I will keep uploading different kinds of models and creating general-purpose scripts out of them, feel free to contact me and tell me what else you wanna see on screen.
