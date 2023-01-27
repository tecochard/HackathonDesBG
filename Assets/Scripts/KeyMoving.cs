using Oculus.Interaction.PoseDetection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class KeyMoving : MonoBehaviour
{

    private float x;
    private float y;
    private float z;
    private float temps;

    // Start is called before the first frame update
    void Start()
    {
        x = this.transform.position.x;
        y = this.transform.position.y;
        z = this.transform.position.z;
        temps = 0;
    }

    // Update is called once per frame
    void Update()
    {

        temps += Time.deltaTime;
        this.gameObject.transform.position.Set(x, y + Mathf.Sin(temps), z);
    }
}
