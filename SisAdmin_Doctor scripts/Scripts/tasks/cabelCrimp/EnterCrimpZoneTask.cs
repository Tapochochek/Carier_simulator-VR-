using UnityEngine;

public class EnterCrimpZoneTask : Task3
{
    [SerializeField] public AssemblyStarter assemblyStarter;

    public override string RUDescription => "войди в зону обжима кабеля";
    public override string Name => "EnterCrimpZone";

    public override void Terms()
    {
        base.Terms();
        assemblyStarter.EnableStartTrigger(this);
    }

    public override void Complete()
    {
        if (!activated) return;

        base.Complete();
        assemblyStarter.DisableStartTrigger();
        TaskController3.instance.NextTask();
    }
}
