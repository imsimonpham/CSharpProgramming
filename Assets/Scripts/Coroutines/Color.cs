using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;


namespace Coroutines
{
    public class Color : MonoBehaviour
    {

        private MeshRenderer _renderer;
        private WaitForSeconds _colorChangeWait = new WaitForSeconds(3f);
        internal static UnityEngine.Color green;

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
}

