using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Serialization;
using UnityEngine.SceneManagement;
using UnityEngine;



public class TutorialButton : MonoBehaviour
{
    [SerializeField] GameObject popup;

    public void ClosePopup()
    {
        popup.SetActive(false);
    }



}
