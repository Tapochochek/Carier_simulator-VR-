using UnityEngine;

public class EnterPcAssemblyZoneTask : Task3
{
    [Header("Zone trigger")]
    [SerializeField] private Collider assemblyZoneTrigger;

    private bool completed;

    public override string RUDescription => "подойди к зоне сборки ПК";
    public override string Name => "EnterPcAssemblyZone";

    public override void Terms()
    {
        base.Terms();
        completed = false;

        if (assemblyZoneTrigger == null)
        {
            Debug.LogError("EnterPcAssemblyZoneTask: Zone collider не назначен");
            return;
        }

        assemblyZoneTrigger.enabled = true;
    }

    public void OnPlayerEnteredZone(Collider other)
    {
        if (!activated || completed) return;
        if (!other.CompareTag("Player")) return;

        completed = true;

        Debug.Log("Игрок подошёл к зоне сборки ПК");

        assemblyZoneTrigger.enabled = false;
        TaskController3.instance.NextTask();
    }
}
