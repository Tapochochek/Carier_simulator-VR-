using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskController3 : MonoBehaviour
{
    public static TaskController3 instance;
    public Task3 ActivityTask;
    public List<Task3> Tasks = new List<Task3>();
    private int activityTaskNumber = -1;

    public enum TrainingStartMode
    {
        FullTraining,    
        PcAssemblyOnly    
    }

    public TrainingStartMode startMode = TrainingStartMode.FullTraining;



    private void Awake()
    {

        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

    }
    private void Start()
    {
        NextTask();
        

    }
    //Смена задания
    public void NextTask()
    {
        activityTaskNumber++;
        ActivityTask = Tasks[activityTaskNumber];
        print(activityTaskNumber);
        UIController3.instance.ChangeTaskText();
        Tasks[activityTaskNumber].Terms();
        //foreach (var task in Tasks)
        //{
            
        //    if (task.Name == taskName)
        //    {
        //        ActivityTask = task;
        //        //UIController.instance.TaskText();
        //        ActivityTask.Terms();
        //    }
        //}
    }
    //Смена задания
    public void ChangeTask(string taskName)
    {
        foreach (var task in Tasks)
        {
            if (task.Name == taskName)
            {
                ActivityTask = task;
                //UIController.instance.TaskText();
                ActivityTask.Terms();
            }
        }
    }

    //Получение задания по названию
    public Task3 GetTask(string taskName)
    {
        foreach (var task in Tasks)
        {
            if (task.Name == taskName)
            {
                return task;
            }
        }
        return null;
    }

    public void ChangeTaskAndSetIndex(string taskName)
    {
        if (ActivityTask != null)
            ActivityTask.Complete();

        for (int i = 0; i < Tasks.Count; i++)
        {
            if (Tasks[i].Name == taskName)
            {
                activityTaskNumber = i;
                ActivityTask = Tasks[i];

                UIController3.instance.ChangeTaskText();
                ActivityTask.Terms();
                return;
            }
        }

        Debug.LogError($"Task с именем {taskName} не найден");
    }

}
