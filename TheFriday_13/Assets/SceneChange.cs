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

    public void moveProLog2()
    {
        SceneManager.LoadScene("Prolog_2");
    }

    public void moveProLog3()
    {
        SceneManager.LoadScene("Prolog_3");
    }
}
