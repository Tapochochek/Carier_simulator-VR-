using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIController3 : MonoBehaviour
{
    public static UIController3 instance;
    [SerializeField] private TextMeshProUGUI _activityTaskText, _npcSubtitles;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);

    }

    //Вывод текста задания
    public void ChangeTaskText()
    {
        if (TaskController3.instance.ActivityTask != null)
        {          
            Task3 task = TaskController3.instance.ActivityTask;
            _activityTaskText.text = task.RUDescription;
        }
    }
    public void ChangeSubtitles(string subtitles)
    {
        _npcSubtitles.text = subtitles;
    }
}
