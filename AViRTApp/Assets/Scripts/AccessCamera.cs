using UnityEngine;
using System.Collections;

public class AccessCamera : MonoBehaviour {

    public WebCamTexture webcamTexture;
    public Shader shader1;


	// Use this for initialization
	void Start () {



        webcamTexture = new WebCamTexture();
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.mainTexture = webcamTexture;
        renderer.material.shader = shader1;

        webcamTexture.requestedHeight = 720;
        webcamTexture.requestedWidth = 1080;
        webcamTexture.requestedFPS = 24;
        webcamTexture.Play();

    }
	
	// Update is called once per frame
	void Update () {
	
	}


}
