using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldSwitch : MonoBehaviour
{
    public GameObject enableTargetObject;
    public GameObject disableTargetObject;
    public string triggertag;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(triggertag))
        {   
            enableTargetObject.gameObject.SetActive(false);
            disableTargetObject.gameObject.SetActive(true);
            
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag(triggertag))
        {
            enableTargetObject.gameObject.SetActive(true);
            disableTargetObject.gameObject.SetActive(false);
            
        }
    }

    
}
