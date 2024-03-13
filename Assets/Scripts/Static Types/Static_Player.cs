using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Static_Player : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Static_UtilityHelper.CreateObject();
        }

        if(Input.GetKeyDown(KeyCode.E))
        {
            Static_UtilityHelper.SetPositionToZero(this.gameObject);
        }
    }
}
