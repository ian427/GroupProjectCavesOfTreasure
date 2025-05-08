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
    public GameObject ConcealObject;
    int level;
    int random;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(0);
        level = GameObject.Find("Monster").GetComponent<Level>().level;
        if (level <= 3)
        {
            random = UnityEngine.Random.Range(0, 5);
            if (random == 4)
            {
                Instantiate(ConcealObject, new Vector3(0, 0, 0), Quaternion.identity);
            }
        }
        else if (level <= 7)
        {
            random = UnityEngine.Random.Range(0, 2);
            if (random == 1)
            {
                Instantiate(ConcealObject, new Vector3(0, 0, 0), Quaternion.identity);
            }
        }
        else
        {
            random = UnityEngine.Random.Range(0, 5);
            if (random != 0)
            {
                Instantiate(ConcealObject, new Vector3(0, 0, 0), Quaternion.identity);
            }
        }
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

