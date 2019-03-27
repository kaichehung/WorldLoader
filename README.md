# WorldLoader Unity Plugin
WorldLoader is an machine learning driven Unity plugin which can reconstruct 3D environment in Unity based on a environment picture as input. The goal of this project and tool is to prototype a semantic camera which can be integrated into 3D content creation workflow and accelerate the production process. 

![doc image](https://github.com/kaichehung/WorldLoader/blob/master/Doc/doc.jpg "doc image")

WorldLoader combines two different machine models which in charge of different functionality.
* "Detectron" in charge for object detection and coodinate of object.
* "3D Bounding Box Estimation Using Deep Learning and Geometry" in charge for orientation of objects.

## Usage
1. Clone this project in your Unity Porject Folder
2. Download Models by run....  
3. In Unity, add and empty GameObject at where you want to generate the environment.
4. Attach the script..... in the Script Folder to the GameObject. 
5. Drag a picture of an environment to the "environment slot".
6. Click "send" Button to send picture to machine learning server.
7. Click "Generate" button to generate environment.
8. Click "Arrange" button to set models of environment in a right orientation.


## Example Project
You can also download whole example unity project to see how evertthing works. 

