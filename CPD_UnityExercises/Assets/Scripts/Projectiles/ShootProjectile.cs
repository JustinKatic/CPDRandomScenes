using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootProjectile : MonoBehaviour
{
    public GameObject projectile;
    public float shootSpeed = 60;  
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = Instantiate(projectile, transform.position, Quaternion.identity);           
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * shootSpeed);
        }
    }
}
