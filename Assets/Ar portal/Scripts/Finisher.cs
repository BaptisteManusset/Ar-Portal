using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finisher : MonoBehaviour
{
    [SerializeField] string tagMask = "Lemming";
    public int count = 0;

    GameManager gm;
    AudioSource audio;
    private void Awake()
    {
        gm = FindObjectOfType<GameManager>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(tagMask) == true)
        {
            gm.save++;
            Destroy(other.gameObject);
            audio.Play();
        }
    }
}
