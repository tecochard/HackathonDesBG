using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TogglePassthrough : MonoBehaviour
{

    [SerializeField]
    BoxCollider collider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        print("collision");
        //OVRManager.instance.isInsightPassthroughEnabled = false;
    }
}
