using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRoom : MonoBehaviour
{
    public bool Condition;
    public bool Condition2;
    public bool Condition3;
    public bool Condition4;

    public GameObject zone1;
    public GameObject zone2;
    public GameObject zone3;
    public GameObject zone4;

    // Start is called before the first frame update
    void Start()
    {
        Condition = true;
        Condition2 = false;
        Condition3 = false;
        Condition4 = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Condition)
        {
            activerZone1();
        }
        if (Condition2)
        {
            activerZone2();
        }
        if (Condition3)
        {
            activerZone3();
        }
        if (Condition4)
        {
            activerZone4();
        }
        if (!Condition)
        {
            desactiverZone1();
        }
        if (!Condition2)
        {
            desactiverZone2();
        }
        if (!Condition3)
        {
            desactiverZone3();
        }
        if (!Condition4)
        {
            desactiverZone4();
        }
    }

    public void activerZone1()
    {
        zone1.SetActive(true);
    }

    public void activerZone2()
    {
        zone2.SetActive(true);
    }

    public void activerZone3()
    {
        zone3.SetActive(true);
    }

    public void activerZone4()
    {
        zone4.SetActive(true);
    }

    public void desactiverZone1()
    {
        zone1.SetActive(false);
    }

    public void desactiverZone2()
    {
        zone2.SetActive(false);
    }

    public void desactiverZone3()
    {
        zone3.SetActive(false);
    }
    public void desactiverZone4()
    {
        zone4.SetActive(false);
    }
}
