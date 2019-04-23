using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrequencyAnalyzer : MonoBehaviour
{  
    float[] freqData;
    int nSamples = 1024;
    float fMax;
    

    void Start()
    {
        freqData = new float[nSamples];
        fMax = AudioSettings.outputSampleRate / 2;
    }

    void Update()
    {
        GetFrequency(560, 650);
    }

    public float GetFrequency(float fLow, float fHigh)
    {
        fLow = Mathf.Clamp(fLow, 20, fMax); // limit low...
        fHigh = Mathf.Clamp(fHigh, fLow, fMax); // and high frequencies

        // get spectrum
        AudioListener.GetSpectrumData(freqData, 0, FFTWindow.BlackmanHarris); 
        int n1 = (int)Mathf.Floor(fLow * nSamples / fMax);
        int n2 = (int)Mathf.Floor(fHigh * nSamples / fMax);
        float sum = 0.0f;

        // average the volumes of frequencies fLow to fHigh
        for (int i = n1; i <= n2; i++)
        {
            sum += freqData[i];
        }

        print(sum / (n2 - n1 + 1));
        return sum / (n2 - n1 + 1);
    }

}
