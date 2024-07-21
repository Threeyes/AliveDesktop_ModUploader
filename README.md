# AliveDesktop_ModUploader

## Introduction
I create this sample project to upload mods to [Steam Workshop](https://steamcommunity.com/profiles/76561199378980403/myworkshopfiles/?appid=v) for my indie Steam App [AliveDesktop](https://store.steampowered.com/app/2190810/_/) using [AliveDesktopSDK](https://github.com/Threeyes/AliveDesktopSDK).
This project aimed for demonstrating how to using Plugins or custom Scripts to bring diffenent kinds of models alive. 

The items inside this project are for experimental purposes only, which will get updated frequently, may incompatible with old config data, so they may be imperfect for users. Think of this project as a tutorial, it won't cover every aspect but it will be a good start.


## Example (Scene)
* **Ocean**: Stunning and interactive ocean scenes.


## Example (Model)

* **Toy Car**: A drivable vehicle that supports adjusting its parameters through a right-click menu or editing interface..

* **Security Camera**: Real time monitoring camera, supporting player tracking, supporting manual angle adjustment, monitoring images synchronized to matching screens through RenderTexture.

* **Funky SunEntity**: Sun entities of different shapes.


## Note
+ Always make sure that you have imported the latest simulator resources, see more info on [wiki](https://github.com/Threeyes/AliveDesktopSDK/wiki/Setup-SDK).
+ **Don't** try to reupload any items using this project because them have been uploaded by me and their's id are settled in `WorkshopItemInfo.asset`!
+ If you want to use or modify some items in this project, please create a new item dir in your project using `Item Manager` Window, then copy all assets under `Assets/Items/(DesireItemName)` folder to your project's new item dir except `WorkshopItemInfo.asset`. 
+ I will keep uploading different kinds of models and creating general-purpose scripts out of them, feel free to contact me and tell me what else you wanna see on screen.
