using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public enum EnemyState
    {
        Patroling,
        Attacking,
        Chasing,
        Death
    }

    public EnemyState currentState;

    void Start()
    {
        currentState = EnemyState.Patroling;
    }

    void Update()
    {
        switch(currentState)
        {
            case EnemyState.Patroling:
                Debug.Log("Patroling");
                if(Time.time > 5)
                {
                    currentState = EnemyState.Chasing;
                }
                break;
            case EnemyState.Attacking:
                Debug.Log("Attacking");
                break;
            case EnemyState.Chasing:
                Debug.Log("Chasing");
                break;
            case EnemyState.Death:
                Debug.Log("Death");
                break;
        }
    }
}
