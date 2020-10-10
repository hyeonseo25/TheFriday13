using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void moveStart()
    {
        SceneManager.LoadScene("SelectMode");
    }

    public void moveProLog()
    {
        SceneManager.LoadScene("Prolog_1");
    }
}
