using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyboardManager : MonoBehaviour
{

    private TouchScreenKeyboard keyboard;
    public static string Keyboardtext = "";

    public void OpenKeyboard()
    {
        keyboard = TouchScreenKeyboard.Open("",TouchScreenKeyboardType.Default);
    }
}
