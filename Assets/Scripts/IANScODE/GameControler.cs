using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameControler : MonoBehaviour
{
    [SerializeField] public FurnitureData furnitureData;
    //[SerializeField] private List<Sprite> FurnitureL;//needs to be shop variant
    //[SerializeField] private int[] AmountOfFurnitureL;
    [SerializeField] public float TotalItems = 1;
    [SerializeField] private float ScaleFactor = 1;
  //  [SerializeField] public List<GameObject> CurrentplacedFurnitureL;
    public int CurrentHuntsDone;
    public TimeSpan lastHuntTime;
    public float size;
    // Start is called before the first frame update
    private void Start()
    {

        furnitureData = (FurnitureData)Resources.Load("GameData");//include anywhere you use furniture date
        string m_Path = Application.dataPath;
        furnitureData.Path = m_Path;
        furnitureData.LoadGameData();
       // Debug.Log(m_Path);
       // furnitureData.LoadGameData();
       // DontDestroyOnLoad(this.gameObject);
        //FurnitureL = furnitureData.Furniture ;
       // AmountOfFurnitureL = furnitureData.AmountOfFurniture;
        TotalItems = furnitureData.TotalItiems;
        lastHuntTime = furnitureData.LastHuntTime;
        CurrentHuntsDone = furnitureData.CurrentNumberOfHunts;
       // CurrentplacedFurnitureL = furnitureData.CurrentlyPlacedFurniture;
       //new game object copy
       
        
            for (int i = 0; i < furnitureData.CurrentlyPlacedFurniture.Count; i++)
        {
            GameObject Temp;
            Temp = GameObject.Instantiate(furnitureData.CurrentlyPlacedFurniture[i]);
            Temp.GetComponent<FurnitureControler>().CanPlace = false;
            Temp.GetComponent<FurnitureControler>().SetPosition();
            
        }
    }
   
    public float GetMonsterScale()
    {
       // Debug.Log("scale");
        float answer = TotalItems / ScaleFactor;
        Debug.Log("anser" + answer);
        return answer;
        
        
    }
    // Update is called once per frame
    void Update()
    {
       // size = GetMonsterScale();
        
    }
    private int FindItem(Sprite Item)
    {
        int answer = 0;
        for (int i = 0; i < furnitureData.Furniture.Count; i++)
        {
            if (furnitureData.Furniture[i] == Item)
            {
                answer = i;

            }
        }
        return answer;
    }
    public void AddItem(Sprite Item)
    {
        int temp = FindItem(Item);
        furnitureData.AmountOfFurniture[temp] ++;

    }
    public void RemoveItem(Sprite Item)
    {
        int temp = FindItem(Item);
        furnitureData.AmountOfFurniture[temp] --;
    }
    public bool CheckFurniture(Sprite SearchTerm)
    {
        bool answer = false;
        if (0 < furnitureData.AmountOfFurniture[FindItem(SearchTerm)])
        {
            answer = true;
        }
        return answer;
    }
    public void PushDataUpdate()
    {
       
        // furnitureData.AmountOfFurniture = AmountOfFurnitureL;
        furnitureData.TotalItiems = TotalItems  ;
         furnitureData.LastHuntTime = lastHuntTime ;
        /*
        furnitureData.CurrentNumberOfHunts = CurrentHuntsDone;
        for (int i = 0; i < furnitureData.CurrentlyPlacedFurniture.Count; i++)
        {

            CurrentplacedFurnitureL[i].GetComponent<FurnitureControler>().SavePosition();
            furnitureData.CurrentlyPlacedFurniture.Add(CurrentplacedFurnitureL[i]);
        }
        furnitureData.CurrentlyPlacedFurniture.Clear();
        foreach (GameObject tempobject in CurrentplacedFurnitureL)
        {
            furnitureData.CurrentlyPlacedFurniture.Add(tempobject);
            
            // CurrentplacedFurnitureL.Add(tempobject);
        }
       */
       furnitureData.SaveGameData();

    }
}
