using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudiCubes : MonoBehaviour
{
    public GameObject _sampleCubePrefab;
    private GameObject[] _sampleCubes = new GameObject[512];
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 512; i++)
        {
            GameObject _instanceCube = (GameObject)Instantiate(_sampleCubePrefab);
            //make instance spawn at center of 'spawner'
            _instanceCube.transform.position = this.transform.position;
            _instanceCube.transform.parent = this.transform;
            _instanceCube.name = "ParmetricCube" + i;

            //Want to make a circle 360 degrees / 512 boxes = .703125 degrees per box
            this.transform.eulerAngles = new Vector3(0, (-0.703125f * i), 0);
            _instanceCube.transform.position = Vector3.forward * 100;

            //set sample cube objects in list so we can 'talk' to it from the update
            _sampleCubes[i] = _instanceCube;
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 512; i++)
        {

        }
    }
}
