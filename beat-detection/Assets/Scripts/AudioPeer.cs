using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (AudioSource))]
public class AudioPeer : MonoBehaviour
{
    AudioSource _audioSource;
    public static float[] _samples = new float[512];
    public static float[] _freqBand = new float[8];
    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
        GetSpectrumAudioSource ();
        MakeFrequencyBands();
    }
    void GetSpectrumAudioSource()
    {
        _audioSource.GetSpectrumData (_samples, 0, FFTWindow.Blackman);
    }
    void MakeFrequencyBands()
    {
        float average = 0;
        int count = 0;
        for (int i =0; i < 8; i++)
        {
            int sampleCount = (int)Mathf.Pow (2, i) * 2;
            if (i == 7)
            {
                sampleCount += 2;
            }
            for (int j = 0; j < sampleCount; j++)
            {
                average += _samples[count] * (count + 1);
                    count++;
            }
            average /= count;

            _freqBand[i] = average * 10;
        }
    }
}
