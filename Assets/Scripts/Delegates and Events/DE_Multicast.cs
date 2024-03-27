using UnityEngine;

public class DE_Multicast : MonoBehaviour
{
    delegate void MultiDelegate();
    MultiDelegate myMultiDelegate;

    private void Start()
    {
        myMultiDelegate += PowerUp;
        myMultiDelegate += TurnRed;

        if(myMultiDelegate != null)
        {
            myMultiDelegate();
        }
    }

    void PowerUp()
    {
        Debug.Log("Player is powering up!");
    }

    void TurnRed()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
