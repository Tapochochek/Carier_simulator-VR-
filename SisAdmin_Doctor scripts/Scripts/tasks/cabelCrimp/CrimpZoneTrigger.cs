using UnityEngine;

public class CrimpZoneTrigger : MonoBehaviour
{
    private bool triggered;

    private void OnTriggerEnter(Collider other)
    {
        if (triggered) return;
        if (!other.CompareTag("Player")) return;

        triggered = true;

        TrainingScenarioManager.instance.StartWithCrimp();
    }
}
