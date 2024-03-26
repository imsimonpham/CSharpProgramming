using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AC_Dog : MonoBehaviour, AC_IAnimal
{
    public int legs { get; set; }
    public void MakeSound()
    {
        Debug.Log("Woof");
    }
}
