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
    public static float[] _freqBand = new float[8];

    //init buffer
    public static float[] _bandBuffer = new float[8];
    private float[] _bufferDecrease = new float[8];

    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        GetSpectrumAudioSource();
        MakeFreqBand();
        BandBuffer();
    }

    void GetSpectrumAudioSource()
    {
        //Use fftwindow.blackman to reduce leakage of spectrum data
        _audioSource.GetSpectrumData(_samples, 0, FFTWindow.Blackman);

    }

    void BandBuffer()
    {
        for (int g = 0; g < 8; g++)
        {
            if(_freqBand [g] > _bandBuffer [g])
            {
                _bandBuffer[g] = _freqBand[g];
                _bufferDecrease[g] = 0.005f;
            }

            if (_freqBand[g] < _bandBuffer[g])
            {
                //Here bufferdecrease will get higher to ensure band Cube falls down faster
                _bandBuffer [g] -= _bufferDecrease[g];
                _bufferDecrease[g] *= 1.2f;
            }
        }
    }

    void MakeFreqBand()
    {
        /* song plays at 22050hz / 512 samples = 43hz per sample
         * below is a standard 7 band eq breakdown
         * 20-60 sub bass
         * 60-250 bass
         * 250-500 low mid
         * 500-2000 mid
         * 2000-4000 high mid
         * 4000-6000 low treble
         * 6000-20000 treble
         * 
         * to create 8 bands we use these
         * 0 - 2 * 43 = 86 ----- range = 0-86hz
         * 1 - 4 * 43 = 172 ----- range = 87-258hz
         * 2 - 8 * 43 = 344 ----- range = 259-603hz
         * 3 - 16 * 43 = 688 ----- range = 603-1290hz
         * 4 - 32 * 43 = 1376 ----- range = 1291-2666hz
         * 5 - 64 * 43 = 2752 ----- range = 2667-5418hz
         * 6 - 128 * 43 = 5504 ----- range = 5419-10922hz
         * 7 - 256 * 43 = 11008 ----- range = 10923-21930hz
         * this use 510 samples we will add the last 2 to add to the last one as its usually the weakest range
         */

        int counter = 0;

        for (int i = 0; i < 8; i++)
        {
            float average = 0;
            int sampleCount = (int)Mathf.Pow(2, i) * 2;

            if (i == 7)
            {
                sampleCount += 2;
            }

            for (int j = 0; j < sampleCount; j++)
            {
                average += _samples[counter] * (counter = 1);
                counter++;

                average /= counter;

                _freqBand[i] = average * Random.Range(5, 15);
            }

        }
    }
}
