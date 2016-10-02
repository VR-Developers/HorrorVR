using UnityEngine;
using System.Collections;

public class FlashlightComponent : MonoBehaviour {

    /// <summary>
    /// We recieve a message from PlayerInputComponent script and we register an event listener
    /// which will call ToggleLight method when the user clicks
    /// The ToggleLight method just turns the light on/off depending on the current state
    /// The *_light* GameObject is the actual Flashlight called Light in the inspector
    /// </summary>


    void Start () {
	     init();
	}

    private void init()
    {
        _input = GameObject.Find("Player").GetComponent<PlayerInputComponent>();
        _input.ToggleFlashlight += ToggleLight;
    }

    private PlayerInputComponent _input;


    private void ToggleLight()
    {
       _isLightActive = !_isLightActive;
       _light.SetActive(_isLightActive);
    }

    [SerializeField] private GameObject _light;

    //TODO Change this to False in the final verson

    private bool _isLightActive = true;
    
}
