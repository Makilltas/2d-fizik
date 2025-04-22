using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControler : MonoBehaviour
{
    public GameObject cursor;

    [Range(0.1f, 1)] public float smoothness = 0.1f;

    private bool mouseDown;


    void Start()
    {
        cursor.SetActive(false);
    }
   

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            mouseDown = true;
            cursor.SetActive(true);
            cursor.transform.position = ScreeToWorldPoint(Input.mousePosition);
        }
        else if (Input.GetMouseButtonUp(0)) 
        {
            mouseDown = false;
            cursor.SetActive(false);
        }

        if(mouseDown)
        {
            Vector3 target =ScreeToWorldPoint(Input.mousePosition);
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, target, smoothness);    
            cursor.transform.position = smoothedPosition;
        }
    }

    Vector3 ScreeToWorldPoint(Vector3 screenPoint)
    {
        Vector3 worldPoint = Camera.main.ScreenToWorldPoint(screenPoint);
        worldPoint.z= 0;
        return worldPoint;
    }

}
