using UnityEngine;

public class CompleteCurrentTaskButton : MonoBehaviour
{
    public void CompleteTask()
    {
        Task3 current = TaskController3.instance.ActivityTask;
        if (current != null)
            current.Complete();
    }
}
