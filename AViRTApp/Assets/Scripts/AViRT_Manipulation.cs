using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AViRT_Manipulation : MonoBehaviour {
	public float dist = 10f;
	public float rotate = 50f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void MoveForwardI(){
        transform.Translate(0, 0, dist * Time.deltaTime);
    }

	public void MoveBackward(){
        transform.Translate(0, 0, -dist * Time.deltaTime);
    }

	public void MoveLeft(){
        transform.Translate(dist * Time.deltaTime, 0, 0);
    }

	public void MoveRight(){
        transform.Translate(-dist * Time.deltaTime, 0, 0);
    }

	public void MoveClockwise(){
        transform.Rotate(0, rotate * Time.deltaTime, 0);
    }

	public void MoveCounterclock(){
        transform.Rotate(0, -rotate * Time.deltaTime, 0);
    }
}
