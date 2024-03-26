using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AC_Employee : MonoBehaviour
{
    public static string company = "ABC";
    public string employeeName;
    public abstract void CalculateMonthlySalary();
}
