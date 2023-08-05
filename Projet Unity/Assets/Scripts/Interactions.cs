using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactions : MonoBehaviour
{
    public GameObject lasers;
    public Invisibility invisibilityComponent;

    public bool isInRange;
    
   // Update is called once per frame
    void Update()
    {
        if(isInRange && !invisibilityComponent.isInvEnabled) 
        {
            lasers.SetActive(true);
        }

        else if(isInRange && invisibilityComponent.isInvEnabled || !isInRange)
        {
            lasers.SetActive(false);
        }
    }
    

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Player")
        {
            isInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if(other.gameObject.tag == "Player")
        {
            isInRange = false;
        }
    }
}