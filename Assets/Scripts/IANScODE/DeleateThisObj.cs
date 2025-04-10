using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleateThisObj : MonoBehaviour
{
    Canvas PopUpMenu;
    public GameObject ToDestroy;
    private FurnitureControler furniturecontroler;

    // Start is called before the first frame update

    public void ThisItem(GameObject item)
    {
        ToDestroy = item;
    }
    public void OnButtonPress()
    { 
        furniturecontroler = ToDestroy.GetComponent<FurnitureControler>();
        furniturecontroler.DeleatItem();
    }

}
