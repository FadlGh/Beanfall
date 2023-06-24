using UnityEngine;
using UnityEngine.UI;

public class HeartHealth : MonoBehaviour
{
    private int health;

    [SerializeField] private Sprite fullHeart;
    [SerializeField] private Sprite emptyHeart;

    [SerializeField] private Image[] hearts;

    void Start()
    {
        health = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>().health;
        for (int i = 0; i < hearts.Length; i++)
        {
            hearts[i].sprite = fullHeart;
        }
    }

    void Update()
    {
        health = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>().health;
        for (int i = 0; i < hearts.Length; i++)
        {
            if (health < i + 1) 
            {
                hearts[i].sprite = emptyHeart;
            }
            else
            {
                hearts[i].sprite = fullHeart;
            }
        }
    }
}
