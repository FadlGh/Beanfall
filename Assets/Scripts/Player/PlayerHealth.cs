using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private int maxHealth = 3;
    public int health;

    void Start()
    {
        health = maxHealth;
    }

    public void ApplyDamage(int damage)
    {
        health -= damage;
    }
}
