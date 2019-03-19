using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChromaChange : MonoBehaviour {

	public Renderer rend;
	public float ChromaSensitivity = 0.5f;
	public float ChromaSmoothing = 0.5f;

	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();
		rend.material.shader = Shader.Find ("YUVShader");
	}

	// Update is called once per frame
	void Update () {
		rend.material.SetFloat ("_Sensitivity", ChromaSensitivity);
		rend.material.SetFloat ("_Smooth", ChromaSmoothing);
	}

	public void SendSensitivity(float newSens){
		ChromaSensitivity = newSens;
	}

	public void SendSmoothing(float newSmoo){
		ChromaSmoothing = newSmoo;
	}

	//public void chromaDropped
}
