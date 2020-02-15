using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrawLineBetweenTwoDots : MonoBehaviour
{
    public GameObject obj1;
    public GameObject obj2;
    public LineRenderer line;
    public Camera c;

     void Start()
    {
        Camera cam = Camera.main;
        Vector3 corners = new Vector3(Screen.width, Screen.height, 0f);
        //Debug.Log(obj1);
        Vector3 pos = obj1.GetComponent<RectTransform>().localPosition;
        Debug.Log(cam.WorldToScreenPoint(pos));
        Vector3 pos1 = obj2.GetComponent<RectTransform>().localPosition;
        Debug.Log(cam.WorldToScreenPoint(pos1));
        Debug.Log(cam.)
        Debug.Log(cam.ScreenToWorldPoint(corners));
        Debug.Log(cam.WorldToViewportPoint(c.transform.position));
        
        //Debug.Log("dot 1" + obj1.GetComponent<RectTransform>().localPosition);
        //Debug.Log("dot 2"+obj2.GetComponent<RectTransform>().localPosition);
    }
    // Update is called once per frame
    void Update()
    {
       

    }
}
