using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static partial class Android_Function
{

    public static bool SetWifiEnabled(
        AndroidJavaObject wifi,
        bool enabled
    ){
        //using (AndroidJavaObject activity = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity"))
        //{
        //    try
        //    {
        //        using (var wifiManager = activity.Call<AndroidJavaObject>("getSystemService", "wifi"))
        //        {
        //            return wifiManager.Call<bool>("setWifiEnabled", enabled);
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //    }
        //}
        //return false;

        try
        {
            return wifi.Call<bool>("setWifiEnabled", enabled);
        }
        catch (Exception ex)
        {

        }
        return false;
    }
}
