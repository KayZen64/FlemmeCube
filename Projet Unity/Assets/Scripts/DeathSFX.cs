using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathSFX : MonoBehaviour
{

    public AudioSource laser;
    
    public void PlayDeathSFX(string tag)
    {
        Debug.Log(tag);
        switch(tag)
        {
            case "Laser":
                
                laser.Play();
                break;   
            
        }
    }
}
