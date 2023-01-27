using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockManager : MonoBehaviour
{
    // 12:25:45 (1/4 + 1/8)
    public GameObject pointerSeconds;
    public GameObject pointerMinutes;
    public GameObject pointerHours;

    private int angleSeconds;
    private int angleMinutes;
    private int angleHours;

    // Update is called once per frame
    void Update()
    {
        // Si les aiguilles sont bien placees, on debloque la solution
        if (angleSeconds == 270 && angleMinutes == 135 && angleHours == 0)
        {
            Debug.Log("Bien ouej magueule");
        }
    }

    public void RotateSeconds()
    {
        Debug.Log("tourne secondes");
        angleSeconds += 45;
        if (angleSeconds > 316) { angleSeconds = 0; }
        pointerSeconds.transform.localEulerAngles = new Vector3(0.0f, 0.0f, angleSeconds);
    }

    public void RotateMinutes()
    {
        angleMinutes += 45;
        if (angleMinutes > 316) { angleMinutes = 0; }
        pointerMinutes.transform.localEulerAngles = new Vector3(0.0f, 0.0f, angleMinutes);
    }

    public void RotateHours()
    {
        angleHours += 45;
        if (angleHours > 316) { angleHours = 0; }
        pointerHours.transform.localEulerAngles = new Vector3(0.0f, 0.0f, angleHours);
    }
}
