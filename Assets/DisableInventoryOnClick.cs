using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableInventoryOnClick : MonoBehaviour
{
    public PopUpMenu menu;

    private void OnMouseOver()
    {
        Debug.Log("Closed");
        if (Input.GetMouseButtonDown(0))
        {
            
            menu.CloseInventory();
        }
    }
}
