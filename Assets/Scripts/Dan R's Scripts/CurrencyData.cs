using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CurrencyData : MonoBehaviour
{
    [SerializeField] private FurnitureData furnitureData;

    private int goldTotal;
    private int diamondsTotal;
    private int gemsTotal;

    public TMP_Text goldText;
    public TMP_Text diamondsText;
    public TMP_Text gemsText;
    
    void Start()
    {
        furnitureData = (FurnitureData)Resources.Load("GameData");//include anywhere you use furniture date
        furnitureData.LoadGameData();

        goldTotal = furnitureData.Gold;
        goldText.text = "Gold: " + goldTotal;

        diamondsTotal = furnitureData.Diamond;
        diamondsText.text = "Diamonds: " + diamondsTotal;

        gemsTotal = furnitureData.Gem;
        gemsText.text = "Gems: " + gemsTotal;

    }
}
