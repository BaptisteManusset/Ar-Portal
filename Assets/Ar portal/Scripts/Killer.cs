using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killer : MonoBehaviour
{



    [SerializeField] string tagMask = "Lemming";

    GameManager gm;
    [SerializeField] AudioSource deathSound;

    private void Awake()
    {
        gm = FindObjectOfType<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(tagMask) == true)
        {

            deathSound.transform.position = other.transform.position;
            deathSound.Play();

            Destroy(other.gameObject);
            gm.kill++;


        }
    }
}
