# ModuleDepthMask v1.1.0

This plugin allows for parts to have hollow insets that dont clip into other parts, ideal for engine nozzles, landing gear, air intakes, solar panel bays, and more. It is a standalone version of the depth mask module included in the [Restock](github.com/PorktoberRevolution/ReStocked) dll, which will be included in the next major Restock update along with the additon of depth masks to several stock parts

### Usage
1. Add a depth mask mesh to your part model. It should cover up the hollow area you want to prevent clipping in, without sticking out. You can have multiple mask objects sharing the same name and they will all be used.
2. Mark the depth mask object with the `Icon_Hidden` tag to prevent it from showing in the VAB part picker.
3. Add a new `ModuleDepthMask` to your part config.
4. Add the name of your mask object in the `maskTransform` property.
5. (Optional) Add the name of the object you want to restrict the mask effect to in the `bodyTransform` property.

##### Creating the depth mask model
The depth mask will prevent any other parts from rendering behind it. Because of that, it should not be used on any kind of bay where other parts will be placed, or on any part you can look completely through. It also should "bubble" out above the hole you want to cover, otherwise it would be possible to see through it from the side. Also double check your normal direction, since the depth shader only works one way.

##### An example config:
```
  MODULE
  {
    name = ModuleDepthMask
    maskTransform = mask
    bodyTransform = interior //Optional
  }
```

### Screenshots
Mask meshes and configs for stock parts are included in [ReStock](https://github.com/PorktoberRevolution/ReStocked)

<a href="Screenshots/depthmask-jets.png"><img src="https://github.com/drewcassidy/KSP-DepthMask/raw/master/Screenshots/depthmask-jets.png"  height="300" ></a>
<a href="Screenshots/depthmask-intake.png"><img src="https://github.com/drewcassidy/KSP-DepthMask/raw/master/Screenshots/depthmask-intake.png"  height="300" ></a>

<a href="Screenshots/depthmask-panels.png"><img src="https://github.com/drewcassidy/KSP-DepthMask/raw/master/Screenshots/depthmask-panels.png"  height="200" ></a>
<a href="Screenshots/depthmask-box.png"><img src="https://github.com/drewcassidy/KSP-DepthMask/raw/master/Screenshots/depthmask-box.png"  height="200" ></a>

### Licensing
This plugin is licensed Creative Commons Sharealike Attribution. This means that you can redistribute it and its source code however you like under the same license as long as you include attribution and indicate the changes you made, if any. 

### Redistribution
You are free to redistribute this plugin in your mods, or embed the code in your own plugins (with a different module name for compatability of course.) To prevent duplicates of the plugin, please add the dll to the root gamedata directory. In general, treat this mod the same as [Modulemanager](github.com/sarbian/ModuleManager) for redistribution
