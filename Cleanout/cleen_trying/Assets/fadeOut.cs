using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadeOut : MonoBehaviour
{
    public SpriteRenderer sprite;

    public float delay;
    float previousDelay;


    void Start()
    {
        previousDelay = gameObject.GetComponent<fadeIn>().delay;
        StartCoroutine("FadeOut");
    }

    IEnumerator FadeOut()
    {

        yield return new WaitForSeconds(previousDelay + delay);
        float i = 1;
        for (float t = 0f; t < 100f; t += Time.deltaTime / 2)
        {
            sprite.color = new Color(1, 1, 1, i);
            i = i - .01f;
            if (i == 0)
            {
                Destroy(gameObject);
                break;
            }
                
            yield return null;
        }

    }
}
