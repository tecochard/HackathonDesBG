using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckKeyGood : MonoBehaviour
{
    public GameObject Key1;
    public GameObject Key2;
    public GameObject Key3;
    public GameObject Key4;

    private int currentValue = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextKey()
    {
        currentValue++;
        if (currentValue == 4)
        {
            currentValue = 0;
        }

        if (currentValue == 0)
        {
            Key1.SetActive(true);
            Key2.SetActive(false);
            Key3.SetActive(false);
            Key4.SetActive(false);
        }
        else if (currentValue == 1)
        {
            Key1.SetActive(false);
            Key2.SetActive(true);
            Key3.SetActive(false);
            Key4.SetActive(false);
        }
        else if (currentValue == 2)
        {
            Key1.SetActive(false);
            Key2.SetActive(false);
            Key3.SetActive(true);
            Key4.SetActive(false);
        }
        else if (currentValue == 3)
        {
            Key1.SetActive(false);
            Key2.SetActive(false);
            Key3.SetActive(false);
            Key4.SetActive(true);
        }
    }
    //1.2
    //2.2
    //3.1
}
