using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using System.Diagnostics;
using Debug = UnityEngine.Debug;

public class NewGame : MonoBehaviour
{
    public InputField input_nickname;
    public string ch_name = "미춘자";

    void NewGameBtn()
    {
        Debug.Log("Hello World");
        StartCoroutine(NewGameGo());
    }

    IEnumerator NewGameGo()
    {
        ch_name = input_nickname.text;
        Debug.Log(ch_name);
        yield return null;
    }
    
}
