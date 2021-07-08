using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingScript : MonoBehaviour
{
    public Rigidbody rb;
    public float time = 10;

    void Start()
    {
        rb.constraints = RigidbodyConstraints.FreezePosition;

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            rb.constraints = RigidbodyConstraints.None;
        }
    }
}
