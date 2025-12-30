using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CrimpController : MonoBehaviour
{
    public XRSocketInteractor connectorSocket;
    public GameObject crimpedCableModel;
    public AudioSource crimpSound;

    private bool isCrimped = false;

    void Update()
    {
        if (isCrimped) return;

        if (connectorSocket.hasSelection && Input.GetKeyDown(KeyCode.A))
        {
            Crimp();
        }
    }

    void Crimp()
    {
        isCrimped = true;

        if (crimpSound)
            crimpSound.Play();

        crimpedCableModel.SetActive(true);
        Debug.Log("Кабель обжат");
    }
}
