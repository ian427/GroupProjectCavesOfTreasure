using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;


public class ItemManager : MonoBehaviour
{
    public TextMeshProUGUI GoldNumber;
    public TextMeshProUGUI DiamondsNumber;
    public TextMeshProUGUI MysticGemsNumber;
    public FurnitureData data;
    public int goldAmount;
    public int diamondsAmount;
    public int mysticGemsAmount;
   float timer = 0;
    int days = 6;
    int random;
    public List<GameObject> Furniture;//needs to be shop variant
    public int[] AmountOfFurniture;
    public int TotalItiems;
    public GameObject []ButtonsT1;
    public GameObject []ButtonsT2;
    public GameObject ButtonT3;
        
    /*
    void Start()
    {
        while (true)
        {


            data = (FurnitureData)Resources.Load("GameData");
            goldAmount = data.Money[0];
            diamondsAmount = data.Money[1];
            mysticGemsAmount = data.Money[2];
           
            Furniture = data.Furniture;
            AmountOfFurniture = data.AmountOfFurniture;
            TotalItiems = data.TotalShopItiems;
        }
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

            }
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
    public void AddItem(GameObject Item)
    {
        int temp = FindItem(Item);
        AmountOfFurniture[temp]++;
    }
    */
}