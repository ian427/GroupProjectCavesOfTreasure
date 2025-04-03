using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureControler : MonoBehaviour
{
    private GameControler controler;
    private int clicks = 0;
    [SerializeField] private bool CanPlace = true;
    [SerializeField] float ClickTolarence = 0.25f;
    private Vector3 Move;
    private MonsterGrow monster;

    // Start is called before the first frame update
    void Start()
    {
        controler = GameObject.Find("Controller").GetComponent<GameControler>();
        monster = GameObject.Find("Player").GetComponent<MonsterGrow>();
        CanPlace = true ;
        monster.UpdateMonsterSize();
        controler.TotalItems++;
    }

    // Update is called once per frame
    void Update()
    {
        if (CanPlace)
        {
            Move = Camera.main.ScreenToWorldPoint(Input.mousePosition);//converts pixel cords to mouse pos
            Move.z = 0f;
            transform.position = Move;
            //goto mouse
        }

    }
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clicks++;
            CanPlace = !CanPlace;
            if (clicks < 1 )
            {
                clicks = 0;
                //ask to deleate
            }

        }
    }
    private void DeleatItem()//removes from gameplay area
    {
       
        controler.TotalItems--;
        controler.AddItem(this.gameObject);
        monster.UpdateMonsterSize();
        Destroy(this.gameObject);
    }
    private void OnMouseExit()
    {
        clicks = 0;
    }
    private IEnumerator time()
    {
        yield return new WaitForSeconds(ClickTolarence);
        if (clicks < 1)
        {
            clicks = 0;
            //ask to deleate
        }

    }

}

        