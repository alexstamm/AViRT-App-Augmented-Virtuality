﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SmoothSlider : MonoBehaviour {

    public Slider slider;
    public Renderer video;

	// Use this for initialization
	void Start () {

        
        video.material.shader = Shader.Find("YUVShader");
    }
	
	// Update is called once per frame
	void Update () {

      

       video.material.SetFloat("_Smooth", slider.value);

    }
}
