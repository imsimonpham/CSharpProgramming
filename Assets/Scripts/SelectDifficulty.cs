using UnityEngine;

public class SelectDifficulty : MonoBehaviour
{
    public enum LevelSelector
    {
        Easy, //0
        Normal, //1
        Hard, //2
        Expert, //3
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
            case LevelSelector.Expert:
                break;
        }
    }
}
