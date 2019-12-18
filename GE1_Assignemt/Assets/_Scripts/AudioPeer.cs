using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (AudioSource))]
public class AudioPeer : MonoBehaviour
{
    //Instantiate Audio source and split frequency spectrum into 512 bins
    //Make ststic so other scripts can access it
    AudioSource _audioSource;
    public static float[] _samples = new float[512];

    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        GetSpectrumAudioSource();
    }

    void GetSpectrumAudioSource()
    {
        //Use fftwindow.blackman to reduce leakage of spectrum data
        _audioSource.GetSpectrumData(_samples, 0, FFTWindow.Blackman);

    }
}
