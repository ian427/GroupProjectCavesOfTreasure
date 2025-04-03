using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using TMPro;

public class BuyItem : MonoBehaviour
{
    public int buttonIndex;
    public TextMeshProUGUI Label;
    public GameObject Sprite;
    int goldPrice = 0;
    int diamondsPrice = 0;
    int mysticGemsPrice = 0;
    int[] itemID;

    void Start()
    {
        while (GameObject.Find("Canvas").GetComponent<ItemManager>().itemName[buttonIndex] == "NULL" || GameObject.Find("Canvas").GetComponent<ItemManager>().itemImage[buttonIndex] == "NULL")
        {
            Label.SetText(GameObject.Find("Canvas").GetComponent<ItemManager>().itemName[buttonIndex]);
            //Sprite = GameObject.Find("Canvas").GetComponent<ItemManager>().itemImage[buttonIndex];
            itemID = GameObject.Find("Canvas").GetComponent<ItemManager>().itemID[buttonIndex];
        }
        if (buttonIndex < 3)
        {
            goldPrice = 200;
            diamondsPrice = 150;
        }
        else if (buttonIndex < 5)
        {
            goldPrice = 600;
            diamondsPrice = 450;
        }
        else
        {
            mysticGemsPrice = 2;
            diamondsPrice = 600;
        }
    }

    public void Buy()
    {
        if (GameObject.Find("Canvas").GetComponent<ItemManager>().goldAmount >= goldPrice && GameObject.Find("Canvas").GetComponent<ItemManager>().diamondsAmount >= diamondsPrice && GameObject.Find("Canvas").GetComponent<ItemManager>().mysticGemsAmount >= mysticGemsPrice)
        {
            GameObject.Find("Canvas").GetComponent<ItemManager>().goldAmount -= goldPrice;
            GameObject.Find("Canvas").GetComponent<ItemManager>().diamondsAmount -= diamondsPrice;
            GameObject.Find("Canvas").GetComponent<ItemManager>().diamondsAmount -= mysticGemsPrice;
            GameObject.Find("Canvas").GetComponent<ItemManager>().boughtList[itemID[0]][itemID[1]] += 1;
        }
    }
}
