using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocity = 5.0f;
    public float turnSpeed;
    public float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float Turnspeed;
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * velocity);
        transform.Translate(Vector3.left * Time.deltaTime * turnSpeed * horizontalInput);
    }
}

//nothing here yet...