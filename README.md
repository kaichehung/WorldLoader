# WorldLoader Unity Plugin
WorldLoader is an machine learning driven Unity plugin which can reconstruct 3D environment in Unity based on a environment picture as input. The goal of this project and tool is to prototype a semantic camera which can be integrated into 3D content creation workflow and accelerate the production process. 

![doc image](https://github.com/kaichehung/WorldLoader/blob/master/Doc/demoGIF.gif=250x "doc image")

WorldLoader combines two different machine models which in charge of different functionality.
* "Detectron" in charge for object detection and coodinate of object.
* "3D Bounding Box Estimation Using Deep Learning and Geometry" in charge for orientation of objects.

## Usage
1. `git clone`  this project in your Unity Asset Folder
2. In Unity, add and empty GameObject at where you want to generate the environment.
![step 2 image](https://github.com/kaichehung/WorldLoader/blob/master/Doc/2.png=250x "doc image")
3. Attach the script..... in the Script Folder to the GameObject. 
![step 3 image](https://github.com/kaichehung/WorldLoader/blob/master/Doc/3.png=250x "doc image")
4. Drag a picture of an environment to the "environment slot".
![step 4 image](https://github.com/kaichehung/WorldLoader/blob/master/Doc/6.png=250x "doc image")
5. Click "Load Scene" Button to send picture to server ane generate environment.
![step 5 image](https://github.com/kaichehung/WorldLoader/blob/master/Doc/8.png=250x "doc image")
6. Environmnet is generated, and ready for manipulate! 
![step 6 image](https://github.com/kaichehung/WorldLoader/blob/master/Doc/9.png=250x "doc image")

## Example Project
[Detectron]()
[]()

