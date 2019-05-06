using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset : MonoBehaviour
{

    public newAI3 ai;
    public newFollow follow;
    bool oneTime = false;
    

    
    void Update()
    {
 
        if (!ai.enabled && !oneTime)
          {
            
              StartCoroutine("Reset");
            oneTime = true;

          }

    }


    IEnumerator Reset ()
     {

         yield return new WaitForSeconds(10);
         ai.enabled = true;
         follow.enabled = false;
         yield return new WaitForSeconds(5);
         oneTime = false;
         follow.enabled = true;
         newFollow.p1Follow = false;
         newFollow.p2Follow = false;
         
     }

}
