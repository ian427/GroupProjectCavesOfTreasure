using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Serialization;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEditor.UIElements;
public class TutorialButton : MonoBehaviour
{
    [SerializeField] GameObject tutorialoffbutton;
    [SerializeField] GameObject tutorialonbutton;
    [SerializeField] GameObject tutorialofftext;
    [SerializeField] GameObject tutorialontext;
    public bool ShowTutorials = true;
    [SerializeField]private bool dontdestroy = false;
    [SerializeField]private TutorialButton controler;

    private void Awake()
    {
        if(dontdestroy)
        {
            
            DontDestroyOnLoad(this.gameObject);

        }
        else
        {
            controler = GameObject.Find("ToutorialControler").GetComponent<TutorialButton>();
  
        }
       
            if (controler.ShowTutorials)
            {
            controler.ShowTutorials = true;
                //settings
                tutorialoffbutton.SetActive(true);
                tutorialonbutton.SetActive(false);
                tutorialofftext.SetActive(true);
                tutorialontext.SetActive(false);
            }
            else
            {
            controler.ShowTutorials = false;
                tutorialoffbutton.SetActive(false);
                tutorialonbutton.SetActive(true);
                tutorialofftext.SetActive(false);
                tutorialontext.SetActive(true);
            }
        
    }

    public void DisableTutorials()
    {
        controler.ShowTutorials = false;
       
        tutorialoffbutton.SetActive(false);
        tutorialonbutton.SetActive(true);
        tutorialofftext.SetActive(false);
        tutorialontext.SetActive(true);
    }
    public void EnableTutorials()
    {
        controler.ShowTutorials = true;
      
        tutorialoffbutton.SetActive(true);
        tutorialonbutton.SetActive(false);
        tutorialofftext.SetActive(true);
        tutorialontext.SetActive(false);
    }


}
