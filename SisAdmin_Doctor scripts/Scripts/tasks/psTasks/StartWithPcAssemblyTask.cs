using UnityEngine;

public class StartWithPcAssemblyTask : Task3
{
    public override string RUDescription => "Начать со сборки ПК";
    public override string Name => "StartWithPcAssembly";

    public override void Terms()
    {
        base.Terms();

        TaskController3.instance.ChangeTaskAndSetIndex("EnterPcAssemblyZone");
    }
}
