using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursor : MonoBehaviour
{
    public GameObject click;
    

    void Start()
    {
        //Cursor.visible = false;
    }
    void Update()
    {
       // float MouseX = Input.GetAxisRaw("Mouse X");
      //  float MouseY = Input.GetAxisRaw("Mouse Y");
       // Debug.Log(MouseX + MouseY);
        Vector2 cursPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = cursPos;
        if (Input.GetMouseButtonDown(0))
        {
            //Instantiate(click, transform.position, Quaternion.identity);           
        }
    }
}
