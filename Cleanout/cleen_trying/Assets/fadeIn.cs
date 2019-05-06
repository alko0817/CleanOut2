using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadeIn : MonoBehaviour
{
    public SpriteRenderer sprite;

    public float delay;


    void Start()
    {
        StartCoroutine("FadeIn");
    }

    IEnumerator FadeIn ()
    {
        yield return new WaitForSeconds(delay);
        float i=0 ;
        for(float t = 0f; t<100f; t += Time.deltaTime /2)
        {
            sprite.color = new Color(1, 1, 1, i);
                i = i + .01f ;
            yield return null;
        }
        
    }
}
