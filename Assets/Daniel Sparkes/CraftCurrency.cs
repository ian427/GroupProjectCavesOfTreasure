using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftCurrency : MonoBehaviour
{
    int goldAmount;
    int diamondsAmount;
    int mysticGemsAmount;

    void Start()
    {
        goldAmount = GameObject.Find("Canvas").GetComponent<ItemManager>().goldAmount;
        diamondsAmount = GameObject.Find("Canvas").GetComponent<ItemManager>().diamonsAmount;
        mysticsGemsAmount = GameObject.Find("Canvas").GetComponent<ItemManager>().mysticGemsAmount;
    }

    void Craft()
    {
        if (GoldAmount >= 1600 && DiamondsNumber >= 850)
        {
            GoldNumber -= 1600;
            DiamondsNumber -= 850;
            MysticGemsNumber += 1;
            GameObject.Find("Canvas").GetComponent<ItemManager>().goldAmount = goldAmount;
            GameObject.Find("Canvas").GetComponent<ItemManager>().diamondsAmount = diamondsAmount;
            GameObject.Find("Canvas").GetComponent<ItemManager>().mysticGemsAmount = mysticGemsAmount;
        }
    }
}
