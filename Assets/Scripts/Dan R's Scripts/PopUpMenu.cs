using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpMenu : MonoBehaviour
{
    public GameObject inventory;
    public static bool isInventoryOpen;

    //Sets the inventory to be inactive on the start of the scene
    void Start()
    {
        inventory.SetActive(false);
    }

    //When the space bar is pressed, the inventory will open and close if pressed again
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(isInventoryOpen)
            {
                CloseInventory();
            }

            else
            {
                OpenInventory();
            }
        }
    }

    //Activates the inventory and sets the bool of isInventoryOpen to true
    public void OpenInventory()
    {
        inventory.SetActive(true);
        isInventoryOpen = true;
    }

    //Deactivates the inventory and sets the bool of isInventoryOpen to false
    public void CloseInventory()
    {
        inventory.SetActive(false);
        isInventoryOpen = false;
    }
}
