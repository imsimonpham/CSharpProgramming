using UnityEngine;

public class DE_EventManager : MonoBehaviour
{
    public delegate void ClickAction();
    public static event ClickAction OnClicked;


   public void ButtonClick()
    {
        if (OnClicked != null)
        {
            OnClicked();
        }
    }
}
