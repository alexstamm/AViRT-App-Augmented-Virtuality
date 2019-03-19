using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Tango;

public class MotionTrackReset : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void MotionTrackResetFunction () {

		PoseProvider.ResetMotionTracking();
	}
}
