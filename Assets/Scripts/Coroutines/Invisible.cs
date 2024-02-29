using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invisible : MonoBehaviour
{

    private MeshRenderer _renderer;
    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            StartCoroutine(HideRoutine());
        }
    }

    IEnumerator HideRoutine()
    {
        _renderer.enabled = false;
        yield return new WaitForSeconds(5f);
        _renderer.enabled = true;
    }
}
