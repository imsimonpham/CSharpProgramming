using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface AC_IDamagable<T>
{
    int health { get; set; }
    void TakeDamage(T amount);
}