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
    [SerializeField] GameObject tutorialoffbutton;
    [SerializeField] GameObject tutorialonbutton;
    [SerializeField] GameObject tutorialofftext;
    [SerializeField] GameObject tutorialontext;
    public bool ShowTutorials = true;
    private string Test;

    private void Start()
    {
        if (PlayerPrefs.HasKey("ShowTutorialsBool"))
        {
            Test = PlayerPrefs.GetString("ShowTutorialsBool");

            if (Test == "true")
            {
                ShowTutorials = true;
                tutorialoffbutton.SetActive(true);
                tutorialonbutton.SetActive(false);
                tutorialofftext.SetActive(true);
                tutorialontext.SetActive(false);
            }
            else
            {
                ShowTutorials = false;
                tutorialoffbutton.SetActive(false);
                tutorialonbutton.SetActive(true);
                tutorialofftext.SetActive(false);
                tutorialontext.SetActive(true);
            }
        }

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
        PlayerPrefs.SetString("ShowTutorialsBool", "false");
        tutorialoffbutton.SetActive(false);
        tutorialonbutton.SetActive(true);
        tutorialofftext.SetActive(false);
        tutorialontext.SetActive(true);
    }
    public void EnableTutorials()
    {
        ShowTutorials = true;
        PlayerPrefs.SetString("ShowTutorialsBool", "true");
        tutorialoffbutton.SetActive(true);
        tutorialonbutton.SetActive(false);
        tutorialofftext.SetActive(true);
        tutorialontext.SetActive(false);
    }


}
