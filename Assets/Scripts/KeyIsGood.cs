using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyIsGood : MonoBehaviour
{

    public GameObject Key1_2;
    public GameObject Key2_2;
    public GameObject Key3_1;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Key1_2.activeSelf == true && Key2_2.activeSelf == true && Key3_1.activeSelf == true)
        {
            Debug.Log("Vous avez gagné !");
        }
    }
}
