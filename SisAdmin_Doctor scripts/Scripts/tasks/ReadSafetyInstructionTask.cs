using UnityEngine;

public class ReadSafetyInstructionTask : Task3
{
    [SerializeField] private GameObject instructionCanvas;
    [SerializeField] private GameObject safetyBlocker;
    [SerializeField] private GameObject startZoneVisual;

    public override string RUDescription =>
        "ќзнакомьтесь с инструктажем по теxнике безопасности";
    public override string Name => "ReadSafetyInstruction";

    public override void Terms()
    {
        base.Terms();

        if (instructionCanvas != null)
            instructionCanvas.SetActive(true);

        if (safetyBlocker != null)
            safetyBlocker.SetActive(true);

        if (startZoneVisual != null)
            startZoneVisual.SetActive(false);
    }

    public override void Complete()
    {
        if (!activated) return;

        activated = false;

        if (instructionCanvas != null)
            instructionCanvas.SetActive(false);
        
        if (safetyBlocker != null)
            safetyBlocker.SetActive(false);

        if (startZoneVisual != null)
            startZoneVisual.SetActive(true);

        TaskController3.instance.NextTask();
    }
}
