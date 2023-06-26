using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    private int maxHealth = 3;
    public int health;

    public UnityEvent playerDeath;

    void Start()
    {
        health = maxHealth;
    }

    void Update()
    {
        if (health <= 0)
            playerDeath.Invoke();
    }

    public void ApplyDamage(int damage)
    {
        health -= damage;
    }
}
