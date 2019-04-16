using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
public class ModelList
{
    public Dictionary<string, List<ModelInfo>> ModelLists = new Dictionary<string, List<ModelInfo>>();
    public GameObject[] tmpGameObjects;

    public void addListsToImgDict()
    {
        ModelLists.Add("img01", new List<ModelInfo>());
        ModelLists.Add("img02", new List<ModelInfo>());
        ModelLists.Add("img03", new List<ModelInfo>());
        ModelLists.Add("img04", new List<ModelInfo>());
    }

    public void addModelToList(string img, string modelName, int PosX, int PosY, int PosZ, int RotX, int RotY, int RotZ )
    {
        ModelLists[img].Add(new ModelInfo(modelName, new Vector3(PosX, PosY, PosZ), new Vector3(RotX, RotY, RotZ)));
    }

    public void addModel()
    {
        //img01
        addModelToList("img01", "clock",417,0-39,210,-185,-20,-2);
        addModelToList("img01", "truck",291,-224,344,-109,9,50);
        addModelToList("img01", "bus",-204,-186,-349,-109,-2,-111);
        addModelToList("img01", "bus",-365,-63,-7,-109,-2,-111);
        addModelToList("img01", "bus",-402,73,407,-118,-5,-178);
        addModelToList("img01", "car",34,-222,-462,-101,4,146);
        addModelToList("img01", "car",-143,-25,240,-115,-3,154);
        addModelToList("img01", "car",-223,26,421,-115,-3,154);
        addModelToList("img01", "car",-323,97,484,-121,3,205);
        addModelToList("img01", "motorcycle",-138,-133,-298,-108,-40,270);
        addModelToList("img01", "motorcycle",21,-119,-156,-109,21,55);
        addModelToList("img01", "human",-268,-137,-105,-83,137,-208);
        addModelToList("img01", "human", -316,-148,-21,-87,57,-128 );
        addModelToList("img01", "human", -394,-116,260,-87,64,-128);
        addModelToList("img01", "human", -428,-95,328,-87,57,-128);
        addModelToList("img01", "human", -518,-11,511,-87,57,-128);
        addModelToList("img01", "human", 297,-137,-94,-71,189,-421);
        addModelToList("img01", "human", 285,-144,-67,-71,189,-421);
        addModelToList("img01", "human", 113,-81,475,-72,172,-546);
        addModelToList("img01", "human", -128,52,519,-72,178,-630);
        addModelToList("img01", "human", -10,-100,-33,-46,182,-414);

        //img02
        addModelToList("img02", "airplane", 210, -74, -345, 272, 20, 295);
        addModelToList("img02", "boat", -162, -136, 490, 270, 180, 0);
        addModelToList("img02", "boat", 62, -102, 513, 270, 180, 0);
        addModelToList("img02", "boat", -181, -102, 513, 270, 0, 0);

        //img03
        addModelToList("img03", "human", -212, -170, -176, 281, 172, 299);
        addModelToList("img03", "human", 77, -190, -6, 274, 276, 249);
        addModelToList("img03", "human", 26, -175, -246, 277, 91, 321);
        addModelToList("img03", "human", 112, -170, -250, 277, 88, 307);
        addModelToList("img03", "human", 20, -205, -72, 275, 222, 346);
        addModelToList("img03", "human", 152, -180, -227, 281, 85, 321);
        addModelToList("img03", "human", 127, -178, -237, 278, 239, 0);
        addModelToList("img03", "human", 230, -161, -308, 273, 133, 275);
        addModelToList("img03", "human", 159, -130, -466, 276, 78, 334);
        addModelToList("img03", "human", 258, -148, -398, 273, 135, 269);
        addModelToList("img03", "human", -19, -151, -367, 274, 78, 340);
        addModelToList("img03", "human", -101, -144, -388, 274, 122, 270);
        addModelToList("img03", "human", -183, -161, -337, 280, 304, 270);
        addModelToList("img03", "human", -304, -190, -21, 278, 89, 262);
        addModelToList("img03", "human", -347, -186, -100, 274, 207, 270);
        addModelToList("img03", "umbrella", -208, -107, -169, 316, 285, 60);
        addModelToList("img03", "umbrella", -161, -107, -342, 323, 0, 0);
        addModelToList("img03", "umbrella", -107, -87, -393, 327, 294, 61);
        addModelToList("img03", "umbrella", 46, -150, -73, 309, 323, 43);
        addModelToList("img03", "umbrella", -33, -94, -368, 314, 306, 40);
        addModelToList("img03", "umbrella", 25, -119, -246, 314, 338, 40);
        addModelToList("img03", "umbrella", 96, -133, 18, 310, 317, 50);
        addModelToList("img03", "umbrella", 101, -114, -250, 315, 316, 53);
        addModelToList("img03", "umbrella", 146, -124, -267, 317, 59, 51);
        addModelToList("img03", "umbrella", 148, -120, -238, 322, 38, 46);
        addModelToList("img03", "umbrella", 144, -74, -468, 316, 323, 46);
        addModelToList("img03", "umbrella", 213, -98, -310, 316, 311, 58);
        addModelToList("img03", "car", -22, -155, -269, 270, 90, 0);
        addModelToList("img03", "bus", 225, -170, 70, 270, 0, 0);
        addModelToList("img03", "trafficlight", 363, -463, 442, 270, 180, 0);
        addModelToList("img03", "trafficlight", -286, -578, 507, 270, 0, 0);
        addModelToList("img03", "umbrella", 247, -95, -398, 321, 329, 43);

        //img04
        addModelToList("img04", "car", 252, -32, 589, 270, 10, 0);
        addModelToList("img04", "car", 83, -32, 525, 270, 10, 0);
        addModelToList("img04", "car", -26, -46, -116, 270, 10, 0);
        addModelToList("img04", "trafficlight", -298, -170, 452, 270, 180, 0);
        addModelToList("img04", "trafficlight", 933, -130, 524, 270, 0, 0);
        addModelToList("img04", "human", 216, -49, -466, 278, 90, 270);
        addModelToList("img04", "human", -41, -66, -732, 283, 19, 304);
        addModelToList("img04", "train", -104, 1, -44, 270, 112, 259);
        addModelToList("img04", "bicycle", -35, -49, -645, 272, 193, 84);
        addModelToList("img04", "car", 147, -32, 624, 270, 10, 0);



    }


    //for production use
    public void copyModelFromScene(string imageName)
    {        
        tmpGameObjects = GameObject.FindGameObjectsWithTag("tmp");
        List<string> modelCoordinate = new List<string>();
        foreach (var model in tmpGameObjects)
        {
            modelCoordinate.Add("addModelToList(\"" 
                                + imageName + "\",\""
                                + model.name + "\","
                                + (int)model.transform.localPosition.x + ","
                                + (int)model.transform.localPosition.y + ","
                                + (int)model.transform.localPosition.z + ","
                                + (int)model.transform.rotation.eulerAngles.x + ","
                                + (int)model.transform.rotation.eulerAngles.y + ","
                                + (int)model.transform.rotation.eulerAngles.z + ");");
            
        }

        modelCoordinate.ForEach(delegate(String model)
        {
            
            using (System.IO.StreamWriter modelFile = 
                new StreamWriter("E:/Unity/WorldLoader/Assets/Demos/modelCoordinate.txt", true))
            {
                modelFile.WriteLine(model);
            }
        }); 
    }
}

