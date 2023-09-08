using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour
{
    public float speed = 20;
    public float turnSpeed = 50;
    float inputTurn;
    float inputForward;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Get input
        inputTurn = Input.GetAxis("Horizontal");
        inputForward = Input.GetAxis("Vertical");
        //Apply motion
        transform.Translate(Vector3.forward * Time.deltaTime * speed * inputForward);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * inputTurn);
    }
}
