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
        audio = FindObjectOfType<AudioSource>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(tagMask) == true)
        {
            gm.save++;
            gm.UpdateUI();
            Destroy(other.gameObject);
            audio.Play();
        }
    }
}
