using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;



public class ModelInfo
{

    public string modelName;
    public Vector3 modelPosition;
    public Vector3 modelAngle;

    public ModelInfo(string name, Vector3 position, Vector3 angle)
    {
        modelName = name;
        modelPosition = position;
        modelAngle = angle;
    }


}
    
