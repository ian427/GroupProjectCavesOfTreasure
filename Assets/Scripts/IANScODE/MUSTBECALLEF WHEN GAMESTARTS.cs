using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MUSTBECALLEFWHENGAMESTARTS : MonoBehaviour
{
    FurnitureData data;
    // Start is called before the first frame update
    void Start()
    {
        data = (FurnitureData)Resources.Load("GameData");
        data.LoadGameData();

    }

}
