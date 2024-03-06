using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ArrayItem
{
    public int itemID;
    public string name;
    public string description;
}

public class Arrays_Challenge2 : MonoBehaviour
{
    public ArrayItem[] myItems;

    private void Start()
    {
        foreach(var item in myItems)
        {
            Debug.Log(item.itemID);
        }
    }
}
