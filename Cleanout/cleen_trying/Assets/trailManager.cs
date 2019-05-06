using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trailManager : MonoBehaviour
{
    public TrailRenderer trail;
    public newAI3 ai;
    public newFollow follow;
    public reset reset;

    void Update()
    {
        if (ai.enabled && follow.enabled) trail.enabled = false;
        
        if (follow.enabled && !ai.enabled) trail.enabled = true;

        if (!follow.enabled && ai.enabled) trail.enabled = false;
        
    }
}
