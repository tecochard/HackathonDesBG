using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMinutes : MonoBehaviour
{
    public GameObject pointerMinutes;
    private int rotationAngle;

    private void Start()
    {
        rotationAngle = 315;
    }
    void Update()
    {
        //-- draw pointers
        pointerMinutes.transform.localEulerAngles = new Vector3(0.0f, 0.0f, rotationAngle);
    }

    public void OnMouseDown()
    {
        rotationAngle += 45;
        if (rotationAngle > 315) { rotationAngle = 0; }
    }
}
