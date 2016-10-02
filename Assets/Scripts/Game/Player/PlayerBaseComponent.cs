using UnityEngine;
using System.Collections;

public class PlayerBaseComponent : MonoBehaviour {

    /// <summary>
    /// This is the base Player class, which updates the player's state by using external scripts
    /// Example : PlayerInputComponent, PlayerPhysicsComponent, PlayerRaycastingComponent, PlayerHealthComponent
    /// </summary>

	void Start () {
	
        init();
	}

    private void init()
    {
        _input = GetComponent<PlayerInputComponent>();
    }

    private PlayerInputComponent _input;

	void Update () {
	
        _input.UpdateInput();
	    
	}


}
