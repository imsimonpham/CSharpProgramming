using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Classes_Spell
{
    public string name;
    public int levelRequired;
    public int itemIdRequired;
    public int expGained;

    public Classes_Spell(string name, int levelRequired, int itemIdRequired, int expGained)
    {
        this.name = name;
        this.levelRequired = levelRequired;
        this.itemIdRequired = itemIdRequired;
        this.expGained = expGained;
    }

    public void Cast()
    {
        Debug.Log("Casting " + this.name);
    }
}
