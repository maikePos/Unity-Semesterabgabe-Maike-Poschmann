using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


[RequireComponent(typeof(Image))]
public class TabButtons : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler, IPointerExitHandler
{
    public TabScript tabScript;

    public Image background;

    private void Start()
    {
        background = GetComponent<Image>();
        tabScript.Subscribe(this);
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        tabScript.OnTabSelected(this);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        tabScript.OnTabEnter(this);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        tabScript.OnTabExit(this);
    }
}

   

