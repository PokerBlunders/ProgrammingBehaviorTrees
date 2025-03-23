using NodeCanvas.Framework;
using UnityEngine;

public class ColorChangeAT : ActionTask
{
    public Renderer renderer;
    public Color targetColor = Color.white;

    private Color originalColor;

    protected override string OnInit()
    {
        originalColor = renderer.material.color;
        return null;
    }

    //protected override void OnExecute()
    //{
    //    renderer.material.color = targetColor;
    //    EndAction();
    //}

    protected override void OnUpdate()
    {
        float stepValue = Mathf.PingPong(Time.time, 1f);
        renderer.material.color = Color.Lerp(originalColor, targetColor, stepValue);
    }

    protected override void OnStop()
    {
        renderer.material.color = originalColor;
    }
}
