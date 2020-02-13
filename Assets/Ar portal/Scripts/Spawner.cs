using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] Transform parent;

    [SerializeField] GameObject lemming;


    [Space(30)] [SerializeField] float delayBeforeFirst = 10;
    [SerializeField] float repeatRate = 5;

    GameManager gm;
    private void Awake()
    {
        gm = FindObjectOfType<GameManager>();
    }


    void Start()
    {
        EnableSpawn();
    }

    void Spawning()
    {
        GameObject instance = Instantiate(lemming, transform.position, transform.rotation, parent);
        gm.spawned++;

        instance.transform.rotation = transform.rotation;
    }


    public void EnableSpawn()
    {
        InvokeRepeating(nameof(Spawning), delayBeforeFirst, repeatRate);
        delayBeforeFirst = repeatRate;
    }
    public void DisableSpawn()
    {
        //CancelInvoke();
    }
}
