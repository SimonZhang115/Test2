using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driving_safety_Onclick : PanelManager
{
    public void OnclickOfDrivingSafety()
    {
        CloseAllPanels();
        OpenPanelByName("Driving_safety");
    }
}
