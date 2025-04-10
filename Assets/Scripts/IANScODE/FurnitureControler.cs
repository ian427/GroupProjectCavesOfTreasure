using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureControler : MonoBehaviour
{
    private GameControler controler;
    private float clickstime = 0;
    [SerializeField] private bool CanPlace = true;
    [SerializeField] float ClickTolarence = 0.25f;
    private Vector3 Move;
    private MonsterGrow monster;
    private PopUpFurniture popup;

    // Start is called before the first frame update
    void Start()
    {
        controler = GameObject.Find("Controller").GetComponent<GameControler>();
        monster = GameObject.Find("Player").GetComponent<MonsterGrow>();
        popup = GameObject.Find("EventSystem").GetComponent<PopUpFurniture>();
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
        Debug.Log("Over");
        if (Input.GetMouseButtonDown(0))
        {
            CanPlace = !CanPlace;
        }
        if (Input.GetMouseButtonUp(0))
        {
            popup.clickNumber += 1;
        }
        if (popup.clickNumber == 1 && popup.isTimeCheckAllowed)
        {
            popup.firstClickTime = Time.time;
            popup.Currentitem = this.gameObject;
            StartCoroutine(popup.DetectDoubleClick());
        }
    }
    public void DeleatItem()//removes from gameplay area
    {
       
        controler.TotalItems--;
        controler.AddItem(this.gameObject);
        monster.UpdateMonsterSize();
        Destroy(this.gameObject);
    }
    private void OnMouseExit()
    {
        popup.clickNumber = 0;
    }

}

        