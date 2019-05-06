using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_first_player : MonoBehaviour
{
    int i;
    int z;
    public GameObject Fire_shoot;

    void Update()
    {
        i = GameObject.Find("Player_1").GetComponent<MouseMovement>().i;
        z = GameObject.Find("Player_1").GetComponent<MouseMovement>().z;

        if (p1_power_score.Score >= 0)
        {
            if (Input.GetButtonDown("p1_shoot"))
            {
                switch (i)
                {
                    case 1:
                        Instantiate(Fire_shoot, transform.position + transform.right * 2, Quaternion.Euler(0.0f, 0.0f, Random.Range(0.0f, 360.0f)));
                        break;
                    case 2:
                        Instantiate(Fire_shoot, transform.position + -transform.up * 1.5f + transform.right * 1.5f, Quaternion.Euler(0.0f, 0.0f, Random.Range(0.0f, 360.0f)));
                        break;
                    case 3:
                        Instantiate(Fire_shoot, transform.position + -transform.up * 2, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(Fire_shoot, transform.position + -transform.up * 1.5f + -transform.right * 1.5f, Quaternion.Euler(0.0f, 0.0f, Random.Range(0.0f, 360.0f)));
                        break;
                    case 5:
                        Instantiate(Fire_shoot, transform.position + -transform.right * 2, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(Fire_shoot, transform.position + transform.up * 1.5f + -transform.right * 1.5f, Quaternion.Euler(0.0f, 0.0f, Random.Range(0.0f, 360.0f)));
                        break;
                    case 7:
                        Instantiate(Fire_shoot, transform.position + transform.up * 2, Quaternion.identity);
                        break;
                    case 0:
                        Instantiate(Fire_shoot, transform.position + transform.up * 1.5f + transform.right * 1.5f, Quaternion.Euler(0.0f, 0.0f, Random.Range(0.0f, 360.0f)));
                        break;
                }

                if (Input.GetButtonDown("p1_shoot") && i > 7)
                    switch (z)
                    {
                        case 1:
                            Instantiate(Fire_shoot, transform.position + -transform.up * 2, Quaternion.identity);
                            break;
                        case 2:
                            Instantiate(Fire_shoot, transform.position + -transform.up * 1.5f + -transform.right * 1.5f, Quaternion.Euler(0.0f, 0.0f, Random.Range(0.0f, 360.0f)));
                            break;
                        case 3:
                            Instantiate(Fire_shoot, transform.position + -transform.right * 2, Quaternion.identity);
                            break;
                        case 4:
                            Instantiate(Fire_shoot, transform.position + transform.up * 1.5f + -transform.right * 1.5f, Quaternion.Euler(0.0f, 0.0f, Random.Range(0.0f, 360.0f)));
                            break;
                        case 5:
                            Instantiate(Fire_shoot, transform.position + transform.up * 2, Quaternion.identity);
                            break;
                        case 6:
                            Instantiate(Fire_shoot, transform.position + transform.up * 1.5f + transform.right * 1.5f, Quaternion.Euler(0.0f, 0.0f, Random.Range(0.0f, 360.0f)));
                            break;
                        case 7:
                            Instantiate(Fire_shoot, transform.position + transform.right * 2, Quaternion.identity);
                            break;
                        case 0:
                            Instantiate(Fire_shoot, transform.position + -transform.up * 1.5f + transform.right * 1.5f, Quaternion.Euler(0.0f, 0.0f, Random.Range(0.0f, 360.0f)));
                            break;
                    }

                p1_power_score.Score--;
                Score_1.Score += 100;

                if (p1_power_score.Score < 1)
                {
                    p1_power_score.Score = 0;
                }
            }
        }
    }
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Fire_")
        {
            Destroy(other.gameObject);
            p1_power_score.Score++;
        }
    }
}

