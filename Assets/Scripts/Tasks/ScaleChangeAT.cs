using NodeCanvas.Framework;
using UnityEngine;

public class ScaleChangeAT : ActionTask
{
    public Transform targetTransform;
    public float targetScale = 2f;

    private float originalScale;
    private Vector3 highScale;
    private Vector3 lowScale;


    protected override string OnInit()
    {
        originalScale = targetTransform.localScale.x;

        highScale = new Vector3(2, 2, 2);
        lowScale = new Vector3(1, 1, 1);
        return null;
    }

    //protected override void OnExecute()
    //{
    //    targetTransform.localScale = new Vector3(targetScale, targetScale, targetScale);
    //    EndAction(true);
    //}

    protected override void OnUpdate()
    {
        float stepValue = Mathf.PingPong(Time.time, 1f);
        float currentScale = Mathf.Lerp(originalScale, targetScale, stepValue);

        targetTransform.localScale = new Vector3(currentScale, currentScale, currentScale);
    }

    protected override void OnStop()
    {
        targetTransform.localScale = new Vector3(originalScale, originalScale, originalScale);
    }
}
