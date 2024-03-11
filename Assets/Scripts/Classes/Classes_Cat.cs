using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classes_Cat : Classes_Pet
{
    protected override void Speak()
    {
        Debug.Log("Meow!");
    }
}
