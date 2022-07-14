using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static partial class Android_Data 
{
    public static string GET_SYSTEM_SERVICE = "getSystemService";

    //CLASS UNITY
    public static string AndroidJavaClass_UnityPlayer = "com.unity3d.player.UnityPlayer";
    public static AndroidJavaClass unityPlayer = new AndroidJavaClass(AndroidJavaClass_UnityPlayer);

    //OBJ CURRENT ACTIVITY
    public static string AndroidJavaObject_CurrentActivity = "currentActivity";
    public static AndroidJavaObject currentActivity = unityPlayer.GetStatic<AndroidJavaObject>(AndroidJavaObject_CurrentActivity);

    //OBJ CONTEXT
    public static string AndroidJavaObject_GetApplicationContext = "getApplicationContext";
    public static AndroidJavaObject context = unityPlayer.GetStatic<AndroidJavaObject>(AndroidJavaObject_GetApplicationContext);

    //CLASS BLUETOOTH ADAPTER => https://developer.android.com/guide/topics/connectivity/bluetooth/find-bluetooth-devices
    public static string AndroidJavaClass_BluetoothAdapter = "android.bluetooth.BluetoothAdapter";
    public static AndroidJavaClass bluetoothAdapter = new AndroidJavaClass(AndroidJavaClass_BluetoothAdapter);

    //OBJ BLUETOOTH CONNECTOR
    public static string AndroidJavaObject_BluetoothConnector = "getInstance";
    public static AndroidJavaObject bluetoothConnector = bluetoothAdapter.CallStatic<AndroidJavaObject>(AndroidJavaObject_BluetoothConnector);

    //OBJ WIFI
    public static string AndroidJavaObject_Wifi = "wifi";
    public static AndroidJavaObject wifi = currentActivity.Call<AndroidJavaObject>(GET_SYSTEM_SERVICE, AndroidJavaObject_BluetoothConnector);
}

/*
    var DevsSet = JavaObject.Call<AndroidJavaObject>("getBondedDevices");
    var DevsIter = DevsSet.Call<AndroidJavaObject>("iterator");
 */
