using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class IncrementTextOnButtonClick : MonoBehaviour
{
    public Button incrementButton; // Assign the button in the inspector
    public Button decrementButton;
    public TextMeshProUGUI displayText; // Assign the text element in the inspector
    private int currentValue = 0;
    

    private void Start()
    {
        //incrementButton.onClick.AddListener(IncrementText);
        //decrementButton.onClick.AddListener(DecrementText);
    }

    public void IncrementText()
    {
        currentValue++;
        if (currentValue == 10)
        {
            currentValue = 0;
        }
        displayText.text = currentValue.ToString();
    }

    public void DecrementText()
    {
        currentValue--;
        if (currentValue == -1)
        {
            currentValue = 9;
        }
        displayText.text = currentValue.ToString();
    }
}
