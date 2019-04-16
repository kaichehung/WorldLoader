using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor.Experimental.Build.AssetBundle;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Networking.NetworkSystem;
//using WebSocketSharp;

[ExecuteInEditMode]
public class WorldLoaderScript : MonoBehaviour
{
    //public WebSocket ws;

    public Texture2D image;
    private GameObject imagePlane;
    string previmage = null;
    bool instanciated = false;
    void OnValidate()
    {
        if (image != null && instanciated == false)
        {
            createRefMesh(image, 0, 0, 500, 90, 180, 0);
            previmage = image.name;
            instanciated = true;
        }

        if (image != null && image.name != previmage && imagePlane)
        {
            applyRefImage(image);
            previmage = image.name;
        }

        if (image == null && instanciated == true)
        {
            instanciated = false;
        }
    }


    //main func triggered by user
    public void LoadScene()
    {

        //connection handler connect and sent image
        //ws = ConnectServer("ws://192.168.0.4:7000");        

        //connectionHandler.connect(IP);
        //connectionHandler.sendImage(Image);
        //connectionHandler.on(receive, parseData())

        //instanciate models
        //InstanciateModel()


        
        //QD Show: Demo
        //instanciate models
        InstanticateModel(image);
        

        //QD show: create Demo scene
        //ModelList mList = new ModelList();
        //mList.copyModelFromScene(image.name);
    }


    public void InstanticateModel(Texture2D image)
    {        
        ModelList mList = new ModelList();
        mList.addListsToImgDict();
        mList.addModel();

        List<ModelInfo> detectedImg = mList.ModelLists[image.name];    
        foreach (var model in detectedImg)
        {
            GameObject prefab = Resources.Load(model.modelName.ToUpper()+"/"+model.modelName) as GameObject;           
            Instantiate(prefab, model.modelPosition, Quaternion.Euler(model.modelAngle));
        }

        Texture2D processedImg = Resources.Load("ProcessedImg/" + image.name + "_processed") as Texture2D;
        applyRefImage(processedImg);
    }


    public void createRefMesh(Texture2D image, int posX, int posY, int posZ, int sclX, int sclY, int sclZ)
    {
        imagePlane = GameObject.CreatePrimitive(PrimitiveType.Plane);
        imagePlane.transform.position = new Vector3(posX, posY, posZ);
        imagePlane.transform.rotation = Quaternion.Euler(new Vector3(sclX, sclY, sclZ));
        imagePlane.transform.localScale = new Vector3(125, 1, 85);
         
        applyRefImage(image);
    }

    public void applyRefImage(Texture2D image)
    {
        Material planeMaterial = new Material(Shader.Find("Diffuse"));
        planeMaterial.mainTexture = image;
        imagePlane.GetComponent<Renderer>().material = planeMaterial;
    }


    //public Websocket ConnectServer(string ip)
    //{
    //    WebSocket ws = new WebSocket("ws://192.168.0.4:7000");
    //    ws.OnOpen += (sender, e) => { Debug.Log("connect"); };
    //    ws.Connect();
    //    return ws;
    //}

}


