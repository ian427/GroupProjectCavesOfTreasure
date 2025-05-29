using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonhoverText : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField]GameObject hovertext;

    public void OnPointerEnter(PointerEventData eventData)
    {
        hovertext.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        hovertext.SetActive(false);
    }

}
