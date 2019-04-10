using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeModifier : MonoBehaviour
{
    public AudioSource button1Audio;
    // Material cubeMaterial;
    // Color altColor = Color.black;
    // Renderer rend;
    // [Range(1, 100)] public float intensity = 100;
	// [Range(64, 8192)] public int numberOfSamples = 1024; //step by 2
	// public FFTWindow fftWindow;
	// public float lerpTime = 1;


    void Start()
    {
        // cubeMaterial = GetComponent<Material>();
        // //Get the renderer of the object so we can access the color
        // rend = GetComponent<Renderer>();
    }

     void Update()
    {
        // ChangeColor();
        // ChangeShape();
    }















    // private void ChangeColor()
    // {
    //     //Alter the color
    //     altColor.g += button1Audio.volume;
    //     //Assign the changed color to the material.
    //     rend.material.color = altColor;
    // }

    // private void ChangeShape()
    // {
    //     // initialize our float array
	// 	float[] spectrum = new float[numberOfSamples];

	// 	// populate array with fequency spectrum data
	// 	button1Audio.GetSpectrumData(spectrum, 0, fftWindow);

    //     // calculate object's scale
    //     float lerpY = Mathf.Lerp(transform.localScale.y,intensity,lerpTime);
    //     Vector3 newScale = new Vector3(transform.localScale.x, lerpY, transform.localScale.z);

    //     // appply new scale to object
    //     transform.localScale = newScale;
    // }
}