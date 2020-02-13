using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lemming : MonoBehaviour
{
    [SerializeField] float speed = 2;
    Rigidbody rb;
    public int destination = -1;
    public int count = 0;
    AudioSource audio;

    GameManager gm;
    private void Awake()
    {
        gm = FindObjectOfType<GameManager>();
        rb = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
        Destroy(gameObject, 15);

    }

    void FixedUpdate()
    {
        rb.transform.Translate(transform.forward * Time.deltaTime * speed);
    }

    void Disable()
    {
        gm.kill++;
    }
}
