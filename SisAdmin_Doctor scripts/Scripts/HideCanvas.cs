using UnityEngine;

public class HideCanvas : MonoBehaviour
{
    [SerializeField] private GameObject wallToDisable;

    public void Continue()
    {
        if (wallToDisable != null)
            wallToDisable.SetActive(false);

        transform.root.gameObject.SetActive(false);
    }
}
