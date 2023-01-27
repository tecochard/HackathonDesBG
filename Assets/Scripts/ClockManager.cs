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

    [Header("Objets pour Enigme3")]
    public GameObject ObjectsEnigme3;

    private int angleSeconds = 0;
    private int angleMinutes = 45;
    private int angleHours = 315;

    // Si l'enigme est résolue
    private bool ALaBonneHeure = false;

    private void Start()
    {
        // On initialise bien la position des aiguilles
        pointerSeconds.transform.localEulerAngles = new Vector3(0.0f, 0.0f, angleSeconds);
        pointerMinutes.transform.localEulerAngles = new Vector3(0.0f, 0.0f, angleMinutes);
        pointerHours.transform.localEulerAngles = new Vector3(0.0f, 0.0f, angleHours);
    }

    void Update()
    {
        // Si les aiguilles sont bien placees, on debloque la solution
        if (angleSeconds == 270 && angleMinutes == 135 && angleHours == 0)
        {
            ALaBonneHeure = true;
            //VictorySound.Play();
            StartCoroutine(FinEnigme());
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
        print(angleHours);
    }

    public void RotateHours()
    {
        angleHours += 45;
        if (!ALaBonneHeure && angleHours > 316) { angleHours = 0; }
        pointerHours.transform.localEulerAngles = new Vector3(0.0f, 0.0f, angleHours);
        
    }

    IEnumerator FinEnigme()
    {
        print("Coroutine started");
        
        yield return new WaitForSeconds(1.0f);

        // On active les objets de l'enigme 3
        //ObjectsEnigme3.SetActive(true);

        // Gestion de l'EV
        EV2.SetActive(false);
        EV3.SetActive(true);        
    }
}
