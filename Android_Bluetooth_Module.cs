#region Access
using System;
using System.Collections;
using System.Collections.Generic;
using Unity;
using UnityEngine;
#endregion
namespace MMA.Android_Bluetooth
{
    public static class Key
    {
        // public const string _   = KeyData._;
        public static string Initialize = "Android_Bluetooth_Initialize";
        public static string GetNearestDevices = "Android_Bluetooth_GetNearestDevices";
        public static string TryConnect = "Android_Bluetooth_TryConnect";
        public static string TryDisconnect = "Android_Bluetooth_TryDisConnect";
        public static string WriteData = "Android_Bluetooth_WriteData";
        public static string ReadData = "Android_Bluetooth_ReadData";
        public static string OnStatusConnection = "Android_Bluetooth_OnStatusConnection";
    }
    public static class Import
    {
        //public const string _ = _;
    }

    //TODO Poner en MMA.Android
    public static class Android
    {
        
    }

    public static class Bluetooth
    {
        /* Set this in Manifest
            <uses-permission android:name="android.permission.BLUETOOTH" />
            <uses-permission android:name="android.permission.BLUETOOTH_ADMIN" />
            <uses-permission android:name="android.permission.BLUETOOTH_PRIVILEGED" />
         */

        //public const string ANDROID_PACKAGE = "-";
        //public const string ANDROID_SYSTEM = ANDROID_PACKAGE + ".AndroidSystem";
        //public const string ANDROID_HARDKEY = ANDROID_PACKAGE + ".AndroidHardKey";
        //static var a = mAndroidHardKey = new AndroidJavaClass(ANDROID_HARDKEY);

#if UNITY_ANDROID && !UNITY_EDITOR
        public static AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        public static AndroidJavaObject currentActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
        public static AndroidJavaObject bluetooth = currentActivity.Call<AndroidJavaObject>("getSystemService", "bluetooth");
        //public static AndroidJavaObject vibrator = currentActivity.Call<AndroidJavaObject>("getSystemService", "vibrator");
        //private static AndroidJavaObject bluetooth = new AndroidJavaObject("jp.android.plugins.bluetooth.BluetoothPlugins", currentActivity);
#else
    public static AndroidJavaClass unityPlayer;
    public static AndroidJavaObject currentActivity;
    public static AndroidJavaObject vibrator;
    public static AndroidJavaObject bluetooth;
#endif
        public static bool bluetoothSupport() => bluetooth.CallStatic<bool>("bluetoothSupport");

        public static bool currentState() => bluetooth.CallStatic<bool>("currentState");

        public static void stateChange(bool value, bool forcing) => bluetooth.CallStatic("stateChange", value, forcing);

        public static string[] getPairedDevices() => bluetooth.CallStatic<string[]>("getPairedDevices");

        public static string[] getNotPairedDevices() => bluetooth.CallStatic<string[]>("getNotPairedDevices");
    }
    public sealed partial class Android_Bluetooth_Module : Module
    {
        #region References
        //[Header("Applications")]
        //[SerializeField] public ApplicationBase interface_Bluetooth;



        #endregion
        #region Reactions ( On___ )
        // Contenedor de toda las reacciones del Bluetooth
        protected override void OnSubscription(bool condition)
        {
            //

            //Abre el puerto
            System.IO.Ports.SerialPort port = new System.IO.Ports.SerialPort("", 1);
            port.Open();
            port.WriteBufferSize = 8; //bytes
            port.Write("Hola");
        }
        #endregion
        #region Methods
        // Contenedor de toda la logica del Bluetooth

        private void TestBluetooth()
        {
        }
        #endregion
        #region Request ( Coroutines )
        // Contenedor de toda la Esperas de corutinas del Bluetooth
        #endregion
        #region Task ( async )
        // Contenedor de toda la Esperas asincronas del Bluetooth
        #endregion
    }
}