using NodeCanvas.Framework;
using Unity.VisualScripting;
using UnityEngine;

public class DetectPlayerCT : ConditionTask
{
    private bool objectDetected;

    protected override bool OnCheck()
    {
        if (objectDetected == true) return true;
        else return false;
    }

    void OnTriggerEnter(Collision col)
    {
        if (col.gameObject.name == "Cube")
        {
            objectDetected = true;
        }
    }

    void OnTriggerExit(Collision col)
    {
        if (col.gameObject.name == "Cube")
        {
            objectDetected = false;
        }
    }
}
