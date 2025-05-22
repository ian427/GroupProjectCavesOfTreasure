using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Serialization;
using UnityEngine.SceneManagement;
using UnityEngine;
public class TutorialButton : MonoBehaviour
{
    [SerializeField] GameObject popupbutton;
    public void ClosePopup()
    {
        popupbutton.SetActive(false);
    }
}
