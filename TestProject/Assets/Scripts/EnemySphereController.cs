using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySphereController : MonoBehaviour
{
    public float speed = 2f;
    private Vector3 startPoint;
    private Rigidbody rb;

    private void Start()
    {
       startPoint = transform.position;
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        var direction = (startPoint - transform.position).normalized;
        rb.AddForce(direction * 50, ForceMode.Impulse);
    }
}
