using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerControllers : MonoBehaviour
{
    //all code here is for starting and stopping scripts and GOs at specific points in the song
    public GameObject camera;
    public GameObject visualiser;
    public GameObject tunnel;
    public GameObject innertunnel;
    public GameObject square;
    public GameObject triangle;
    public GameObject circle1;
    public GameObject circle2;
    public GameObject visualiser2;
    private bool neverdone = true;
    private bool neverdone2 = true;
    private bool neverdone3 = true;
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
            if (neverdone)
            {
                camera.transform.rotation = new Quaternion(0, 0, 0, 0);
                neverdone = false;
            }
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
            triangle.GetComponent<Phyllotaxis>().enabled = false;
        }
        if (Time.realtimeSinceStartup >= 83)
        {
            circle1.GetComponent<Phyllotaxis>().enabled = false;
        }
        if (Time.realtimeSinceStartup >= 83)
        {
            circle2.GetComponent<Phyllotaxis>().enabled = false;
        }

        if (Time.realtimeSinceStartup >= 90)
        {
            innertunnel.SetActive(false);
            camera.GetComponent<PhylloTunnel>().enabled = false;
            camera.GetComponent<Rotation>().enabled = false;
            if (neverdone2)
            {
                camera.transform.position = new Vector3(0, 0, -2044.3f);
                camera.transform.rotation = new Quaternion(90.0f, 0, 0, 0);
                visualiser2.SetActive(true);


                camera.transform.rotation = new Quaternion(10.0f, 0, 0, 0);

                neverdone2 = false;
            }

            camera.GetComponent<Rotator2>().enabled = true;

        }

        if (Time.realtimeSinceStartup >= 95)
        {
            if (neverdone3)
            {
                camera.transform.rotation = new Quaternion(35, 0, 0, 0);
                neverdone3 = false;
            }
            camera.transform.rotation = new Quaternion(35, 0, 0, 0);
            square.GetComponent<Phyllotaxis>().enabled = true;
            triangle.GetComponent<Phyllotaxis>().enabled = true;
            circle1.GetComponent<Phyllotaxis>().enabled = true;
            circle2.GetComponent<Phyllotaxis>().enabled = true;
            camera.GetComponent<Rotator2>().enabled = false;
        }
    }
}
