using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AC_Main : MonoBehaviour
{
    [SerializeField] private AC_Dog _dog;
    [SerializeField] private AC_Cat _cat;
    public List<AC_IAnimal> animals = new List<AC_IAnimal>();

    void Start()
    {
        animals.Add(_dog);
        animals.Add(_cat);
        foreach(AC_IAnimal animal in animals)
        {
            animal.MakeSound();
        }
    }
}
