using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public int level = 1;
    public int points = 0;
    public int goldMax = 800;
    public int diamondMax = 800;
    public int gemMax = 3;
    private FurnitureData data;

    private void Start()
    {
        data = (FurnitureData)Resources.Load("GameData");
        level = data.level;
        points = data.points;   
    }
    public void AddPoints()
    {
        if (level < 10)
        {
            points += 10;
            if (points >= (level * 200))
            {
                points -= (level * 200);
                points -= level * 200;
                level += 1;
            }
            goldMax = 600 + (level * 200);
            diamondMax = 600 + (level * 200);
            gemMax = 1 + (level * 2);
            //data.level = level;
        }
    }
    public void PushData()
    {
        data.level = level;
        data.points = points;
    }
}