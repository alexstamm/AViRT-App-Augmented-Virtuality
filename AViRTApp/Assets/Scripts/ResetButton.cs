using UnityEngine;
using System.Collections;
using Tango;

public class ResetButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ResetMotionTracking()
    {

        PoseProvider.ResetMotionTracking();
    }

}
