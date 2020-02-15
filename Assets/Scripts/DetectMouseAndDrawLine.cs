using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class DetectMouseAndDrawLine : MonoBehaviour,IPointerClickHandler,IDragHandler,IPointerEnterHandler
{
    public void OnDrag(PointerEventData eventData)
    {
        if (eventData.dragging)
        {
            Debug.Log("user dragging");
            Debug.Log(Input.mousePosition);
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.dragging)
        {
            Debug.Log("user dragging");
            Debug.Log(Input.mousePosition);
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Mouse entered");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
