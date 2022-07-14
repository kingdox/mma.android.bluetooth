using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static partial class Android_Data 
{
    public struct BluetoothDevice
    {
        public string name;
        public string address;
        public BluetoothDevice(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
    }

}
