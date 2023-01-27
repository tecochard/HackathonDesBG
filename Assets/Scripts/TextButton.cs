using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextButton : MonoBehaviour
{
    public Button suivant; // Assign the button in the inspector
    public Button precedent;
    public Button commencer;
    private int currentValue = 1;
    public TextMeshProUGUI Text1;
    public TextMeshProUGUI Text2;
    public TextMeshProUGUI Text3;
    public TextMeshProUGUI Text4;
    public TextMeshProUGUI Text5;
    public TextMeshProUGUI Text6;
    public TextMeshProUGUI Text7;



    // Start is called before the first frame update
    void Start()
    {
        suivant.onClick.AddListener(IncrementText);
        precedent.onClick.AddListener(DecrementText);
        Text2.enabled = false;
        Text3.enabled = false;
        Text4.enabled = false;
        Text5.enabled = false;
        Text6.enabled = false;
        Text7.enabled = false; 
        commencer.gameObject.SetActive(false);
    }


        private void IncrementText()
    {
        currentValue++;
        if (currentValue == 8)
        {
            currentValue = 7;
            commencer.gameObject.SetActive(true);
            suivant.gameObject.SetActive(false);
            precedent.gameObject.SetActive(false);

        }
        switch (currentValue) {
            case 1:
            Text1.enabled = true;
            Text7.enabled = false;
            break;
            case 2:
            Text2.enabled = true;
            Text1.enabled = false;
            break;
            case 3:
            Text3.enabled = true;
            Text2.enabled = false;
            break;
            case 4:
            Text4.enabled = true;
            Text3.enabled = false;
            break;
            case 5:
            Text5.enabled = true;
            Text4.enabled = false;
            break;
            case 6:
            Text6.enabled = true;
            Text5.enabled = false;
            break;
            case 7:
            Text7.enabled = true;
            Text6.enabled = false;
            break;
        }
        
    }

    private void DecrementText()
    {
        currentValue--;
        if (currentValue == 0)
        {
            currentValue = 1;
        }
        switch (currentValue) {
            case 1:
            Text1.enabled = true;
            Text2.enabled = false;
            break;
            case 2:
            Text2.enabled = true;
            Text3.enabled = false;
            break;
            case 3:
            Text3.enabled = true;
            Text4.enabled = false;
            break;
            case 4:
            Text4.enabled = true;
            Text5.enabled = false;
            break;
            case 5:
            Text5.enabled = true;
            Text6.enabled = false;
            break;
            case 6:
            Text6.enabled = true;
            Text7.enabled = false;
            break;
            case 7:
            Text7.enabled = true;
            Text1.enabled = false;
            break;
        }
    }
}