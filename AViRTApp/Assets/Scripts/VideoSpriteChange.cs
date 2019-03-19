using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class VideoSpriteChange : MonoBehaviour {

    Image videoToggle;
    //public bool videoState;
    public Sprite videoOn;
    public Sprite videoOff;
    public GameObject videoQuad;
    Renderer quadRend;

	// Use this for initialization
	void Start () {

        videoToggle = gameObject.GetComponent<Image>();
        quadRend = videoQuad.GetComponent<Renderer>();
        videoToggle.sprite = videoOff;
        quadRend.enabled = false;

    }
	

    public void videoSwap()
    {
        if(videoToggle.sprite.name == "video_off")
        {
            videoToggle.sprite = videoOn;
            quadRend.enabled = true;
        }
        else
        {
            videoToggle.sprite = videoOff;
            quadRend.enabled = false;
        }
    }

}
