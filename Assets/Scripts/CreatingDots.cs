using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CreatingDots : MonoBehaviour
{
    public Image dot;

    private int ScreenWidth;
    private int ScreenHeight;

    public Transform canvas_transform;
    // Start is called before the first frame update
    void Start()
    {
        ScreenWidth = Screen.width;
        ScreenHeight = Screen.height;
        Debug.Log(ScreenWidth + " " + ScreenHeight);
        Making_Dots();

    }
    void Making_Dots()
    {
        int dx = 5;
        int dy = 5;

        //calculating no of dots based on the resolution of the screen width
        int no_of_dots_in_a_Row = (int)Mathf.Floor((ScreenWidth - 50) / 50);
        //calculating no of dots based on the resolution of the screen height
        int no_of_rows= (int)Mathf.Floor((ScreenHeight - 50) / 50);


        for (int j = 0; j < no_of_rows+2; j++)
        {
            for (int i = 0; i < no_of_dots_in_a_Row + 1; i++)
            {
                Image dot_object = GameObject.Instantiate(dot);

                dot_object.transform.SetParent(canvas_transform);
                dot_object.GetComponent<RectTransform>().localPosition = new Vector3(100f, 100f, 0f);
                dot_object.GetComponent<RectTransform>().localScale = new Vector3(1f, 1f, 1f);
                //dot_object.transform.localPosition = new Vector3(dx, dy, 0f);
 
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
