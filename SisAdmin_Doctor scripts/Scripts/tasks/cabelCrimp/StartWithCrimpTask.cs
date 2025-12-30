using UnityEngine;

public class StartWithCrimpTask : Task3
{
    public override string RUDescription => "Начать обучение";
    public override string Name => "StartWithCrimp";

    public override void Terms()
    {
        base.Terms();

        TaskController3.instance.ChangeTaskAndSetIndex("EnterCrimpZone");
    }
}
