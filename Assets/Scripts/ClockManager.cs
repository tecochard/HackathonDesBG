using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockManager : MonoBehaviour
{
    // Bonne heure pour l'horloge : 12h25min45sec
    public GameObject pointerSeconds;
    public GameObject pointerMinutes;
    public GameObject pointerHours;

    // Gestion de l'EV
    public GameObject EV2;
    public GameObject EV3;

    // Son de victoire
    public AudioSource VictorySound;

    private int angleSeconds;
    private int angleMinutes;
    private int angleHours;

    // Si l'enigme est résolue
    private bool ALaBonneHeure = false;

    // Update is called once per frame
    void Update()
    {
        // Si les aiguilles sont bien placees, on debloque la solution
        if (angleSeconds == 270 && angleMinutes == 135 && angleHours == 0)
        {
            Debug.Log("Bien ouej magueule");
            ALaBonneHeure=true;

            // gestion de l'EV
            EV2.SetActive(false);
            EV3.SetActive(true);
            VictorySound.Play();
        }
    }

    public void RotateSeconds()
    {
        Debug.Log("tourne secondes");
        angleSeconds += 45;
        if (!ALaBonneHeure && angleSeconds > 316) { angleSeconds = 0; }
        pointerSeconds.transform.localEulerAngles = new Vector3(0.0f, 0.0f, angleSeconds);
    }

    public void RotateMinutes()
    {
        angleMinutes += 45;
        if (!ALaBonneHeure && angleMinutes > 316) { angleMinutes = 0; }
        pointerMinutes.transform.localEulerAngles = new Vector3(0.0f, 0.0f, angleMinutes);
    }

    public void RotateHours()
    {
        angleHours += 45;
        if (!ALaBonneHeure && angleHours > 316) { angleHours = 0; }
        pointerHours.transform.localEulerAngles = new Vector3(0.0f, 0.0f, angleHours);
    }
}
