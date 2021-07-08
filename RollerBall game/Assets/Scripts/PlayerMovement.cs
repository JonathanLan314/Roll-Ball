using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 0.5f;
    public float jumpForce = 10;
    public Rigidbody rigidbody;

    public bool isOnGround;

    public void Start()
    {
        isOnGround = true;
    }

    public void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        horizontal *= speed * Time.deltaTime;
        vertical *= speed * Time.deltaTime;

        transform.Translate(horizontal, 0, vertical);

        if (Input.GetButtonDown("Jump") && isOnGround == true)
        {
            isOnGround = false;
            rigidbody.AddForce(transform.up * jumpForce, ForceMode.Impulse);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ground")
        {
            isOnGround = true;
        }
    }
}
