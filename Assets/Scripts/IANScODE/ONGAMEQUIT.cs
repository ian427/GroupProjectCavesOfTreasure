using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ONGAMEQUIT : MonoBehaviour
{
    FurnitureData data;
    // Start is called before the first frame update
    void OnApplicationQuit()
    {
        data = (FurnitureData)Resources.Load("GameData");
        data.SaveGameData();

    }
}
