using UnityEngine;

public class Arrays_Challenge1 : MonoBehaviour
{
    public string[] names = new string[] { "James", "Jack", "Simon", "Alex", "Jerry" };
    public int[] ages = new int[] {15, 18, 21, 24, 24 };
    public string[] cars = new string[] {"Toyota", "Honda", "Mercedes", "BMW", "Mazda"};

    void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            int randomIndex = Random.Range(0, 5);
            Debug.Log(names[randomIndex] + ", " + ages[randomIndex] + ", " + cars[randomIndex]);
        }
    }
}
