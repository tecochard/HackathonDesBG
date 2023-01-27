using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CheckCombination : MonoBehaviour
{
    public TMP_Text text1;
    public TMP_Text text2;
    public TMP_Text text3;
    public TMP_Text text4;

    void Update()
    {
        string combination = text1.text + text2.text + text3.text + text4.text;
        if (combination == "2345")
        {
            Debug.Log("Combination is correct!");
        }
    }
}
