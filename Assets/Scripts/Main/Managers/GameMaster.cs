using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    [SerializeField] private GameObject LostMenu;

    void Start()
    {
        Time.timeScale = 1f;
    }

    public void ShowMenu()
    {
        GameObject.FindGameObjectWithTag("AM").GetComponent<AudioManager>().Play("Lost");
        GameObject.FindGameObjectWithTag("AM").GetComponent<AudioManager>().Stop("Background");
        LostMenu.SetActive(true);
        Time.timeScale = 0f;
    }
}
