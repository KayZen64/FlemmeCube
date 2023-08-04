using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPatate : MonoBehaviour
{
    public GameObject patate;
    public GameObject getPotatoText;

    public void GetPotato() 
    {
        getPotatoText.transform.localScale = new Vector3(1,1,1);
        patate.transform.localScale = new Vector3(0,0,0);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
