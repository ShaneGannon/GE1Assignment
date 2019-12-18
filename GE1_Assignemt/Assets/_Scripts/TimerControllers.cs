﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerControllers : MonoBehaviour
{
    public GameObject camera;
    public GameObject visualiser;
    public GameObject tunnel;
    public GameObject innertunnel;
    public GameObject square;
    public GameObject triangle;
    public GameObject circle1;
    public GameObject circle2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.realtimeSinceStartup >= 9)
        {
            camera.GetComponent<Rotator2>().enabled = false;
            visualiser.SetActive(true);
        }

        if (Time.realtimeSinceStartup >= 28)
        {
            camera.GetComponent<Rotation>().enabled = true;
            tunnel.SetActive(true);
        }

        if (Time.realtimeSinceStartup >= 40.8)
        {
            camera.GetComponent<Rotation>().enabled = false;
        }

        if (Time.realtimeSinceStartup >= 48)
        {
            camera.GetComponent<PhylloTunnel>().enabled = true;
        }

        if (Time.realtimeSinceStartup >= 62)
        {
            camera.GetComponent<Rotation>().enabled = true;
        }

        if (Time.realtimeSinceStartup >= 62)
        {
            innertunnel.SetActive(true);
        }

        if (Time.realtimeSinceStartup >= 77)
        {
            square.GetComponent<Phyllotaxis>().enabled = false;
        }
        if (Time.realtimeSinceStartup >= 80)
        {
            square.GetComponent<Phyllotaxis>().enabled = false;
        }
        if (Time.realtimeSinceStartup >= 83)
        {
            square.GetComponent<Phyllotaxis>().enabled = false;
        }
        if (Time.realtimeSinceStartup >= 83)
        {
            square.GetComponent<Phyllotaxis>().enabled = false;
        }
    }
}