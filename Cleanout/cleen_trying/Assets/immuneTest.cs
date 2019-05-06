using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class immuneTest : MonoBehaviour
{

    public GameObject effect;
    public GameObject circle;

    void Start()
    {
        StartCoroutine("Present");
    }

    IEnumerator Present ()
    {
        yield return new WaitForSeconds(5);
        effect.SetActive(true);
        circle.SetActive(true);
        
        yield return new WaitForSeconds(3);
        effect.SetActive(false);
        circle.SetActive(false);
    }

}
