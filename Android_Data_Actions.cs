using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static partial class Android_Data 
{

    public static readonly string[] ConstantValues_Actions =
        {
            "None", //dummy, not set. (*Do not change index:[0])

            //https://developer.android.com/reference/android/content/Intent.html#ACTION_VIEW
            "android.intent.action.VIEW",
            "android.intent.action.EDIT",
            "android.intent.action.WEB_SEARCH",
            "android.intent.action.SEND",
            "android.intent.action.SENDTO",
            "android.intent.action.CALL_BUTTON",
            "android.intent.action.DIAL",
            "android.intent.action.SET_WALLPAPER",
            "android.intent.action.MANAGE_NETWORK_USAGE",
            "android.intent.action.POWER_USAGE_SUMMARY",

            //https://developer.android.com/reference/android/provider/Settings.html#ACTION_ACCESSIBILITY_SETTINGS
            "android.settings.ACCESSIBILITY_SETTINGS",
            "android.settings.ADD_ACCOUNT_SETTINGS",
            "android.settings.AIRPLANE_MODE_SETTINGS",
            "android.settings.APN_SETTINGS",
            "android.settings.APPLICATION_DETAILS_SETTINGS",
            "android.settings.APPLICATION_DEVELOPMENT_SETTINGS",
            "android.settings.APPLICATION_SETTINGS",
            "android.settings.APP_NOTIFICATION_SETTINGS",   //API 26
            "android.settings.BATTERY_SAVER_SETTINGS",      //API 22
            "android.settings.BLUETOOTH_SETTINGS",
            "android.settings.CAPTIONING_SETTINGS",         //API 19
            "android.settings.CAST_SETTINGS",               //API 21
            "android.settings.CHANNEL_NOTIFICATION_SETTING",//API 26
            "android.settings.DATA_ROAMING_SETTINGS",
            "android.settings.DATE_SETTINGS",
            "android.settings.DEVICE_INFO_SETTINGS",
            "android.settings.DEVICE_INFO_SETTINGS",
            "android.settings.DREAM_SETTINGS",              //API 18
            "android.settings.HARD_KEYBOARD_SETTINGS",      //API 24
            "android.settings.HOME_SETTINGS",               //API 21
            "android.settings.IGNORE_BACKGROUND_DATA_RESTRICTIONS_SETTINGS",//API 24
            "android.settings.IGNORE_BATTERY_OPTIMIZATION_SETTINGS",        //API 23
            "android.settings.INPUT_METHOD_SETTINGS",
            "android.settings.INPUT_METHOD_SUBTYPE_SETTINGS",
            "android.settings.INTERNAL_STORAGE_SETTINGS",
            "android.settings.LOCALE_SETTINGS",
            "android.settings.LOCATION_SOURCE_SETTINGS",
            "android.settings.MANAGE_ALL_APPLICATIONS_SETTINGS",
            "android.settings.MANAGE_APPLICATIONS_SETTINGS",
            "android.settings.MANAGE_DEFAULT_APPS_SETTINGS",    //API 24
            "android.settings.action.MANAGE_OVERLAY_PERMISSION",//API 23
            "android.settings.MANAGE_UNKNOWN_APP_SOURCES",      //API 26
            "android.settings.action.MANAGE_WRITE_SETTINGS",    //API 23
            "android.settings.MEMORY_CARD_SETTINGS",
            "android.settings.NETWORK_OPERATOR_SETTINGS",
            "android.settings.NFCSHARING_SETTINGS",
            "android.settings.NFC_PAYMENT_SETTINGS",        //API 19
            "android.settings.NFC_SETTINGS",
            "android.settings.NIGHT_DISPLAY_SETTINGS",      //API 26
            "android.settings.ACTION_NOTIFICATION_LISTENER_SETTINGS",   //API 22
            "android.settings.NOTIFICATION_POLICY_ACCESS_SETTINGS",     //API 23
            "android.settings.ACTION_PRINT_SETTINGS",       //API 19
            "android.settings.PRIVACY_SETTINGS",
            "android.settings.QUICK_LAUNCH_SETTINGS",
            "android.search.action.SEARCH_SETTINGS",
            "android.settings.SECURITY_SETTINGS",
            "android.settings.SETTINGS",
            "android.settings.SHOW_REGULATORY_INFO",        //API 21
            "android.settings.SOUND_SETTINGS",
            "android.settings.SYNC_SETTINGS",
            "android.settings.USAGE_ACCESS_SETTING",        //API 21
            "android.settings.USER_DICTIONARY_SETTINGS",
            "android.settings.VOICE_INPUT_SETTINGS",        //API 21
            "android.settings.VPN_SETTINGS",                //API 24
            "android.settings.VR_LISTENER_SETTINGS",        //API 24
            "android.settings.WEBVIEW_SETTINGS",            //API 24
            "android.settings.WIFI_IP_SETTINGS",
            "android.settings.WIFI_SETTINGS",
            "android.settings.WIRELESS_SETTINGS",
            "android.settings.ZEN_MODE_PRIORITY_SETTINGS",  //API 26
        };
}
