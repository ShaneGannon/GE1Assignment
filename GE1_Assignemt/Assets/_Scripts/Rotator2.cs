using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(-0.2f, 0, 0);
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 0.05f);
        
    }
}
