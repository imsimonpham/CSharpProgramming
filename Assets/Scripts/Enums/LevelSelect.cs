using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public enum Difficulty
    {
        Easy,
        Normal,
        Hard
    }

    public Difficulty selectDifficulty;

    public void Start()
    {
        SceneManager.LoadScene((int)selectDifficulty);

    }
}
