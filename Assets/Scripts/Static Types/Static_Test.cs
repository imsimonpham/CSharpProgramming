using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Static_Item
{
    public string name;
    public int itemID;

    public static int itemCount;

    public Static_Item()
    {
        itemCount++;
    }
}

public class Static_Test : MonoBehaviour
{
    private void Start()
    {
        Static_Item coachGun = new Static_Item();
        Static_Item healthPack = new Static_Item();

        Debug.Log("Item Count: " + Static_Item.itemCount);
    }
}
