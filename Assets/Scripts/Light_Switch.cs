using UnityEngine;
using System.Collections;

public class Light_Switch : MonoBehaviour {

	public GameObject flashlight;
	public bool flashlight_state = false;
	// Use this for initialization
	void Start () 
	{
		flashlight.SetActive (false);
		flashlight_state = true;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetMouseButtonUp(0)) // OR CARDBOARD TRIGGER
		{
			Debug.Log ("Toggle Light");
			flashlight_state = !flashlight_state;
			flashlight.SetActive (flashlight_state);
		}
	}
}
