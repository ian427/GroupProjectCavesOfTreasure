using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialCloser : MonoBehaviour
{
    [SerializeField] GameObject popupbutton;
    public void ClosePopup()
    {
        popupbutton.SetActive(false);
    }
}
