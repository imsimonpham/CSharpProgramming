using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int selectedLevel;

    private int _easy = 0;
    private int _medium = 1;
    private int _hard = 2;


    void Start()
    {
        selectedLevel = Random.Range(0, 3);
    }

    void Update()
    {
        switch(selectedLevel)
        {
            case 0:
                Debug.Log("You selected Easy!");
                break;
            case 1:
                Debug.Log("You selected Medium");
                break;
            case 2:
                Debug.Log("You selected Hard");
                break;
            default:
                Debug.Log("Invalid selection");
                break;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            selectedLevel = Random.Range(0, 3);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            selectedLevel = 55;
        }
    }
}
