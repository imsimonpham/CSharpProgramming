using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Classes_Item
{
    public string name;
    public int id;
    public string description;

    public Classes_Item()
    {

    }

    public Classes_Item(string name, int id, string description)
    {
        this.name = name;
        this.id = id;
        this.description = description;
    }
}
