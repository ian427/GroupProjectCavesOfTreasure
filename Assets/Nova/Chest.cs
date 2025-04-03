using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Chest : MonoBehaviour
{

    public Collider2D Collider;
    private bool isTriggerEnabled = false;
    public GameObject Enviroment;
    public GameObject _Chest;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        chestFound();
    
    }

    public void chestFound()
    {

        if (Enviroment.transform.position.y == _Chest.transform.position.y)
        {

            Collider.isTrigger = false;


        }
        else
        {
            Collider.isTrigger = true;
        }


    }
  

}

