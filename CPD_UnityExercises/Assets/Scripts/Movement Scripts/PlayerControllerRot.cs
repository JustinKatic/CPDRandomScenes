using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerRot : MonoBehaviour
{
    // Private Variables
    public float speed = 30f;
    public float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;
    Camera cam;
    Vector3 movementDirection;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
       // transform.rotation = Quaternion.LookRotation(movementDirection, Vector3.up);
        //This is where we get player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // We move vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // We turn the Vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
