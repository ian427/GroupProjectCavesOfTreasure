using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private FurnitureData furnitureData;

    void Start()
    {
        furnitureData = (FurnitureData)Resources.Load("GameData");//include anywhere you use furniture date
    }

    void Update()
    {
        
    }
}
