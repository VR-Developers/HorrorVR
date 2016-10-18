using UnityEngine;
using System.Collections;

public class Light_Energy : MonoBehaviour {

	Material[] energy_bar_material;

	// Use this for initialization
	void Start () 
	{
		energy_bar_material = GetComponent<MeshRenderer> ().materials;
       
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.Alpha4)) {
			SetRemainingLights (4);
           
		}

		if (Input.GetKeyDown(KeyCode.Alpha3)) {
			SetRemainingLights (3);
		}

		if (Input.GetKeyDown(KeyCode.Alpha2)) {
			SetRemainingLights (2);
		}

		if (Input.GetKeyDown(KeyCode.Alpha1)) {
			SetRemainingLights (1);
		}
	}

	public void SetRemainingLights(int remaining_lights)
	{
		switch (remaining_lights) 

		{
			case 4:
			energy_bar_material[0].SetTextureOffset ("_MainTex", new Vector2 (0, 0.75f));
             
			break;

			case 3:
			energy_bar_material[0].SetTextureOffset ("_MainTex", new Vector2 (0, 0.5f));
			break;

			case 2:
			energy_bar_material[0].SetTextureOffset ("_MainTex", new Vector2 (0, 0.25f));
			break;

			case 1:
			energy_bar_material[0].SetTextureOffset ("_MainTex", new Vector2 (0, 0));
			break;

		default:
			break;
		}
	}

}
