using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] Transform parent;

    [SerializeField] GameObject lemming;


    [Space(30)] [SerializeField] float delayBeforeFirst = 5;
    [SerializeField] float repeatRate = 5;
    [SerializeField] float scale = 3;
    Vector3 scaleVector;

    GameManager gm;

    private void Awake()
    {
        gm = FindObjectOfType<GameManager>();
        InvokeRepeating(nameof(Spawning), delayBeforeFirst, repeatRate);
        scaleVector = Vector3.one * scale;
    }

    void Spawning()
    {
        //GameObject instance = Instantiate(lemming, transform.position, transform.rotation, parent);
        GameObject instance = Instantiate(lemming, transform.position, transform.rotation);
        instance.transform.rotation = transform.rotation;
        instance.transform.localScale = scaleVector;
        gm.spawned++;
    }
}
