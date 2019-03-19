using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonLimit : MonoBehaviour {
	
	public Text screenconsole;
	bool videoState;
	bool worldState;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Attach to toggles, affects new variable not toggle itself
	public void SetStateWorld(){
		if(videoState == true){
			videoState = false;
		}
		else{
			videoState = true;
		}
	}

	public void SetStateVideo(){
		if(videoState == true){
			videoState = false;
		}
		else{
			videoState = true;
		}
	}

	//Attach one to button
	public void StateCamMsg (){
		if(videoState == false){
			screenconsole.text = "Please turn on Camera before utilizing Chroma Key tools";
			Debug.Log ("World is Off");
		}
		else{
			screenconsole.text = "";
			Debug.Log ("World is On");
			//Insert instructions
		}
	}

	public void StateWorldMsg(){
		if(worldState == false){
			screenconsole.text = "Please turn on Virtual Environment before utilizing Manipulation tools";
            Debug.Log("Video is Off");
		}
		else{
			screenconsole.text = "";
            Debug.Log("Video is On");
			//Insert instructions
		}
	}

}
