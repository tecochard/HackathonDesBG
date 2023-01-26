using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomGrabber : MonoBehaviour
{

    OVRInput.Controller m_controller;
    float grabAxis;
    float triggerAxis;
    bool isGrab;
    bool isTrigger;
    Collider grabbedCollider;
    

    public enum Hand
    {
        Left,
        Right
    };

    public Hand hand ;



    //The list of colliders currently inside the trigger
    //var TriggerList : List.<Collider> = new List.<Collider>();

    List<Collider> colliderList = new List<Collider>();

    //called when somet$$anonymous$$ng enters the trigger


    // Start is called before the first frame update
    void Start()
    {
        m_controller = hand == Hand.Left ? OVRInput.Controller.LTouch : OVRInput.Controller.RTouch;

        grabAxis = 0;
        triggerAxis = 0;
        isGrab = false;
        isTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        //print("Trigger " + hand.ToString() + ": " + OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger, m_controller));
        //print("Grip " + hand.ToString() + ": " + OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, m_controller));

        grabAxis = OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, m_controller);
        triggerAxis = OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger, m_controller);

        if (grabAxis > 0.5 && !isGrab)
        {
            Grab();
        }
        else if (grabAxis < 0.3 && isGrab)
        {
            ReleaseGrab();
        }

        if (triggerAxis > 0.5 && !isGrab)
        {
            Trigger();
        }
        else if (triggerAxis < 0.3 && isGrab)
        {
            RealeaseTrigger();
        }
    }

    void Grab()
    {
        if (colliderList.Count>0)
        {
            grabbedCollider = colliderList[0];
            grabbedCollider.GetComponent<CustomGrabbable>().Grab(transform);
            isGrab = true;
        }
        
    }
    void ReleaseGrab()
    {
        if(grabbedCollider != null)
        {
            grabbedCollider.GetComponent<CustomGrabbable>().ReleaseGrab();
            grabbedCollider = null;
            isGrab = false;
        }
        
    }
    void Trigger()
    {

    }
    void RealeaseTrigger()
    {

    }


    private void OnTriggerEnter(Collider other)
    {
        //if the object is not already in the list
        if (!colliderList.Contains(other) && other.gameObject.GetComponent<CustomGrabbable>() != null)
        {
            //add the object to the list
            colliderList.Add(other);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //if the object is in the list
        if (colliderList.Contains(other))
        {
            //remove it from the list
            colliderList.Remove(other);
        }
    }

}
