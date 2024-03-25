using System.Collections.Generic;
using UnityEngine;

public class Dictionary_ItemDB : MonoBehaviour
{
    public List<Dictionary_Item> itemList = new List<Dictionary_Item>();
    public Dictionary<int, Dictionary_Item> itemDictionary = new Dictionary<int, Dictionary_Item>();

    private void Start()
    {
        Dictionary_Item sword = new Dictionary_Item();
        sword.name = "Sword";
        sword.id = 0;

        Dictionary_Item bread = new Dictionary_Item();
        bread.name = "Bread";
        bread.id = 1;

        Dictionary_Item cape = new Dictionary_Item();
        cape.name = "Cape";
        cape.id = 2;

        itemDictionary.Add(0, sword);
        itemDictionary.Add(1, bread);
        itemDictionary.Add(2, cape);

        //keys must be unique

        /*foreach (KeyValuePair<int, Dictionary_Item> item in itemDictionary)
        {
            Debug.Log("Key: " + item.Key);
            Debug.Log("Value: " + item.Value.name);
        }*/

        /*foreach(int key in itemDictionary.Keys)
        {
            Debug.Log("Key: " + key);
        }
        foreach(Dictionary_Item item in itemDictionary.Values)
        {
            Debug.Log("Item Name: " + item.name);
        }*/
        //Debug.Log(itemDictionary[0].id);

        if (itemDictionary.ContainsKey(1))
        {
            Debug.Log("You found the key");
            var randowmItem = itemDictionary[1];
        } else
        {
            Debug.Log("Key does not exist");
        }
    }
}
