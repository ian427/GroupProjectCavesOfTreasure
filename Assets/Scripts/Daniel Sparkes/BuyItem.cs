using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using TMPro;

public class BuyItem : MonoBehaviour
{
    ItemManager manager;
   
    public int buttonIndex;
    public TextMeshProUGUI Label;
    public GameObject Sprite;
    int goldPrice = 0;
    int diamondsPrice = 0;
    int mysticGemsPrice = 0;
    int itemID;
    public GameObject CurrentlyDisplayedItem;

    void Start()
    {
<<<<<<< Updated upstream
        //while (GameObject.Find("Canvas").GetComponent<ItemManager>().itemName[buttonIndex] == "NULL" || GameObject.Find("Canvas").GetComponent<ItemManager>().itemImage[buttonIndex] == "NULL")
        //{
            Label.SetText(GameObject.Find("Canvas").GetComponent<ItemManager>().itemName[buttonIndex]);
            //Sprite = GameObject.Find("Canvas").GetComponent<ItemManager>().itemImage[buttonIndex];
            itemID = GameObject.Find("Canvas").GetComponent<ItemManager>().itemID[buttonIndex];
        //}
=======
        manager = GameObject.Find("Canvas").GetComponent<ItemManager>();
       
        for (int i = 0; i < manager.TotalItiems; i++)
        {
            if (manager.itemList[buttonIndex] == manager.Furniture[i])
            {
                itemID = i;
            }
        }
>>>>>>> Stashed changes
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
        if (manager.goldAmount >= goldPrice && manager.diamondsAmount >= diamondsPrice && manager.mysticGemsAmount >= mysticGemsPrice)
        {
            manager.goldAmount -= goldPrice;
            manager.diamondsAmount -= diamondsPrice;
            manager.mysticGemsAmount -= mysticGemsPrice;
            itemID = manager.FindItem(CurrentlyDisplayedItem);
            manager.AmountOfFurniture[itemID]++;
        }
    }
}
