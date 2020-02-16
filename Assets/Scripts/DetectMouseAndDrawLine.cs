using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class DetectMouseAndDrawLine : MonoBehaviour,IPointerClickHandler,IDragHandler,IPointerEnterHandler,
    IEndDragHandler
{
    [HideInInspector]   
    GameObject that_is_receiving__drag=null;

    //to check if this dot connected to some other dot
    [HideInInspector]
    public bool Is_connected = false;
    void Start()
    {
        //thisGameobject = GetComponent<GameObject>().gameObject;
        /*
        drawLineBetweenTwoDots = DrawLineBetweenTwoDots.
            thisGameobject.GetComponent<DrawLineBetweenTwoDots>();
        drawLineBetweenTwoDots.GenerateLine();*/
        //DrawLineBetweenTwoDots.instance.GenerateLine();
    }
    public void OnDrag(PointerEventData eventData)
    {
        if (eventData.dragging)
        {
            that_is_receiving__drag = eventData.pointerDrag;
            //Debug.Log("user dragging");
            //drawLineBetweenTwoDots.GenerateLine();
            Debug.Log(transform.gameObject.name + " is being dragged");
            //Debug.Log(Input.mousePosition);
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
        if(eventData.dragging)
        {
                Debug.Log(eventData.pointerDrag.name +" is dragging");
            

        }
        //drawLineBetweenTwoDots.GenerateLine();
        Debug.Log("Mouse entered");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        RaycastResult currentRaycast = eventData.pointerCurrentRaycast;

        if(currentRaycast.isValid)
        {
            if (that_is_receiving__drag != currentRaycast.gameObject)
            {

                Vector3 second_point = currentRaycast.gameObject.GetComponent<RectTransform>().position;

                Vector3 first_point = that_is_receiving__drag.GetComponent<RectTransform>().position;
                Debug.Log(first_point+" "+second_point);
                //checking for diagonal lines
                //we are comparing x of the two line and y of the two line
                //if they are same it means they are either horizontal or vertical
                //otherwise they are diagonals
                //Debug.Log();

                if ( (first_point.x==second_point.x )|| (first_point.y == second_point.y))
                {
                    //limiting the line distance to two dots by computing the distance 
                    //between two vectors
                  if(Mathf.RoundToInt(Vector3.Distance(first_point, second_point))==2)  
                    DrawLineBetweenTwoDots.instance.GenerateLine(first_point, second_point);
                }
            }
        }
        else
        {
            Debug.Log("I am connected to some other dot");
        }
    }
}
