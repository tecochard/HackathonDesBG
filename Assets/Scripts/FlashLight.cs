using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{
    public Material InvisibleMat;
    public Material objectMat;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 6)
        {
            other.gameObject.GetComponent<Renderer>().material = objectMat;
        }
        else
        {
            Debug.Log(other.gameObject.layer);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == 6)
        {
            other.gameObject.GetComponent<Renderer>().material = InvisibleMat;
        }
    }
}
