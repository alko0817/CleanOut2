using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_second_player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float h = Input.GetAxis("Horizontal") * Time.deltaTime * 2f;
        float v = Input.GetAxis("Vertical") * Time.deltaTime * 2f ;
        transform.Translate(h, v, 0);



    }
}
