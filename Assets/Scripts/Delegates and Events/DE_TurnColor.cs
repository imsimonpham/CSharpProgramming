using UnityEngine;

public class DE_TurnColor : MonoBehaviour
{
    private void OnEnable()
    {
        DE_EventManager.OnClicked += TurnColor;
    }

    private void OnDisable()
    {
        DE_EventManager.OnClicked -= TurnColor;
    }

    void TurnColor()
    {
        Color color = new Color(Random.value, Random.value, Random.value);
        GetComponent<MeshRenderer>().material.color =  color;
    }
}
