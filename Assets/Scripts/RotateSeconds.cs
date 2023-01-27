using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSeconds : MonoBehaviour
{
    public GameObject pointerSeconds;
    private int rotationAngle;

    private void Start()
    {
        rotationAngle = 180;
    }
    void Update()
    {
        //-- draw pointers
        pointerSeconds.transform.localEulerAngles = new Vector3(0.0f, 0.0f, rotationAngle);
    }

    public void OnMouseDown()
    {
        rotationAngle += 45;
        if (rotationAngle > 315) { rotationAngle = 0; }
    }
}
