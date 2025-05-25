using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Chest2 : MonoBehaviour
{

    public Collider2D Collider;
    private bool isTriggerEnabled = false;
    public GameObject Enviroment;
    public GameObject _Chest;
    public Animator animator;
    public Hunt2 hunt2;
    private bool chestOpen;

    public ParticleSystem openChestVFX;
    
    void Start()  //Made by Dan R, assigns the animator and prepares the chest for its initial animation state
    {
        animator = GetComponent<Animator>();

        animator.SetBool("ChestOpen", false);

        chestOpen = false;
    }

    //Triggers the chestFound function
    void Update()
    {

        chestFound();
    
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(chestOpen == false)
            {
                openChestVFX.Play();
                animator.SetBool("ChestOpen", true);
                hunt2.ClickOnChest();
                chestOpen = true;

                StartCoroutine(disableChest());
            }
        }
    }

    public void chestFound() //Made by Nova
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

    //Waits 2 seconds and then destroys the chest
    private IEnumerator disableChest()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
}

