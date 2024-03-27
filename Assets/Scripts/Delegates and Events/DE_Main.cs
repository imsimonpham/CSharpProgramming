using UnityEngine;

public class DE_Main : MonoBehaviour
{
    //delegate template
    delegate void MyDelegate(int num);

    //member variable 
    MyDelegate myDelegate;

    private void Start()
    {
        myDelegate = PrintNum;
        myDelegate(50);

        myDelegate = DoubleNum;
        myDelegate(50);
    }

    void PrintNum(int num)
    {
        print("Print Num: " + num);
    }

    void DoubleNum(int num)
    {
        print("Double Num: " + num * 2);
    }
}
