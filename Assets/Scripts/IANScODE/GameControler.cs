using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameControler : MonoBehaviour
{
    private FurnitureData furnitureData;
    [SerializeField] private GameObject[] FurnitureL;//needs to be shop variant
    [SerializeField] private int[] AmountOfFurnitureL;
    // Start is called before the first frame update
    void Start()
    {
        furnitureData.Furniture = FurnitureL;
        furnitureData.AmountOfFurniture =AmountOfFurnitureL;
        
    }
    public void UpdateFurniturData()
    {
        furnitureData.Furniture = FurnitureL;
        furnitureData.AmountOfFurniture = AmountOfFurnitureL;

    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private int FindItem(GameObject Item)
    {
        int answer = 0;
        for (int i = 0; i < FurnitureL.Length; i++)
        {
            if (FurnitureL[i] == Item)
            {
                answer = i;

            }
        }
        return answer;
    }
    public void AddItem(GameObject Item)
    {
        int temp = FindItem(Item);
        AmountOfFurnitureL[temp] ++;
    }
    public void RemoveItem(GameObject Item)
    {
        int temp = FindItem(Item);
        AmountOfFurnitureL[temp] --;
    }
    public bool CheckFurniture(GameObject SearchTerm)
    {
        bool answer = false;
        if (0 < AmountOfFurnitureL[FindItem(SearchTerm)])
        {
            answer = true;
        }
        return answer;
    }
}
