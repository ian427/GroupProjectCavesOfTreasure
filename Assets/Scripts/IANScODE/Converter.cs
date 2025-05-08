using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class Converter : MonoBehaviour
{
    private ItemManager manager;
    [SerializeField] private int Goldinrecipie;
    [SerializeField] private int Dimondsinrecipie;
    private FurnitureData data;
    int level;

    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("Canvas").GetComponent<ItemManager>();
        //level = data.level;
    }
    public void ConvertToGems ()
    {
        if((manager.goldAmount > Goldinrecipie )&&(manager.diamondsAmount>Dimondsinrecipie)&&((1 + (level * 2) - manager.mysticGemsAmount) >= 1))
        {
                manager.goldAmount = -Goldinrecipie;
                manager.diamondsAmount = -Dimondsinrecipie;
                manager.mysticGemsAmount++;
        }
    }
}