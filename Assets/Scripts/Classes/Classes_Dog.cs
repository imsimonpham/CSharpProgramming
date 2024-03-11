using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classes_Dog : Classes_Pet
{
    protected override void Speak()
    {
        Debug.Log("Woof!");
    }
}
