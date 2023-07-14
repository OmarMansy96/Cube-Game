using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;



public class DraggableItem : MonoBehaviour,IBeginDragHandler, IEndDragHandler,IDragHandler,IPointerClickHandler
{

    [HideInInspector] public Transform parentAfterDrag;
    public Image image;
   
    public void OnBeginDrag(PointerEventData eventData)
    {
       // Debug.Log("OnBeginDrag");
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        image.raycastTarget = false;

    }

    public void OnDrag(PointerEventData eventData)
    {
      //  Debug.Log("OnDrag");
        transform.position = Input.mousePosition;

    }

    public void OnEndDrag(PointerEventData eventData)
    {
      //  Debug.Log("OnEndDrag");
        transform.SetParent(parentAfterDrag);
        image.raycastTarget = true;

    }

    public void OnPointerClick(PointerEventData eventData)
    {
       // Debug.Log("OnPointerClick");

    }



}
