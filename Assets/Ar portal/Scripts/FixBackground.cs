using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class FixBackground : MonoBehaviour
{
    public GameObject card;
    Transform child;
    ImageTargetBehaviour itb;
    public void UnFix()
    {
        Debug.Log("Fix the Background");
        child.parent = card.transform;
        
        itb = card.GetComponent<ImageTargetBehaviour>();
        itb.enabled = true;
    }

    public void Fix()
    {
        Debug.Log("Fix the Background");
        child = card.transform.GetChild(0);
        child.parent = null;

        itb = card.GetComponent<ImageTargetBehaviour>();
        itb.enabled = false;
    }



}
