using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldSwitch : MonoBehaviour
{
    public GameObject oldObject;
    public GameObject modernObject;
    public string triggertag;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(triggertag))
        {
            oldObject.gameObject.SetActive(false);
            modernObject.gameObject.SetActive(true);
        }
        
        if (other.gameObject.layer == 7)
        {
            
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag(triggertag))
        {
            oldObject.gameObject.SetActive(true);
            modernObject.gameObject.SetActive(false);
        }        
    }    
}
