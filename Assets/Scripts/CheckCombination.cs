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

    void Update()
    {
        string combination = text1.text + text2.text + text3.text + text4.text;
        print(combination);
        if (combination == "4592")
        {
            room1.SetActive(false);
            room2.SetActive(true);
            Debug.Log("Combination is correct!");
        }
    }
}
