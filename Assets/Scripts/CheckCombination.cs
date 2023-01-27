using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CheckCombination : MonoBehaviour
{
    public GameObject room1;
    public GameObject room2;

    public TMP_Text text1;
    public TMP_Text text2;
    public TMP_Text text3;
    public TMP_Text text4;

    public AudioSource VictorySound;

    private bool enigmeSolved = false;

    void Update()
    {
        string combination = text1.text + text2.text + text3.text + text4.text;
        if (combination == "4592")
        {
            enigmeSolved = true;
            VictorySound.Play();
        }

        // On change d'EV quand la musique est finie
        //if (enigmeSolved && !VictorySound.isPlaying) 
        if (enigmeSolved) 
        { 
            room1.SetActive(false);
            room2.SetActive(true);
        }
    }
}
