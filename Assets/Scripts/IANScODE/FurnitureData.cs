using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using Unity.Mathematics;
using UnityEditor.Search;
using UnityEditor.Tilemaps;
using UnityEngine;
[CreateAssetMenu(fileName ="GameData",menuName ="newfurniture")]
public class FurnitureData : ScriptableObject
{
    public List<GameObject>  Furniture;//needs to be shop variant
    public int[] AmountOfFurniture;
    public int TotalItiems;
    public int Money;
    public string Path;
    
    // Start is called before the first frame update
    void Start()
    {
        //Populate Arrays
        
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadGameData()
    {
        
        string s = (Path +"\\Scripts\\SaveGame.txt");
        string data = File.ReadAllText(s);
        JsonUtility.FromJsonOverwrite(data, this);
    }
    public void SaveGameData()
    {
        Debug.Log(Path);
        var fd = (FurnitureData)Resources.Load("GameData");
        //saves data to player prefs
        string s = JsonUtility.ToJson(this);
        File.WriteAllText((Path +"\\Scripts\\SaveGame.txt"), s);
    }

}

