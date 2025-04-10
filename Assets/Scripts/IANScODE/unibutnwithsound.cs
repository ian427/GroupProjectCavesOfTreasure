using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class unibutnwithsound : MonoBehaviour
{
    public AudioSource click;
    private bool canSwitch = false;
    [SerializeField]
    private string SceneToGoTO;
    public void OnButtonPress()
    {
        SceneManager.LoadScene(SceneToGoTO);//remove for sound
        click.Play();
        canSwitch = true;

    }
    private void Update()
    {

        if (!click.isPlaying && canSwitch)//defults true
        {
         
            SceneManager.LoadScene(SceneToGoTO);//remember to add scene to Build
        }
    }
}
