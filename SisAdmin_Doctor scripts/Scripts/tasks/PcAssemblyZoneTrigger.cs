using UnityEngine;

public class PcAssemblyZoneTrigger : MonoBehaviour
{
    [SerializeField] private EnterPcAssemblyZoneTask task;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        if (task == null) return;

        TrainingScenarioManager.instance.StartWithPcAssembly();
        task.OnPlayerEnteredZone(other);
    }
}
