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

    //VFX
    public ParticleSystem openChestVFX;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        animator.SetBool("ChestOpen", false);
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

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            openChestVFX.Play();
            animator.SetBool("ChestOpen", true);
        }
    }



}

