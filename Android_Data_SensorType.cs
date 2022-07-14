using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static partial class Android_Data 
{

    [Serializable]
    public enum SensorType
    {
        None = 0,                           //(dummy, not set)
        Accelerometer = 1,                  //[m/s^2] (≒ Input.acceleration * -10)
        MagneticField = 2,                  //[uT] (= Input.compass.rawVector)
        Orientation = 3,                    //[degree] (deprecated in API level 20
        Gyroscope = 4,                      //[rad/s]
        Light = 5,                          //[lux]
        Pressure = 6,                       //[hPa]
        Proximity = 8,                      //[cm]
        Gravity = 9,                        //[m/s^2]
        LinearAcceleration = 10,            //[m/s^2] (= Accelerometer - Gravity)
        RotationVector = 11,                //[vector] (*[0]~[2]:API 9, [3][4]:API 18 or higher)
        RelativeHumidity = 12,              //[%] (*API 20 or higher)
        AmbientTemperature = 13,            //[℃]
        MagneticFieldUncalibrated = 14,     //[uT] (*API 18 or higher)
        GameRotationVector = 15,            //[vector] (*API 18 or higher)
        GyroscopeUncalibrated = 16,         //[rad/s] (*API 18 or higher)
        SignificantMotion = 17,             //[1 only] (*API 18 or higher)
        StepDetector = 18,                  //[1 only] (*API 19 or higher)
        StepCounter = 19,                   //[steps (system boot)] (*API 19 or higher)
        GeomagneticRotationVector = 20,     //[vector] (*API 19 or higher)
        HeartRate = 21,                     //[bpm](*API 20 or higher. Required permission：'android.permission.BODY_SENSORS')
        Pose6DOF = 28,                      //[quaternion, translation] (*API 24 or higher)
        StationaryDetect = 29,              //[1 only] (*API 24 or higher)
        MotionDetect = 30,                  //[1 only] (*API 24 or higher)
        HeartBeat = 31,                     //[confidence=0~1] (*API 24 or higher)
        LowLatencyOffbodyDetect = 34,       //[0 (device is off-body) or 1 (device is on-body)] (*API 26 or higher) 
        AccelerometerUncalibrated = 35,     //[m/s^2] (*API 26 or higher)
    }
}
