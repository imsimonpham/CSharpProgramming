using System.Collections.Generic;
using UnityEngine;

public class ItemDB : MonoBehaviour
{
    public List<Item> itemDB = new List<Item>();

    private void Start()
    {
        itemDB[0].Action();
    }
}
