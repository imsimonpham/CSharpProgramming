using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Student
{
    public int studentID;
    public string firstName, lastName;
    public string major;

    public static string university;

    public Student()
    {
        Debug.Log("Instance member initialized");
    }

    static Student()
    {
        university = "Cape Breton University";
        Debug.Log("Intialized static member");
    }
}

public class Static_Test1 : MonoBehaviour
{
    private void Start()
    {
        Student student1 = new Student();
        Student student2 = new Student();
        Student student3 = new Student();
    }
}
