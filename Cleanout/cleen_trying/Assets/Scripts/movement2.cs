using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RavingBots.MultiInput;

public class movement2 : MonoBehaviour
{
    public IDevice Device;
    public float Speed = 1;
    public InputState inputState;
    private Dictionary<long, IDevice> devices;

    private void Awake()
    {
        //inputState = FindObjectOfType<InputState>();
    }

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
        
      
        if (Device == null)
        {
            Debug.LogWarning("No Device");
            return;
        }

        IVirtualAxis MouseYUp = Device[InputCode.MouseYUp];
        IVirtualAxis MouseYDown = Device[InputCode.MouseYDown];
        IVirtualAxis MouseXRight = Device[InputCode.MouseXRight];
        IVirtualAxis MouseXLeft = Device[InputCode.MouseXLeft];

       // var xPositive = GetValue(InputCode.MouseXRight);

       // var yNegative = GetValue(InputCode.MouseYDown);

        //var yPositive = GetValue(InputCode.MouseYUp);


        var x = new VirtualAxis();
        var y = new VirtualAxis();

       //x.Set(xNegative > 0 ? -xNegative : xPositive);
        x.Commit();

        //y.Set(yNegative > 0 ? -yNegative : yPositive);
        y.Commit();

        //Here is movement
        var translation = new Vector3(x.Value, y.Value, 0) * Speed * Time.deltaTime;
        transform.position = transform.position + translation;
        //Here is movement
    }

    /*private float GetValue(params InputCode[] codes)
    {
        foreach (var code in codes)
        {
            //var axis = Device[code];
            if (axis != null && axis.IsHeld)
            {
                return axis.Value;
            }
        }

        return 0;
    }*/
}
