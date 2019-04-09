using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioButton : MonoBehaviour
{
    AudioSource my_AudioSource;


    // Start is called before the first frame update
    void Start()
    {
        my_AudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayAudio()
    {
        my_AudioSource.Play();
    }
}
