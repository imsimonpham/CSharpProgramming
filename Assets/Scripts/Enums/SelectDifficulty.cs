using UnityEngine;

public class SelectDifficulty : MonoBehaviour
{
    public enum LevelSelector
    {
        Easy, 
        Normal, 
        Hard
    }

    public LevelSelector _currentLevel;

    private void Start()
    {
        switch(_currentLevel)
        {
            case LevelSelector.Easy:
                break;
            case LevelSelector.Normal:
                break;
            case LevelSelector.Hard:
                break;
        }
    }
}
