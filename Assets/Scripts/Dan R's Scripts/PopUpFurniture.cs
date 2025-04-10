using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpFurniture : MonoBehaviour
{
    public GameObject popUpMenu;
    public GameObject Currentitem;
    //Double clicking variables
    public float firstClickTime;
    private float timeInbetweenClicking = 0.5f;
    public bool isTimeCheckAllowed = true;
    public int clickNumber = 0;

    //Sets the popUpMenu to be inactive upon the start
    void Start()
    {
        popUpMenu.SetActive(false);
    }
    /*
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            clickNumber += 1;
        }

        if(clickNumber == 1 && isTimeCheckAllowed)
        {
            firstClickTime = Time.time;
            StartCoroutine(DetectDoubleClick());
        }
    }
    */
    public IEnumerator DetectDoubleClick()
    {
        isTimeCheckAllowed = false;
        while(Time.time < firstClickTime + timeInbetweenClicking)
        {
            if(clickNumber == 2)
            {
                Debug.Log("PopUp");
                popUpMenu.SetActive(true); 
                break;
            }
            yield return new WaitForEndOfFrame();
        }
        clickNumber = 0;
        isTimeCheckAllowed = true;
    }
}
