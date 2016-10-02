using System;
using UnityEngine;
using System.Collections;

public class PlayerInputComponent : MonoBehaviour
{
    /// <summary>
    /// The ToggleFlashLight event sends a message to the FlashlightComponent script
    /// to turn the light on/off, We handle the state of the light inside FlashlightComponent.cs
    /// </summary>


    public event Action ToggleFlashlight;


    public void UpdateInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
           
            ToggleFlashlight();

        }

    }

  


}
