using UnityEngine;

public class DE_Teleport : MonoBehaviour
{
    private void OnEnable()
    {
        DE_EventManager.OnClicked += Teleport;
    }

    private void OnDisable()
    {
        DE_EventManager.OnClicked -= Teleport;
    }

    void Teleport()
    {
        Vector3 pos = transform.position;
        pos.y = Random.Range(.3f, 1.0f);
        transform.position = pos;
    }
}
