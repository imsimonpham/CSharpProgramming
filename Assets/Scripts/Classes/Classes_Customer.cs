using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[System.Serializable]
public class Classes_Customer
{
    public enum genderType
    {
        Male, 
        Female
    }

    public string firstName;
    public string lastName;
    public int age;
    public genderType gender;
    public string Occupation;

    public Classes_Customer(string firstName, string lastName, int age, genderType gender, string occupation)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.gender = gender;
        this.Occupation = occupation;
    }
}
