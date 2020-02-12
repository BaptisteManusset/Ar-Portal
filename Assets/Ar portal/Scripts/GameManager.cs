using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int spawned = 0;
    public int kill = 0;
    public int save = 0;


    [Space(30)]
    public bool portalOrangeFound = false;
    public bool portalBlueFound = false;
    public static bool portalLinked = false;


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
        GameManager.portalLinked = (portalBlueFound && portalOrangeFound ? true : false);
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
}
