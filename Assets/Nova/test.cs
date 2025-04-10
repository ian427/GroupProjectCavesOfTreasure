using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class test : MonoBehaviour
{
    private FurnitureData furnitureData;

    public TMP_Text moneyText;

    public int Money;
    // Start is called before the first frame update
    void Start()
    {

        //furnitureData = FurnitureData.LoadPrefrences();

        
        Money = furnitureData.Money;//SETS furnitur date money as money
    }

    // Update is called once per frame
    void Update()
    {
        moneyText.text = Money + "";
        
    }
}
