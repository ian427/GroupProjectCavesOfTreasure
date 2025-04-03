using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using UnityEditor.Search;
using UnityEditor.Tilemaps;
using UnityEngine;

public class FurnitureData : ScriptableObject
{
    public List<GameObject>  Furniture;//needs to be shop variant
    public int[] AmountOfFurniture;
    public int TotalItiems;
    public int Money;

    
    // Start is called before the first frame update
    void Start()
    {
        //Populate Arrays

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static  FurnitureData LoadPrefrences()
    {
        string s = "C:\\Users\\Games\\GroupProjectCavesOfTreasure\\Assets\\Scripts\\SaveGame.txt";
         return  JsonUtility.FromJson<FurnitureData>(s);
    }
    public void SavePrefrences()
    {
        //saves data to player prefs
        string s = JsonUtility.ToJson(this);
        File.WriteAllText("C:\\Users\\Games\\GroupProjectCavesOfTreasure\\Assets\\Scripts\\SaveGame.txt", s);

    }

}

