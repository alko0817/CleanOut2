using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RavingBots.MultiInput;
using System.Text;
using System.Linq;
using UnityEngine.UI;

public class inputAssign : MonoBehaviour
{
    InputState input;
    private static readonly IList<InputCode> InterestingAxes;
   // string[] dev = null;
    IDevice device;

    /*static InputAssign ()
    {
        InterestingAxes = InputStateExt
            .AllAxes
            .Where(axis => !IsUninteresting(axis))
            .ToList();
    }*/
    private static bool IsUninteresting(InputCode axis)
    {
        switch (axis)
        {
            case InputCode.MouseX:
            case InputCode.MouseY:
            case InputCode.MouseXLeft:
            case InputCode.MouseXRight:
            case InputCode.MouseYUp:
            case InputCode.MouseYDown:
            case InputCode.PadLeftStickY:
            case InputCode.PadLeftStickX:
            case InputCode.PadLeftStickDown:
            case InputCode.PadLeftStickUp:
            case InputCode.PadLeftStickLeft:
            case InputCode.PadLeftStickRight:
            case InputCode.PadRightStickY:
            case InputCode.PadRightStickX:
            case InputCode.PadRightStickDown:
            case InputCode.PadRightStickUp:
            case InputCode.PadRightStickLeft:
            case InputCode.PadRightStickRight:
                return true;
            default:
                return false;
        }
    }

    void Awake()
    {
        input = GetComponent<InputState>();
        
        
    }
    private void Start()
    {
        Debug.LogWarning(input.Devices);
    }


    void Update()
    {

        
       
    }
}

