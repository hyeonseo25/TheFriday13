using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Diagnostics;
using Debug = UnityEngine.Debug;

public class TestSC : MonoBehaviour
{
    float timer;
    int waitingTime;
    public Button Next;
    bool inside = true;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0.0f;
        waitingTime = 3;
        inside = false;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > waitingTime)
        {
            //Action
            timer = 0.0f;
        }
    }
}
