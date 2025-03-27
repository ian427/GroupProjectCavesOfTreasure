using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    public Text coinNumber;
    public Text diamondNumber;
    public Text mysticGemAmount;
    public Text label1;
    public Text label2;
    public Text label3;
    public Text label4;
    public Text label5;
    public Text label6;
    public GameObject image1;
    public GameObject image2;
    public GameObject image3;
    public GameObject image4;
    public GameObject image5;
    public GameObject image6;
    string[] itemNameIndex = { "Tier1Item1", "Tier1Item2", "Tier1Item3", "Tier1Item4", "Tier1Item5", "Tier1Item6", "Tier1Item7", "Tier1Item8", "Tier1Item9", "Tier1Item10", "Tier2Item1", "Tier2Item2", "Tier2Item3", "Tier2Item4", "Tier2Item5", "Tier2Item6", "Tier2Item7", "Tier2Item8", "Tier2Item9", "Tier2Item10", "Tier3Item1", "Tier3Item2", "Tier3Item3", "Tier3Item4", "Tier3Item5", "Tier3Item6", "Tier3Item7" };
    string[] itemImageIndex = { "Tier1Item1", "Tier1Item2", "Tier1Item3", "Tier1Item4", "Tier1Item5", "Tier1Item6", "Tier1Item7", "Tier1Item8", "Tier1Item9", "Tier1Item10", "Tier2Item1", "Tier2Item2", "Tier2Item3", "Tier2Item4", "Tier2Item5", "Tier2Item6", "Tier2Item7", "Tier2Item8", "Tier2Item9", "Tier2Item10", "Tier3Item1", "Tier3Item2", "Tier3Item3", "Tier3Item4", "Tier3Item5", "Tier3Item6", "Tier3Item7" };
    int[] currency = { 0, 0, 0 };
    string[] itemName = { "Tier1Item1", "Tier1Item2", "Tier1Item3", "Tier2Item1", "Tier2Item2", "Tier3Item" };
    string[] itemImage = { "Tier1Item1", "Tier1Item2", "Tier1Item3", "Tier2Item1", "Tier2Item2", "Tier3Item" };
    float timer = 0;
    int days = 6;
    int random;

    void Start()
    {
        while (true)
        {
            timer += Time.deltaTime;
            if (timer > 1)
            {
                timer = 0;
                days--;
                for (int i = 0; i < 3; i++)
                {
                    random = Random.Range(0, 10);
                    itemName[i] = itemNameIndex[random];
                    itemImage[i] = itemImageIndex[random];
                }
                for (int i = 3; i < 5; i++)
                {
                    random = Random.Range(10, 20);
                    itemName[i] = itemNameIndex[random];
                    itemImage[i] = itemImageIndex[random];
                }
                if (days < 0)
                {
                    days = 6;
                    random = Random.Range(20, 27);
                    itemName[5] = itemNameIndex[random];
                    itemImage[5] = itemImageIndex[random];
                }
            }
            label1 = itemName[0];
            label2 = itemName[1];
            label3 = itemName[2];
            label4 = itemName[3];
            label5 = itemName[4];
            label6 = itemName[5];
            //image1 sprite = itemImage[0]
            //image2 sprite = itemImage[1]
            //image3 sprite = itemImage[2]
            //image4 sprite = itemImage[3]
            //image5 sprite = itemImage[4]
            //image6 sprite = itemImage[5]
        }
    }

    public void Buy()
    {

    }
}
