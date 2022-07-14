using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static partial class Android_Data 
{
    [Serializable]
    public enum SensorDelay
    {
        Fastest = 0,    //0ms [*Not recommended as it will result in high load]
        Game = 1,    //20ms (50fps)
        UI = 2,    //66.6ms (15fps)
        Normal = 3,    //200ms (5fps) [*Recommended]
    }

}
