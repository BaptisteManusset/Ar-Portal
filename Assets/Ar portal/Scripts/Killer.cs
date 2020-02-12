using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killer : MonoBehaviour
{
    [SerializeField] string tagMask = "Lemming";
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(tagMask) == true)
        {
            Destroy(other.gameObject);
        }
    }
}
