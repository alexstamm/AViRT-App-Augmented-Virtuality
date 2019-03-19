using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CameraSwitch : MonoBehaviour {

    Image cameraSelect;
    //public bool videoState;
    public Sprite perspOne;
    public Sprite perspThree;

    public Camera camera1;
    public Camera camera2;

	// Use this for initialization
	void Start () {
        camera1.enabled = true;
        camera2.enabled = false;

        cameraSelect = gameObject.GetComponent<Image>();
        cameraSelect.sprite = perspOne;

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void CameraSwap()
    {
        if(camera1.enabled == true)
        {
            camera2.enabled = true;
            camera1.enabled = false;
            cameraSelect.sprite = perspThree;
        }
        else
        {
            camera2.enabled = false;
            camera1.enabled = true;
            cameraSelect.sprite = perspOne;
        }
    }

}
