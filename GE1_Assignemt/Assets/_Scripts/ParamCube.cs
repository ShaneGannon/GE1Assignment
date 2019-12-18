﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParamCube : MonoBehaviour
{
    public int _band;
    public float _startScale, _ScaleMultiplier;
    public bool _useBuffer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_useBuffer)
        {
            transform.localScale = new Vector3(transform.localScale.x, (AudioPeer._bandBuffer[_band] * _ScaleMultiplier) + _startScale, transform.localScale.z);
        }

        if (!_useBuffer)
        {
            transform.localScale = new Vector3(transform.localScale.x, (AudioPeer._freqBand[_band] * _ScaleMultiplier) + _startScale, transform.localScale.z);
        }
    }
}
