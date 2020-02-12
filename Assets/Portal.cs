using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{

    [SerializeField] string tagMask = "Lemming";

    [SerializeField] Portal destination;
    [SerializeField] [Tooltip("Destination a l'interieur du portail actuel")] Transform selfDestination;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(tagMask) == true)
        {

            Vector3 exitPortalPosition = destination.transform.position;
            Quaternion exitPortalRotation = destination.transform.rotation;

            Rigidbody RB2D = other.gameObject.GetComponent<Rigidbody>();
            Vector2 velocity = RB2D.velocity;
            velocity = exitPortalRotation * velocity;
            other.gameObject.transform.position = exitPortalPosition;
            other.gameObject.transform.rotation = exitPortalRotation * Quaternion.Euler(0, 180, 0);
            RB2D.velocity = velocity;




            //Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
            //Vector3 velo = rb.velocity;

            //rb.velocity = Vector3.zero;
            //rb.AddRelativeForce(velo, ForceMode.Impulse);



            //other.transform.position = destination.Get().position;
            //other.transform.rotation = destination.transform.rotation * Quaternion.Euler(0, 180, 0);
        }
    }

    public Transform Get()
    {
        return selfDestination;
    }


}
