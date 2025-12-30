using UnityEngine;

public class Task3 : MonoBehaviour
{
    protected bool activated;
    private TaskAnim3 anim;

    private void Awake()
    {
        anim = FindFirstObjectByType<TaskAnim3>();
    }

    public virtual string RUDescription => "";
    public virtual string Name => "";

    public virtual void Terms()
    {
        activated = true;
    }

    public virtual void Complete()
    {
        activated = false;
        anim.SwitchImage();
    }
}
