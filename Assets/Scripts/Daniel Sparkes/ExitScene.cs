using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitScene : MonoBehaviour
{
    ItemManager manager;
    FurnitureData data;
    public string scene;

    public void Exit()
    {
        data = (FurnitureData)Resources.Load("GameData");
        manager = gameObject.GetComponent<ItemManager>();
        data.Money[0] = manager.goldAmount;
        data.Money[1] = manager.diamondsAmount;
        data.Money[2] = manager.mysticGemsAmount;
        for (int i = 0; i < data.TotalItiems; i++)
        {
            data.AmountOfFurniture[i] += manager.boughtList[i];
        }
        SceneManager.LoadScene(scene);
    }
}