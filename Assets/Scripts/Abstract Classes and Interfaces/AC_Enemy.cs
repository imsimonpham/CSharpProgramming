using UnityEngine;

public class AC_Enemy : MonoBehaviour, AC_IDamagable<float>
{
    public int health { get; set; }

    public void TakeDamage(float amount)
    {
        Debug.Log("Enemy is taking a damage amount of " + amount);
    }
}
