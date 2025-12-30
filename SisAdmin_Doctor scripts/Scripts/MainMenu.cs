using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private List<GameObject> panels;
    private int selectedProfession;
    private int activePanel;
    
    public void NextPanel()
    {
        panels[activePanel].SetActive(false);
        activePanel++;
        panels[activePanel].SetActive(true);
    }
    public void PreviousPanel()
    {
        panels[activePanel].SetActive(false);
        activePanel--;
        panels[activePanel].SetActive(true);
    }
    public void SelectProfession(int profession)
    {
        selectedProfession = profession;
    }
    public void StartGame()
    {
        SceneManager.LoadScene(selectedProfession);
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void OpenSite(string url)
    {
        Application.OpenURL(url);
    }
}
