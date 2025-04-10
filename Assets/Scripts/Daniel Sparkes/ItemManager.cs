using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
<<<<<<< Updated upstream
=======
using Unity.VisualScripting;
using UnityEditor;
using System.Linq;
>>>>>>> Stashed changes

public class ItemManager : MonoBehaviour
{
    public TextMeshProUGUI GoldNumber;
    public TextMeshProUGUI DiamondsNumber;
    public TextMeshProUGUI MysticGemsNumber;
    public int goldAmount;
    public int diamondsAmount;
    public int mysticGemsAmount;
    public GameObject[] itemList = new GameObject[10];
    public int[] boughtList;
    float timer = 0;
    int days = 6;
    int random;
    public int TotalItiems;
    [SerializeField] public List<GameObject> Furniture;//needs to be shop variant
    [SerializeField] public int[] AmountOfFurniture;
     public List<GameObject> ButtonsT1;
     public List<GameObject> ButtonsT2;
    public GameObject ButtonT3;
    private FurnitureData data;
    public void UpdateFurniturData()
    {
        data.Furniture = Furniture;
        data.AmountOfFurniture = AmountOfFurniture;

    }
    public int FindItem(GameObject Item)
    {
        int answer = 0;
        for (int i = 0; i < Furniture.Count; i++)
        {
            if (Furniture[i] == Item)
            {
                answer = i;

            }
        }
        return answer;
    }
    public void RemoveItem(GameObject Item)
    {
        int temp = FindItem(Item);
        AmountOfFurniture[temp]--;
    }
    void Start()
    {
<<<<<<< Updated upstream
        while (true)
        {
            /*timer += Time.deltaTime;
            if (timer > 1)
            {
                timer = 0;
                days--;
                for (int i = 0; i < 3; i++)
                {
                    random[0] = Random.Range(0, 10);
                    random[1] = Random.Range(0, 4);
                    itemName[i] = itemNameIndex[random[0]];
                    itemImage[i] = itemImageIndex[random[0]][random[1]];
                    itemID[i][0] = random[0];
                    itemID[i][1] = random[1];
                }
                for (int i = 3; i < 5; i++)
                {
                    random[0] = Random.Range(0, 10);
                    random[1] = Random.Range(0, 2);
                    itemName[i] = itemNameIndex[random[0]];
                    itemImage[i] = itemImageIndex[random[0]][random[1]];
                    itemID[i][0] = random[0];
                    itemID[i][1] = random[1];
                }
                if (days < 0)
                {
                    days = 6;
                    random[0] = Random.Range(0, 10);
                    itemName[5] = itemNameIndex[random[0]];
                    itemImage[5] = itemImageIndex[random[0]][random[1]];
                    itemID[5][0] = random[0];
                    itemID[5][1] = 0;
                }
            }*/
=======
        data = (FurnitureData)Resources.Load("GameData");
        goldAmount = data.Money[0];
        diamondsAmount = data.Money[1];
        mysticGemsAmount = data.Money[2];
        for (int i = 0; i < data.Furniture.Count; i++)
        {
            itemList.Append(data.Furniture[i]);
        }
        Furniture = data.Furniture;
        AmountOfFurniture = data.AmountOfFurniture;
        TotalItiems = data.TotalShopItiems;
    }

    private void Update()
    {
        //Function to update items on sale
        timer += Time.deltaTime;
        if (timer > 1)
        {
            timer = 0;
            days--;
            //Tier 1
            for (int i = 0; i < 3; i++)
            {
                //Generate random number
                random = Random.Range(0, 10);
                ButtonsT1[i].GetComponent<BuyItem>().CurrentlyDisplayedItem = Furniture[random];
            }
            //Tier 2
            for (int i = 0; i < 2; i++)
            {
                random = Random.Range(10, 20);
                ButtonsT2[i].GetComponent<BuyItem>().CurrentlyDisplayedItem = Furniture[random];
            }
            //Tier 3
            if (days < 0)
            {
                days = 6;
                random = Random.Range(20, 27);
                ButtonT3.GetComponent<BuyItem>().CurrentlyDisplayedItem = Furniture[random];
            }
>>>>>>> Stashed changes
        }
    }
}