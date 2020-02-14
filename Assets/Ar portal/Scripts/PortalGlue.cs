using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalGlue : MonoBehaviour
{
    public LayerMask layerMask;
    private Portal portal;
    void Start()
    {
        portal = GetComponentInChildren<Portal>();
    }

    void Update()
    {
        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, Vector3.down, out hit, Mathf.Infinity, layerMask))
        {
            Debug.DrawRay(transform.position, Vector3.down * hit.distance, Color.yellow);
            Debug.Log("Did Hit",gameObject);

            portal.transform.position = hit.point;
            
        }
        else
        {
            Debug.DrawRay(transform.position, Vector3.down * 1000, Color.white);
            Debug.Log("Did not Hit", gameObject);
        }
    }
}
