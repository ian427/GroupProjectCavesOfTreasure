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
            data.level = level;
        }
    }
}