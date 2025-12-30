using UnityEngine;

public class TrainingModeSelector : MonoBehaviour
{
    public static TrainingModeSelector instance;

    [Header("Task Controllers")]
    public TaskController3 crimpController;
    public TaskController3 pcController;

    private bool selected;

    private void Awake()
    {
        instance = this;

        crimpController.gameObject.SetActive(false);
        pcController.gameObject.SetActive(false);
    }

    public void StartWithCrimp()
    {
        if (selected) return;
        selected = true;

        crimpController.gameObject.SetActive(true);
        crimpController.NextTask();

        pcController.gameObject.SetActive(false);
    }

    public void StartWithPcAssembly()
    {
        if (selected) return;
        selected = true;

        pcController.gameObject.SetActive(true);
        pcController.NextTask();

        crimpController.gameObject.SetActive(false);
    }
}
