using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop2 : MonoBehaviour
{
    Vector2 difference = Vector2.zero;

    //When the mouse is down, the object will be picked up
    private void OnMouseDown()
    {
        difference = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2)transform.position;
    }

    //When held and moved, the object selected will move with the mouse
    private void OnMouseDrag()
    {
        transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - difference;
    }

    //Releasing the click will destroy the object
    private void OnMouseUp()
    {
        Destroy(gameObject);
    }
}
