using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Serialization;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEditor.UIElements;
public class TutorialButton : MonoBehaviour
{
    [SerializeField] GameObject popupbutton;
    [SerializeField] private List<GameObject> popupslist;
    public bool ShowTutorials = true;
    

    private void Awake()
    {
        //popupslist = new List<GameObject>();

    }

    private void Update()
    {

        if (ShowTutorials == false)
        {
            foreach (GameObject popup in popupslist)

            {
                popup.SetActive(false);

            }
        }
        
    }

    public void ClosePopup()
    {
        popupbutton.SetActive(false);
    }

    public void DisableTutorials()
    {
        ShowTutorials = false;
    }

    public void EnableTutorials()
    {
        ShowTutorials = true;
    }

   
}
