using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class Color : MonoBehaviour
{

    private MeshRenderer _renderer;
    private WaitForSeconds _colorChangeWait = new WaitForSeconds(3f);
    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponent<MeshRenderer>();
        StartCoroutine(ColorRoutine());
    }

    IEnumerator ColorRoutine()
    {
        while (true)
        {
            _renderer.material.color = Random.ColorHSV();
            yield return _colorChangeWait;
        }

    }
}
