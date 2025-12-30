using UnityEngine;

public class AssemblyStarter : MonoBehaviour
{
    public PCMaster pcMaster;
    public GameObject startZoneVisual;
    public GameObject assemblyTable;
    public AudioClip startSound;
    public GameObject[] blockingWalls;


    private bool assemblyStarted;
    private AudioSource audioSource;

    private EnterCrimpZoneTask currentTask;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;

        SetWallsActive(false);
        DisableAllAssembly();

        if (assemblyTable != null)
            assemblyTable.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        if (assemblyStarted) return;

        if (currentTask != null)
        {
            currentTask.Complete();
            currentTask = null;
        }

        StartAssembly();
    }

    public void EnableStartTrigger(EnterCrimpZoneTask task)
    {
        currentTask = task;
        GetComponent<Collider>().enabled = true;

        if (startZoneVisual != null)
            startZoneVisual.SetActive(true);
    }

    public void DisableStartTrigger()
    {
        GetComponent<Collider>().enabled = false;
    }

    private void StartAssembly()
    {
        //if (gameObject.tag == "Respawn")
        //{
        //    TaskController.instance.NextTask();
        //}

        assemblyStarted = true;

        if (startSound != null)
            audioSource.PlayOneShot(startSound);

        SetWallsActive(true);
        EnableAssembly();

        if (assemblyTable != null)
            assemblyTable.SetActive(true);

        if (startZoneVisual != null)
            startZoneVisual.SetActive(false);
    }

    private void SetWallsActive(bool active)
    {
        foreach (var wall in blockingWalls)
            if (wall != null)
                wall.SetActive(active);
    }

    private void EnableAssembly()
    {
        if (pcMaster == null) return;

        foreach (var component in pcMaster.components)
            if (component.socket != null)
                component.socket.socketActive = true;
    }

    private void DisableAllAssembly()
    {
        if (pcMaster == null) return;

        foreach (var component in pcMaster.components)
            if (component.socket != null)
                component.socket.socketActive = false;
    }

    public void UnlockAndHideZone()
    {
        SetWallsActive(false);

        if (startZoneVisual != null)
            startZoneVisual.SetActive(false);
    }

}
