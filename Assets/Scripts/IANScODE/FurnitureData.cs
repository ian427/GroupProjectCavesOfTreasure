using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEditor.Search;
using UnityEditor.Tilemaps;
using UnityEngine;

public class FurnitureData : ScriptableObject
{
    public GameObject []  Furniture;//needs to be shop variant
    public int[] AmountOfFurniture;
  
   

    
    // Start is called before the first frame update
    void Start()
    {
        //Populate Arrays

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadPrefrences()
    {
        //load data from layer prefs

    }
    
   
}

