using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WorldSpriteChange : MonoBehaviour {
	
	Image worldToggle;
	//public bool videoState;
	public Sprite worldOn;
	public Sprite worldOff;

	
	// Use this for initialization
	void Start () {
		
		worldToggle = gameObject.GetComponent<Image>();
		worldToggle.sprite = worldOn;

		
	}
	
	
	public void worldSwap()
	{
		if(worldToggle.sprite.name == "virtual_world_off")
		{
			worldToggle.sprite = worldOn;

		}
		else
		{
			worldToggle.sprite = worldOff;
		
		}
	}
	
}