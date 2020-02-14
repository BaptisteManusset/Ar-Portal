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
    [SerializeField] bool enableGravity = false;
    [SerializeField] float gravity = 1;
    GameManager gm;
    [SerializeField] LayerMask layerMask = 8;
    private void Awake()
    {
        gm = FindObjectOfType<GameManager>();
        rb = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
        Destroy(gameObject, 15);

    }

    void Update()
    {
        //rb.transform.Translate(transform.forward * Time.deltaTime * speed);
        rb.AddForce(transform.forward * -1 * speed);
        //rb.transform.Translate(transform.forward * Time.deltaTime * speed);
        //rb.AddRelativeTorque(transform.forward * Time.deltaTime * speed);

        if (enableGravity)
        {
            //rb.AddRelativeForce(transform.up * gravity * Time.deltaTime);
        }
        else
        {
            //RaycastHit hit;
            //if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, 10f, layerMask) == false)
            //{

            //    audio.Play();
            //    enableGravity = true;
            //}
        }
    }

    void Disable()
    {
        gm.kill++;
    }

    private void OnTriggerExit(Collider other)
    {
        //Debug.Log(other.gameObject.layer);
        //enableGravity = true;
        ////audio.Play();
    }
}
