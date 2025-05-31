using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableInventoryOnClick : MonoBehaviour
{
    public PopUpMenu menu;

    //When the mouse is over the object, pressing it down will disable the inventory 
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            menu.CloseInventory();
        }
    }
}
