using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChromaKeyButton : MonoBehaviour {

    public GameObject panel;
    public bool chromaToggleState = false;

  //  public Renderer rend;
    public Shader YUVShader;

	// Use this for initialization
	void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void toggleChromaKeyPanel()
    {
        if(chromaToggleState == false)
        {
            panel.SetActive(true);
            chromaToggleState = true;
            //rend.material.shader = YUVShader;
            
        }
        else
        {
            panel.SetActive(false);
            chromaToggleState = false;
            
        }

    }

}
