using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    [SerializeField] private PowerUpEffect powerUpEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("sssss");
        if (collision.CompareTag("Player"))
        {
            powerUpEffect.Apply(collision.gameObject);
            print(collision.GetComponent<PlayerHealth>().health);
        }
    }
}
