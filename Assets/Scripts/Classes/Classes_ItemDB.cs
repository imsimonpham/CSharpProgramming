using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classes_ItemDB : MonoBehaviour
{
    public Classes_Item sword;
    public Classes_Item hammer;
    public Classes_Item bread;

    private void Start()
    {
        sword = new Classes_Item();
        sword.name = "Sword";
        sword.id = 1;
        sword.description = "This is a sword";

        hammer = new Classes_Item("Hammer", 2, "This is a hammer");

        bread = CreateItem("Bread", 3, "This is a bread");
    }

    private Classes_Item CreateItem(string name, int id, string description)
    {
        var item = new Classes_Item(name, id, description);
        return item;
    }
}
