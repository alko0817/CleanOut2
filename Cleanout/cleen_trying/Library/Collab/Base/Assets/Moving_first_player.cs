using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_first_player : MonoBehaviour
{
    public GameObject white_clean;
    public GameObject green_clean;
    public GameObject red_clean;
    public GameObject blue_clean;
    public float count_white;
    public float count_green;
    public float count_red;
    public float count_blue;

    private float sum = 0; 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float h = 0 ;
        float v = 0 ; 

    //float v = Input.GetAxis("Vertical") * Time.deltaTime;

        if (Input.GetKey("d"))
        {
            Instantiate(blue_clean, transform.position, Quaternion.identity);
            h = 1 * Time.deltaTime;
            count_white++;
        }
        if (Input.GetKey("a"))
        {
            Instantiate(blue_clean, transform.position, Quaternion.identity);
            h = -1 * Time.deltaTime;
            count_green++; 
        }
        if (Input.GetKey("w"))
        {
            Instantiate(blue_clean, transform.position, Quaternion.identity);

            v = 1 * Time.deltaTime;
            count_red++; 
        }
        if (Input.GetKey("s"))
        {
            Instantiate(blue_clean, transform.position, Quaternion.identity);

            v = - 1 * Time.deltaTime;
            count_blue++; 
        }

        sum += count_blue;  // + count_green + count_red + count_white;
        print(sum); 
        transform.Translate (h,v,0 ); 

         
    }
}
