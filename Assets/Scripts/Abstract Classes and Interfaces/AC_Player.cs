using UnityEngine;

public class AC_Player : MonoBehaviour, AC_IDamagable<int>, AC_IHealable
{
    public int health { get; set; }

    public void TakeDamage(int amount)
    {
        Debug.Log("Player is taking a damage amount of " + amount);
    }

    public void ReceiveHealing(int amount)
    {
        health += amount;
    }
}
