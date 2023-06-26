using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public UnityEvent playerDeath;

    private int maxHealth = 3;
    private bool hasRun;

    void Start()
    {
        health = maxHealth;
        hasRun = false;
    }

    void Update()
    {
        if (health <= 0 && !hasRun)
        {
            playerDeath.Invoke();
            hasRun = true;
        }
    }

    public void ApplyDamage(int damage)
    {
        health -= damage;
    }
}
