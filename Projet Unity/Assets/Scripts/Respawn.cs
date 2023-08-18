using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] private Transform respawnPoint;
    [SerializeField] private DeathSFX deathSFX;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Laser")
        {
            deathSFX.PlayDeathSFX(other.gameObject.tag);
            transform.position = respawnPoint.transform.position;
        }
        
        else if (other.gameObject.tag == "Respawn") {
            transform.position = respawnPoint.transform.position;
        }
    }

}
