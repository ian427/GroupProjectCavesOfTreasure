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

    private void Start()
    {

        if (ShowTutorials == false)
        {
            foreach (GameObject popup in popupslist)

            {
                popup.SetActive(false);

            }
        }
        else
        {
            foreach (GameObject popup in popupslist)

            {
                popup.SetActive(true);

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
