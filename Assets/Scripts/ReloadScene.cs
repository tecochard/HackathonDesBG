using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour
{
    // Script to reload the scene at the end of a timer
    [Header("Temps de la boucle en secondes")]
    public float tempsMaxBoucle;
    private float temps;

    void Start()
    {
        temps = 0.0f;
    }

    void Update()
    {
        // On incremente le temps
        temps += Time.deltaTime;
        // le temps est en secondes
        if (temps >= tempsMaxBoucle)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
