using UnityEngine;

public class TrainingScenarioManager : MonoBehaviour
{
    public static TrainingScenarioManager instance;

    [Header("Task Controllers")]
    [SerializeField] private TaskController3 pcFirstController;
    [SerializeField] private TaskController3 crimpFirstController;

    private bool scenarioChosen;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    private void Start()
    {
        pcFirstController.gameObject.SetActive(false);
        crimpFirstController.gameObject.SetActive(false);
    }

    public void StartWithPcAssembly()
    {
        if (scenarioChosen) return;
        scenarioChosen = true;

        pcFirstController.gameObject.SetActive(true);
        crimpFirstController.gameObject.SetActive(false);
    }

    public void StartWithCrimp()
    {
        if (scenarioChosen) return;
        scenarioChosen = true;

        crimpFirstController.gameObject.SetActive(true);
        pcFirstController.gameObject.SetActive(false);
        //Task3 task0 = TaskController3.instance.Tasks[0];
        //Task3 task1 = TaskController3.instance.Tasks[1];
        //TaskController3.instance.Tasks[0] = task1;
        //TaskController3.instance.Tasks[1] = task0;


    }
}
