using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DailyReward : MonoBehaviour
{
    public GameObject Displaywindow;
    public Sprite Gold;
    public Sprite Diamond;
    public List<Sprite> Furniture;//needs to be shop variant
    public int[] AmountOfFurniture;//furnitur index
    public FurnitureData data;
    public int AmmountToAwarded = 0;
    public bool canGetReward = false;
    public int upperboundfortier2items =30;
    public TMP_Text timer;
    private string datenextreward;

    // Start is called before the first frame update
    void Start()
    {
        data = (FurnitureData)Resources.Load("GameData");
        if(data.LastRewardDate + TimeSpan.FromDays(1) <= TimeSpan.FromTicks(System.DateTime.UtcNow.Ticks))
        {
            canGetReward = true;
        }
        Furniture =data.Furniture;
        AmountOfFurniture = data.AmountOfFurniture;
       
        datenextreward =  data.LastRewardDate.DateTime + TimeSpan.FromDays(1).ToString();
        //Debug.Log(date);
        timer.text = datenextreward;
    }
    // Update is called once per frame
    void GetReward()
    {
        if (canGetReward)
        {
            
            //reset
            data.LastRewardDate = TimeSpan.FromTicks(System.DateTime.UtcNow.Ticks);
            
            //genreward
            int temp = UnityEngine.Random.Range(0, 100);
            if (temp >= 97)//7%
            {
                //furniture
                int newtemp = UnityEngine.Random.Range(0, upperboundfortier2items);
                Displaywindow.GetComponent<SpriteRenderer>().sprite = Furniture[newtemp];
                AmountOfFurniture[newtemp]++;
                AmmountToAwarded = 1;
                canGetReward=false;

            }
            else if (temp >= 67)//33%
            {
                //diamond
                AmmountToAwarded = UnityEngine.Random.Range(10, 20);
                Displaywindow.GetComponent<SpriteRenderer>().sprite = Diamond;
                data.Diamond = data.Diamond + AmmountToAwarded;
                canGetReward = false;   


            }
            else //60%
            {
                //gold
                AmmountToAwarded = UnityEngine.Random.Range(20, 30);
                Displaywindow.GetComponent<SpriteRenderer>().sprite = Diamond;
                data.Gold = data.Gold + AmmountToAwarded;
                canGetReward = false;
            }
            timer.text = datenextreward;

        }
 
    }
    public void ClaimReward()
    {

    }
}

