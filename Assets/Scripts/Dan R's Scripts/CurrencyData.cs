using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CurrencyData : MonoBehaviour
{
    private int goldTotal;
    private int diamondsTotal;
    private int gemsTotal;

    public TMP_Text goldText;
    public TMP_Text diamondsText;
    public TMP_Text gemsText;
    
    void Start()
    {
        goldTotal = PlayerPrefs.GetInt("GoldAmount");
        goldText.text = "Gold: " + goldTotal;

        diamondsTotal = PlayerPrefs.GetInt("DiamondsAmount");
        diamondsText.text = "Diamonds: " + diamondsTotal;

        gemsTotal = PlayerPrefs.GetInt("GemsAmount");
        gemsText.text = "Gems: " + gemsTotal;

    }
}
