using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class ItemManager : MonoBehaviour
{
    public TextMeshProUGUI GoldNumber;
    public TextMeshProUGUI DiamondsNumber;
    public TextMeshProUGUI MysticGemsNumber;
    public int goldAmount;
    public int diamondsAmount;
    public int mysticGemsAmount;
    string[] itemNameIndex = { "Tier1Item1", "Tier1Item2", "Tier1Item3", "Tier1Item4", "Tier1Item5", "Tier1Item6", "Tier1Item7", "Tier1Item8", "Tier1Item9", "Tier1Item10", "Tier2Item1", "Tier2Item2", "Tier2Item3", "Tier2Item4", "Tier2Item5", "Tier2Item6", "Tier2Item7", "Tier2Item8", "Tier2Item9", "Tier2Item10", "Tier3Item1", "Tier3Item2", "Tier3Item3", "Tier3Item4", "Tier3Item5", "Tier3Item6", "Tier3Item7" };
    string[][] itemImageIndex = { new[] { "Tier1Item1.1", "Tier1Item1.2", "Tier1Item1.3", "Tier1Item1.4" }, new[] { "Tier1Item2.1", "Tier1Item2.2", "Tier1Item2.3", "Tier1Item2.4" }, new[] { "Tier1Item3.1", "Tier1Item3.2", "Tier1Item3.3", "Tier1Item3.4" }, new[] { "Tier1Item4.1", "Tier1Item4.2", "Tier1Item4.3", "Tier1Item4.4" }, new[] { "Tier1Item5.1", "Tier1Item5.2", "Tier1Item5.3", "Tier1Item5.4" }, new[] { "Tier1Item6.1", "Tier1Item6.2", "Tier1Item6.3", "Tier1Item6.4" }, new[] { "Tier1Item7.1", "Tier1Item7.2", "Tier1Item7.3", "Tier1Item7.4" }, new[] { "Tier1Item8.1", "Tier1Item8.2", "Tier1Item8.3", "Tier1Item8.4" }, new[] { "Tier1Item9.1", "Tier1Item9.2", "Tier1Item9.3", "Tier1Item9.4" }, new[] { "Tier1Item10.1", "Tier1Item10.2", "Tier1Item10.3", "Tier1Item10.4" }, new[] { "Tier2Item1.1", "Tier2Item1.2" }, new[] { "Tier2Item2.1", "Tier2Item2.2" }, new[] { "Tier2Item3.1", "Tier2Item3.2" }, new[] { "Tier2Item4.1", "Tier2Item4.2" }, new[] { "Tier2Item5.1", "Tier2Item5.2" }, new[] { "Tier2Item6.1", "Tier2Item6.2" }, new[] { "Tier2Item7.1", "Tier2Item7.2" }, new[] { "Tier2Item8.1", "Tier2Item8.2" }, new[] { "Tier2Item9.1", "Tier2Item9.2" }, new[] { "Tier2Item10.1", "Tier2Item10.2" }, new[] { "Tier3Item1" }, new[] { "Tier3Item2" }, new[] { "Tier3Item3" }, new[] { "Tier3Item4" }, new[] { "Tier3Item5" }, new[] { "Tier3Item6" }, new[] { "Tier3Item7" } };
    public string[] itemName = { "NULL", "NULL", "NULL", "NULL", "NULL", "NULL" };
    public string[] itemImage = { "NULL", "NULL", "NULL", "NULL", "NULL", "NULL" };
    public int[][] itemID = { new[] { 0, 0 }, new[] { 0, 0 }, new[] { 0, 0 }, new[] { 0, 0 }, new[] { 0, 0 }, new[] { 0, 0 }, new[] { 0, 0 } };
    public int[][] boughtList = { new[] { 0, 0, 0, 0 }, new[] { 0, 0, 0, 0 }, new[] { 0, 0, 0, 0 }, new[] { 0, 0, 0, 0 }, new[] { 0, 0, 0, 0 }, new[] { 0, 0, 0, 0 }, new[] { 0, 0, 0, 0 }, new[] { 0, 0, 0, 0 }, new[] { 0, 0, 0, 0 }, new[] { 0, 0, 0, 0 }, new[] { 0, 0 }, new[] { 0, 0 }, new[] { 0, 0 }, new[] { 0, 0 }, new[] { 0, 0 }, new[] { 0, 0 }, new[] { 0, 0 }, new[] { 0, 0 }, new[] { 0, 0 }, new[] { 0, 0 }, new[] { 0 }, new[] { 0 }, new[] { 0 }, new[] { 0 }, new[] { 0 }, new[] { 0 }, new[] { 0 } };
    float timer = 0;
    int days = 6;
    int[] random = { 0, 0 };

    void Start()
    {
        //
        //
        //
        while (true)
        {
            timer += Time.deltaTime;
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
            }
        }
    }
}
