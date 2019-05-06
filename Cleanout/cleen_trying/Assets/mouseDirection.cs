using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseDirection : MonoBehaviour
{

    Vector2 mousePos;
    public Vector2 realPos;
    public Vector2 rightMax;
    public Vector2 leftMax;
    public float step;

    private void Update()
    {
        mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        

        if (mousePos.x <= 1280 && mousePos.x > 639) transform.position = Vector2.MoveTowards(transform.position, realPos, step);
        if (mousePos.x > 1280) transform.position = Vector2.MoveTowards(transform.position, rightMax, step);
        if (mousePos.x < 639) transform.position = Vector2.MoveTowards(transform.position, leftMax, step);

        
    }
}


