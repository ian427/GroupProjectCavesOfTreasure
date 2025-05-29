using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToutolialsControler : MonoBehaviour
{
    // Start is called before the first frame update
    public TutorialButton controler;
    [SerializeField] private List<GameObject> popupslist;// all the toutorials
    private void Start()
    {
        controler = GameObject.Find("ToutorialControler").GetComponent<TutorialButton>();

        if (controler.ShowTutorials)
        {
            foreach (GameObject popup in popupslist)
            {
                popup.SetActive(true);//set to bool

            }
        }
        if (!controler.ShowTutorials)
        {
            foreach (GameObject popup in popupslist)
            {
                popup.SetActive(false);//set to bool

            }

        }



    }


}
