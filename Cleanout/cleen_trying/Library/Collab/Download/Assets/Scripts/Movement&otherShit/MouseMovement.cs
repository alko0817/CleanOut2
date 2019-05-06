using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    [SerializeField]
    public static float Speed = 4.0f;
    public float speedModerator = 1f;
    public float speedModifier = .1f;

    public float timer = .8f;
    public float scale = 0;

    public int i = 1;
    public int z = 7 ;
    bool turnRight = false;
    bool turnLeft = false;
    float turnTime = .8f;
    int lastPos = 1;

    private Rigidbody2D rb;
    Vector2 move = new Vector2(1, 0);
    public GameObject[] dirs;
    GameObject lastSprite;

    int sumModifier;
    bool shielding = false;

    private void Start()
    {
        lastSprite = dirs[0];
        rb = GetComponent<Rigidbody2D>();
    }
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
        rb.velocity = Speed * move;
        Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

        #region Speeding

        float MouseY = Input.GetAxisRaw("Mouse Y");
        if (MouseY > 1f || MouseY < -1f && Speed < 8)
        {
            Speed = Speed + speedModifier;
            sumModifier = 1;
        }
        else
        {
            Speed = speedModerator;
            sumModifier = 0;
        }

        #endregion

        #region newMovement
        
        if (mousePosition.x >= 1281 && !turnRight)
        {          
            StartCoroutine("clockwise");
            turnRight = true;            
        }
        if (mousePosition.x < 1281)
        {          
            turnRight = false;
            StopCoroutine("clockwise");          
        }

        if (mousePosition.x <= 639 && !turnLeft)
        {          
            StartCoroutine("counterclock");
            turnLeft = true;
        }
        if (mousePosition.x > 639)
        {
            StopCoroutine("counterclock");   
            turnLeft = false;           
        }  
        #endregion

        Score_1.Score = Score_1.Score + sumModifier;         
    }

    IEnumerator clockwise ()
    {
        i = lastPos;
        float counter = 0f;
        z = 8;

        while (true)
        {
            if (counter > 0) counter -= Time.deltaTime;
            else
            {
                switch (i)
                {
                    case 0:
                        move = transform.right ;
                        changeSprite(i);
                        break;
                    case 1:
                        move = new Vector2(1, -1);
                        changeSprite(i);
                        break;
                    case 2:
                        move = -transform.up;
                        changeSprite(i);
                        break;
                    case 3:
                        move = new Vector2(-1, -1);
                        changeSprite(i);
                        break;
                    case 4:
                        move = -transform.right;
                        changeSprite(i);
                        break;
                    case 5:
                        move = new Vector2(-1, 1);
                        changeSprite(i);
                        break;
                    case 6:
                        move = transform.up;
                        changeSprite(i);
                        break;
                    case 7:
                        move = new Vector2(1, 1);
                        changeSprite(i);
                        break;
                }
                counter = turnTime;
                if (i == 7) i = 0;
                else i++;             
            }
            yield return null;
        }       
    }

    IEnumerator counterclock ()
    {
        z = lastPos;
        float counter = 0f;
        i = 8;
        while (true)
        {
            if (counter > 0) counter -= Time.deltaTime;
            else
            {
                switch (z)
                {
                    case 0:
                        move = transform.right;
                        changeSprite(z);
                        break;
                    case 1:
                        move = new Vector2(1, -1);
                        changeSprite(z);
                        break;
                    case 2:
                        move = -transform.up;
                        changeSprite(z);
                        break;
                    case 3:
                        move = new Vector2(-1, -1);
                        changeSprite(z);
                        break;
                    case 4:
                        move = -transform.right;
                        changeSprite(z);
                        break;
                    case 5:
                        move = new Vector2(-1, 1);
                        changeSprite(z);
                        break;
                    case 6:
                        move = transform.up;
                        changeSprite(z);
                        break;
                    case 7:
                        move = new Vector2(1, 1);
                        changeSprite(z);
                        break;
                }
                counter = turnTime;
                if (z == 0) z = 7;
                else z--;                
            }
            yield return null;
        }
    }

    void changeSprite (int count)
    {
        lastSprite.SetActive(false);
        dirs[count].SetActive(true);
        lastSprite = dirs[count];
        if (turnRight)
        {
            if (count == 0) lastPos = 7;
            else lastPos = count - 1;
        }
        if (turnLeft)
        {
            if (count == 7) lastPos = 0;
            else lastPos = count + 1;
        }
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
