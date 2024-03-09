using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class Classes_CustomerDB : MonoBehaviour
{
    public Classes_Customer customerA;
    public Classes_Customer customerB;
    public Classes_Customer customerC;

    private void Start()
    {
        customerA = CreateCustomer("Jack", "Morrison", 27, Classes_Customer.genderType.Male, "Financial Consultant");
        customerB = CreateCustomer("Maximillian", "Johnson", 37, Classes_Customer.genderType.Male, "Police Officer");
        customerC = CreateCustomer("Rosie", "Creason", 34, Classes_Customer.genderType.Female, "Cook");
    }


    private Classes_Customer CreateCustomer(string firstName, string lastName, int age, Classes_Customer.genderType gender, string occupation)
    {
        var customer = new Classes_Customer(firstName, lastName, age, gender, occupation);
        return customer;
    }

}
