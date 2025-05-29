using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public int goldMax = 800;
    public int diamondMax = 800;
    public int gemMax = 3;
    private FurnitureData data;

    private void Start()
    {
        data = (FurnitureData)Resources.Load("GameData");
        Debug.Log(data.points);
    }
    public void AddPoints()
    {
        if (data.level < 10)
        {
            data.points += 10;
            Debug.Log(data.points);
            if (data.points >= (data.level * 200))
            {
                data.points -= data.level * 200;
                data.level += 1;
            }
        }
    }
}