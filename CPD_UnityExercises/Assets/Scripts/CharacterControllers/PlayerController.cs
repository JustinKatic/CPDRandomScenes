using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveForce = 10.0f;

    private Rigidbody rb;
    private Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("player Controller requires a rigidbody");
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 inputForce = new Vector3();
        inputForce.x = Input.GetAxis("Horizontal");
        inputForce.z = Input.GetAxis("Vertical");
        rb.AddForce(inputForce * moveForce);

        rb.AddForce(0, 0.8f, 0);

        if (Input.GetButtonDown("Jump"))
        {
            transform.Rotate(0.0f, 0.0f, 90.0f, Space.Self);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Food")
        {
            Destroy(other.gameObject);
        }
    }
}

