using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lemming : MonoBehaviour
{
    [SerializeField] float speed = 10;
    Rigidbody rb;
    public int destination = -1;
    public int count = 0;


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
