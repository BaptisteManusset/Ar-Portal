using UnityEngine;
using Vuforia;
public class ScreenInverter : MonoBehaviour
{
    [SerializeField] GameObject bpb;
    [SerializeField] Vector3 scale;
    bool flipped = false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (bpb == null)
            bpb = GameObject.Find("BackgroundPlane");
        
        if (bpb.transform.localScale.x > 0)
        {
            bpb.transform.localScale = new Vector3(bpb.transform.localScale.x * -1, bpb.transform.localScale.y, bpb.transform.localScale.z);
            flipped = true;

            Debug.Log("=======================================");
        }
    }
}
