using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Diagnostics;
using Debug = UnityEngine.Debug;

public class NewGame : MonoBehaviour
{
    public InputField input_nickname;
    public static string ch_name = "춘자";

    public void NewGameBtn()
    {
        Debug.Log("Hello World");
        ch_name = input_nickname.text;
    }
}