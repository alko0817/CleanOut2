using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newTrail : MonoBehaviour
{
    public GameObject trail;
    public Transform player;
    public float timer = 2f;
    float step = 0;
    public Vector3 rot = new Vector3 (0,0,1);
    int side;


    void Start()
    {
        StartCoroutine("cleaning");
    }

    private void Update()
    {
        side = gameObject.GetComponent<MouseMovement>().i;
        switch (side)
        {
            case 0:
                step = 0;
                break;
            case 1:
                step = 45;
                break;
            case 2:
                step = 90;
                break;
            case 3:
                step = 135;
                break;
            case 4:
                step = 180;
                break;
            case 5:
                step = 225;
                break;
            case 6:
                step = 270;
                break;
            case 7:
                step = 315;
                break;
        }

    }
    IEnumerator cleaning ()
    {
        float counter = 0f;
        while (true)
        {
            if (counter > 0) counter -= Time.deltaTime;
            else
            {


                Instantiate(trail, player.position, Quaternion.AngleAxis(step, rot));
                counter = timer;
            }
        }
    }
}
//Quaternion.RotateTowards(trail.transform.rotation, player.rotation, step));