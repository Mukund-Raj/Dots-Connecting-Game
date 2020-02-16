using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrawLineBetweenTwoDots : MonoBehaviour
{
    //public GameObject obj1;
    //public GameObject obj2;
    public LineRenderer lineRendererObj;

    //public Camera c;

 
    [HideInInspector]
    public static DrawLineBetweenTwoDots instance;
   
    void Start()
    {
        instance = this;
      
        /*
        Camera cam = Camera.main;
        Vector3 corners = new Vector3(Screen.width, Screen.height, 0f);
        //Debug.Log(obj1);
        Vector3 pos = obj1.GetComponent<RectTransform>().position;
        Vector3 screenPos = cam.ScreenToWorldPoint(pos);

        Debug.Log(pos);
        Debug.Log(cam.ScreenToWorldPoint(pos));

        Vector3 pos1 = obj2.GetComponent<RectTransform>().position;
        Vector3 screenPos1 = cam.ScreenToWorldPoint(pos1);

        Debug.Log(pos1);
        Debug.Log(cam.ScreenToWorldPoint(pos1));

        //Debug.Log(cam.ScreenToWorldPoint(corners));
       // line.SetPosition(0, screenPos);
        //line.SetPosition(1,screenPos1);
       
        
        //Debug.Log("dot 1" + obj1.GetComponent<RectTransform>().localPosition);
        //Debug.Log("dot 2"+obj2.GetComponent<RectTransform>().localPosition);
        */
    }
    
    public void GenerateLine(Vector3 start,Vector3 end)
    {
        LineRenderer line = GameObject.Instantiate(lineRendererObj);

        line.SetPosition(0, start);
        line.SetPosition(1,end);
        Debug.Log("yeah working");
    }
   
}
