using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using Unity.Mathematics;
//using UnityEditor.Search;
//using UnityEditor.Tilemaps;
using UnityEngine;
[CreateAssetMenu(fileName ="GameData",menuName ="newfurniture")]
public class FurnitureData : ScriptableObject
{
    public List<Sprite> Furniture;//needs to be shop variant
    public int[] AmountOfFurniture;//furnitur index
    public float TotalItiems = 1;

    public int Gold = 0;
    public int Diamond = 0;
    public int Gem = 0;
    public TimeSpan LastDate;
    public string Path;
    public List<Sprite> CurrentlyDisplayedT1;
    public List<Sprite> CurrentlyDisplayedT2;
    public Sprite currentlydisplayedT3;
    public TimeSpan LastHuntTime;
    public long LastRewardDate;
    public int CurrentNumberOfHunts;
    public List<GameObject> CurrentlyPlacedFurniture;

    // Start is called before the first frame update

    // Update is called once per frame
    public void filecheck()
    {
            string s;
            // add execute only in play mode vs build mode
            Path = Application.persistentDataPath;
            s = Path + "\\SaveGame.txt";
        if(!File.Exists (s))
        {
            using (StreamWriter sw = File.CreateText(s))
            {
                Debug.Log("created");
            }
        }
    }

    public void LoadGameData()
    {
        string s;
        // add execute only in play mode vs build mode
       Path = Application.persistentDataPath;
        s = Path + "\\SaveGame.txt";
        //IF EDITOR 
       //Path = Application.dataPath;
       //s = (Path +"\\Scripts\\SaveGame.txt");
       
        // check if file doesn't exist, if it doesn't create a save file and save default files to it
        Debug.Log(Path);
       
        string data = File.ReadAllText(s);
        JsonUtility.FromJsonOverwrite(data, this);
    }
    public void SaveGameData()
    {
        string p;
        // add execute only in play mode vs build mode
        Path = Application.persistentDataPath;
        p = Path + "\\SaveGame.txt";
        //IF EDITOR 
        //Path = Application.dataPath;
        //s = (Path +"\\Scripts\\SaveGame.txt");
        Debug.Log(Path);
       // Path = Application.dataPath;
        var fd = (FurnitureData)Resources.Load("GameData");
        //saves data to player prefs
        string s = JsonUtility.ToJson(this);
        //File.WriteAllText((Path + p), s);
        File.WriteAllText(p, s);
    }

}

