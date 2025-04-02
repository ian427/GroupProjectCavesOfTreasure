using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    public Text GoldNumber;
    public Text DiamondsNumber;
    public Text MysticGemsNumber;
    int goldAmount;
    int diamondsAmount;
    int mysticGemsAmount;
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
        }
    }
}
