using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noRotor : MonoBehaviour
{

    float lockRot = 0f;
    public Transform orPos;
    float newRot;
  
    void Update()
    {
        newRot = Mathf.Abs(orPos.transform.rotation.z);
        transform.position = new Vector3(orPos.transform.position.x -0f , orPos.transform.position.y + 0.9f);
        transform.rotation = Quaternion.Euler(lockRot, lockRot, lockRot);
    }
}
