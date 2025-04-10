using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using UnityEditor.Search;
using UnityEditor.Tilemaps;
using UnityEngine;
[CreateAssetMenu(fileName ="GameData",menuName ="newfurniture")]
public class FurnitureData : ScriptableObject
{
    public List<GameObject> Furniture;//needs to be shop variant
    public int[] AmountOfFurniture;
    public int TotalItiems = 1;
    public int TotalShopItiems = 30;
    public int[] Money = { 800, 800, 3 };
    public string Path;
    
    // Start is called before the first frame update
  
    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadGameData()
    {
        var fd = (FurnitureData)Resources.Load("GameData");
        string s = (fd.Path +"\\Scripts\\SaveGame.txt");
        string data = File.ReadAllText(s);
        JsonUtility.FromJsonOverwrite(data, this);
    }
    public void SaveGameData()
    {
        var fd = (FurnitureData)Resources.Load("GameData");
        //saves data to player prefs
        string s = JsonUtility.ToJson(this);
        File.WriteAllText((fd.Path +"\\Scripts\\SaveGame.txt"), s);
    }

}

