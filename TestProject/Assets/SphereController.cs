using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    public float rotationSpeed = 3.5f;
    public float moveSpeed = 0.5f;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        transform.Rotate(0, rotationSpeed, 0);
        Move();
    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            //transform.Translate(new Vector3(moveSpeed, 0, 0));
            //var movement = new Vector3(moveSpeed, 0, 0);
            //rb.AddForce(transform.right*500);
            rb.AddForce(transform.right * 200, ForceMode.Impulse);
        }
    }
}
