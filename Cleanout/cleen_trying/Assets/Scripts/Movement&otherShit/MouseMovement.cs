using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    public static float Speed = 2.0f;
    public float speedModerator = 1f;
    public float speedModifier = .1f;
    public float timer = .5f;
   
    
    int sumModifier;
    bool shielding = false;

    public void OnEnable()
    {
        StartCoroutine("Mopping");      
    }

    IEnumerator Mopping ()
    {
        float timeCounter = 0f;
        while (true)
        {
            
                if (timeCounter > 0)
                {
                    timeCounter -= Time.deltaTime;
                }
                else
                {
                    Score_1.Score++;
                
                timeCounter = timer;
                }
           
            yield return null;
        }
    }

    public void Update()
    {
        #region Movement
        transform.Translate(transform.right * Speed * Time.smoothDeltaTime);
        Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

        float MouseY = Input.GetAxisRaw("Mouse Y");
        if (MouseY > 5f || MouseY < -5f && Speed < 8)
        {
            Speed = Speed + speedModifier;
            sumModifier = 1;
        }
        else
        {
            Speed = speedModerator;
            sumModifier = 0;
        }
        
        if (mousePosition.x < 213.0)
        {
            transform.Rotate(new Vector3(0, 0, 1.00f));
        }
        if (mousePosition.x >= 213.0 && mousePosition.x < 416.0)
        {
            transform.Rotate(new Vector3(0, 0, 0.66f));
        }
        if (mousePosition.x >= 416.0 && mousePosition.x < 639.0)
        {
            transform.Rotate(new Vector3(0, 0, 0.33f));
        }
        if (mousePosition.x >= 1281.0 && mousePosition.x < 1494.0)
        {
            transform.Rotate(new Vector3(0, 0, -0.33f));
        }
        if (mousePosition.x >= 1494.0 && mousePosition.x < 1707.0)
        {
            transform.Rotate(new Vector3(0, 0, -0.66f));
        }
        if (mousePosition.x >= 1707.0)
        {
            transform.Rotate(new Vector3(0, 0, -1.00f));
        }
        #endregion

        Score_1.Score = Score_1.Score + sumModifier;  
        
    }


    #region Shielding

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Shield" && immune.def2)
        {
            StartCoroutine("UnMopping");

        }
       
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Shield")
            shielding = true;
    }
     void OnTriggerExit2D(Collider2D collision)
    {
      
            shielding = false;
    }
    IEnumerator UnMopping()
    {
        float timeCounter = 0f;
        while (true)
        {
            if (shielding)
            {
                if (timeCounter > 0)
                {
                    timeCounter -= Time.deltaTime;
                }
                else
                {
                    Score_1.Score--;

                    timeCounter = timer;
                }
            }
            else break;
            yield return null;
            
        }
        StopCoroutine("UnMopping");
    }
    #endregion 
}
