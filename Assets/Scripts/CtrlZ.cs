using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class CtrlZ : MonoBehaviour
{
    public Button z;
    // Start is called before the first frame update
    void Start()
    {
        z.onClick.AddListener(reloadScene);
    }

    // Update is called once per frame
    
    private void reloadScene(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
