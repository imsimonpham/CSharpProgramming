using UnityEngine;

public class Properties_Game : MonoBehaviour
{

    private void Start()
    {
        Properties_Player player = new Properties_Player();

        player.Experience = 1;
        int exp = player.Experience;

        Debug.Log("The current experience is " + exp);
    }

}
