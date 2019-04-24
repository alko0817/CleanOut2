using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class protectP2 : MonoBehaviour
{

    #region Shielding
    bool shielding = false;
    public float timer = .5f;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Shield" && immune.def1)
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
                    Score2_.Score_2--;

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
