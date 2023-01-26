using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadSceneMusic : MonoBehaviour
{
    // Script to reload the scene at the end of the song
    [Header("Musique choisie")]
    public AudioSource Song;

    void Start()
    {
        // On verifie que la musique se soit bien lancee
        if (!Song.isPlaying)
        {
            Song.Play();
        }

        // On verifie que l'audio ne loop pas
        Song.loop = false;
    }

    void Update()
    {
        // Quand la musique s'arrete, on recharge la scene
        if (!Song.isPlaying)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
