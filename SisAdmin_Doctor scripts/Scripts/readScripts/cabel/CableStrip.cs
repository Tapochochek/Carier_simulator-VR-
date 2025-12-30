using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CableStrip : MonoBehaviour
{
    public GameObject insulatedModel;  
    public GameObject strippedModel;    
    public AudioSource cutSound;        
    public XRSocketInteractor socket;  

    private bool stripped = false;

    void Update()
    {
        if (stripped) return;

        if (Input.GetKeyDown(KeyCode.A) || Input.GetMouseButtonDown(0))
        {
            if (socket.hasSelection) 
            {
                StripInsulation();
            }
        }
    }

    public void StripInsulation()
    {
        stripped = true;

        insulatedModel.SetActive(false);
        strippedModel.SetActive(true);

        if (cutSound != null)
            cutSound.Play();
    }
}
