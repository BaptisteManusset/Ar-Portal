using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lemming : MonoBehaviour
{
    [SerializeField] float speed = 10;
    Rigidbody rb;


    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        Destroy(gameObject, 15);
    }

    void FixedUpdate()
    {
        rb.AddForce(transform.forward * speed);
    }
}
