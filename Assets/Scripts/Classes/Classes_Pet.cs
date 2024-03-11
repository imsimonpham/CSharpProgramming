using OpenCover.Framework.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classes_Pet : MonoBehaviour
{
    protected string petName;

    protected virtual void Speak()
    {
        Debug.Log("Speak");
    }

    private void Start()
    {
        Speak();
    }
}
