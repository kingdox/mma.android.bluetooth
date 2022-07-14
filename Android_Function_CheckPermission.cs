using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static partial class Android_Function
{

    public static bool CheckPermission(
        AndroidJavaObject context,
        AndroidJavaObject bluetooth,
        string method_checkPermission,
        string permission
    )
    {
        //using AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        //using AndroidJavaObject context = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
        //using AndroidJavaObject bluetooth = context.Call<AndroidJavaObject>("getSystemService", "bluetooth");
        return bluetooth.CallStatic<bool>(
            method_checkPermission ?? "checkPermission", //TODO
            context,
            permission
        );
    }
}
