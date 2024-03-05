using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge2 : MonoBehaviour
{
    //1 key = blue
    //2 key = red
    //3 key = green
    //4 key = black

    public int colorIndex;
    public GameObject cube;
    private MeshRenderer _renderer;

    private void Start()
    {
        _renderer = cube.GetComponent<MeshRenderer>();
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            colorIndex = 1;
        } else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            colorIndex = 2;
        } else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            colorIndex = 3;
        } else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            colorIndex = 4;
        }

        switch(colorIndex)
        {
            case 1:
                _renderer.material.color = new Color32(4, 59, 92, 255);
                break;
            case 2:
                _renderer.material.color = new Color32(196, 77, 86, 255);
                break;
            case 3:
                _renderer.material.color = new Color32(147, 250, 165, 255);
                break;
            case 4:
                _renderer.material.color = new Color32(60, 60, 60, 255);
                break;
        }
    }
}
