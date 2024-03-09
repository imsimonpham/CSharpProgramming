using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classes_Wizard : MonoBehaviour
{
    public Classes_Spell[] spells;

    public int level = 1;
    public int exp;
    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach(var spell in spells)
            {
                if (spell.levelRequired == level)
                {
                    spell.Cast();
                    exp += spell.expGained;
                }
            }
        }
    }
}
