using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateHours : MonoBehaviour
{
    public GameObject pointerHours;
    private int rotationAngle;

    private void Start()
    {
        rotationAngle = 45;
    }
    void Update()
    {
        //-- draw pointers
        pointerHours.transform.localEulerAngles = new Vector3(0.0f, 0.0f, rotationAngle);
    }

    public void OnMouseDown()
    {
        rotationAngle += 45;
        if (rotationAngle > 315) { rotationAngle = 0; }
    }
}
