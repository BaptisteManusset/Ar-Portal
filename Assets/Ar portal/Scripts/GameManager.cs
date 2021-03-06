﻿
using UnityEngine;
using UnityEngine.Events;
using TMPro;
public class GameManager : MonoBehaviour
{
    public int spawned = 0;
    public int kill = 0;
    public int save = 0;
    public int succesNumber = 10;
    public UnityEvent endEvent;



    [Space(30)]
    public bool portalOrangeFound = false;
    public bool portalBlueFound = false;
    public static bool portalLinked = false;
    [Space(30)] [SerializeField] TextMeshProUGUI score;

    void Start()
    {
        UpdateUI();

    }
    public void UpdateUI()
    {
        score.text = save + "/" + succesNumber + " survivants";
    }
    public void PortalOrangeState(bool found)
    {
        portalOrangeFound = found;
        LinkUpdater();
    }
    public void PortalBlueState(bool found)
    {
        portalBlueFound = found;
        LinkUpdater();
    }

    private void LinkUpdater()
    {
        portalLinked = (portalBlueFound && portalOrangeFound ? true : false);
    }

    [ContextMenu("Toggle Blue")]
    public void ToggleBlue()
    {
        PortalBlueState(!portalBlueFound);
    }

    [ContextMenu("Toggle Orange")]
    public void ToggleOrange()
    {
        PortalOrangeState(!portalOrangeFound);
    }


    public void FixedUpdate()
    {
        if (succesNumber <= save)
        {
            endEvent.Invoke();
        }
    }
}
