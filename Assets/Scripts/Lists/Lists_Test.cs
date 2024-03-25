using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lists_Test : MonoBehaviour
{
    [SerializeField] private List<string> _names = new List<string>();

    private void Start()
    {
        /*foreach(string name in _names)
        {
            Debug.Log(name);
        }*/

    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            int randomIndex = Random.Range(0, _names.Count);
            _names.Remove(_names[randomIndex]);
            foreach (string name in _names)
            {
                Debug.Log(name);
            }
        }
    }
}
