using UnityEngine;
using System.Collections;

public class WebCamDisplay : MonoBehaviour {

    public Shader chromaShader;
    
    public Renderer rend;
 

    public WebCamTexture webcamTexture;

	// Use this for initialization
	void Start () {

      

        webcamTexture = new WebCamTexture();
        rend = GetComponent<Renderer>();
        rend.material.mainTexture = webcamTexture;
        rend.material.shader = chromaShader;

        rend.material.shader = Shader.Find("YUVShader");

        webcamTexture.requestedWidth = 1080;
        webcamTexture.requestedHeight = 720;
        webcamTexture.requestedFPS = 30;
        webcamTexture.Play();


    }
	
	// Update is called once per frame
	void Update () {

        //rend.material.SetColor("_MaskCol", color);
            
    }

    public void getChromaColor()
    {
        
        if (Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Color color;
            Vector2 pos = Input.GetTouch(0).position;
            color = webcamTexture.GetPixel((int)pos.x, (int)pos.y);
            rend.material.SetColor("_MaskCol", color);
        }
    }


}
