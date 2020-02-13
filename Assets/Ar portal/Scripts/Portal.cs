using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{

    [SerializeField] string tagMask = "Lemming";

    [SerializeField] Portal destination;
    [SerializeField] [Tooltip("Destination a l'interieur du portail actuel")] Transform selfDestination;
    [SerializeField] Vector3 offset = new Vector3(0, .95f, 0);
    AudioSource audio;
    void Awake()
    {
        audio = GetComponent<AudioSource>();


    }


    private void OnTriggerEnter(Collider other)
    {
        if (GameManager.portalLinked == false) return;

        if (other.CompareTag(tagMask) == true)
        {
            Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
            Lemming lm = other.gameObject.GetComponent<Lemming>();

            if (lm.destination == this.GetHashCode()) return;


            Vector3 exitPortalPosition = destination.transform.position;
            Quaternion exitPortalRotation = destination.transform.rotation;


            audio.PlayOneShot(audio.clip);
            lm.destination = destination.GetHashCode();



            Vector2 velocity = rb.velocity;
            velocity = exitPortalRotation * velocity;

            other.transform.position = exitPortalPosition ;
            other.transform.rotation = exitPortalRotation * Quaternion.Euler(0, 180, 0);
            rb.velocity = velocity;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(tagMask) == true)
        {
            Lemming lm = other.gameObject.GetComponent<Lemming>();
            //lm.count = 0;
        }
    }


    public Transform Get()
    {
        return selfDestination;
    }


}
