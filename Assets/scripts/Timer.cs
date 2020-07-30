using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{

    float elapisedTime = 0, duration = 0;
    bool running = false, started = false;

    public float Duration
    {
        set
        {
            if (!running)
            {
                duration = value;
            }
        }
        get
        {
            return duration;
        }
    }

    public bool finished
    {
        get
        {
            return started && !running; 
        }
    }
    public bool Started
    {
        get
        {
            return started;
        }
        set
        {
            started = value;
        }
    }
    public float Elapised
    {
        get { return elapisedTime; }
    }
    public void Run()
    {
        if (!running)
        {
            elapisedTime = 0;
            started = true;
            running = true;
        }
    }
    public bool Running
    {
        get
        {
            return running;
        }
    }
    private void Update()
    {
        if (running)
        {
            elapisedTime += Time.deltaTime;
        }
        if (elapisedTime >= duration)
        {
            running = false;
        }
    }

}
